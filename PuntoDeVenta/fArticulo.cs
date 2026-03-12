using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class fArticulo : Form
    {
        Clases.Articulo miArticulo;
        public fArticulo(string codigo = null)
        {
            InitializeComponent();
            if (codigo != null)
            {
                miArticulo = new Clases.Articulo(codigo);
                tbCodigo.Text = codigo;
                tbNombre.Text = miArticulo.Nombre;
                cbDepartamento.SelectedItem = miArticulo.Departamento;
                tbPrecio.Text = miArticulo.Precio.ToString();

                if (miArticulo.TamaMl == 0)
                    cbTama.SelectedIndex = 1;
                else
                    cbTama.SelectedIndex = 0;

                if (miArticulo.TasaIva == 0)
                    cbTasaIva.SelectedIndex = 0;
                else
                    cbTasaIva.SelectedIndex = 1;

                chbActivo.Checked = miArticulo.Activo == "S";
                tbCodigo.Enabled = false;
                tbNombre.Focus();
            }
            else
            {
                miArticulo = new Clases.Articulo("Nuevo");
                chbActivo.Checked = true;
                chbActivo.Enabled = false;
                tbCodigo.Focus();


                miArticulo.TasaIva = 16;
                cbTasaIva.SelectedIndex = 1;


            }

            cbDepartamento.DataSource = Clases.Datos.Consulta("Select Id,Nombre from departamentos");
            cbDepartamento.DisplayMember = "Nombre";
            cbDepartamento.ValueMember = "Id";
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (miArticulo.Nuevo)
            {
                var res = Clases.Articulo.Existe(tbCodigo.Text);
                if (res != "Error")
                {
                    MessageBox.Show($"El codigo '{tbCodigo.Text}' ya esta registrado.\n{res}", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCodigo.Focus();
                    return;
                }
                //Clases.Articulo a = new Clases.Articulo(tbCodigo.Text);
                //if (a.Nuevo == false)
                //{
                //    MessageBox.Show($"El codigo '{tbCodigo.Text}' ya esta registrado.\n{a.Nombre}", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    tbCodigo.Focus();
                //    return;
                //}
            }
            miArticulo.Codigo = tbCodigo.Text;
            miArticulo.Nombre = tbNombre.Text;
            miArticulo.Departamento = (int)cbDepartamento.SelectedValue;
            double pre;
            double.TryParse(tbPrecio.Text, out pre);
            miArticulo.Precio = pre;
            if (cbTama.SelectedIndex == 0)
                miArticulo.TamaMl = 590;
            else
                miArticulo.TamaMl = 390;

            var departamentoSeleccionado = new Clases.Departamento(miArticulo.Departamento);
            if (departamentoSeleccionado.UsaTamaMl)
            {
                if (cbTama.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un tamaño válido.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbTama.Focus();
                    return;
                }
                miArticulo.TamaMl = int.Parse(cbTama.SelectedItem.ToString());
            }
            else
            {
                miArticulo.TamaMl = 0; // No asignar TamaMl si no es requerido
            }

            if (cbTasaIva.SelectedIndex == 0)
                miArticulo.TasaIva = 0;
            else
                miArticulo.TasaIva = 16;

            miArticulo.TasaIva = (cbTasaIva.SelectedIndex == 0) ? 0 : 16;

            if (chbActivo.Checked)
                miArticulo.Activo = "S";
            else
                miArticulo.Activo = "N";
            miArticulo.Guardar();
            Close();
        }

        private void fArticulo_Load(object sender, EventArgs e)
        {
            cbTama.Items.Clear();
            cbTama.Items.AddRange(new object[] { "390", "590", "No Disponible" }); // Ejemplo de tamaños y "No aplica"
            cbTama.SelectedIndex = -1;

        }

        private void cbTasaIva_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int depaId = Convert.ToInt32(cbDepartamento.SelectedValue);

            var departamento = new Clases.Departamento(depaId);

            if (cbDepartamento.SelectedValue != null)
            {
                 depaId = Convert.ToInt32(cbDepartamento.SelectedValue);
                miArticulo.Departamento = depaId;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un departamento válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          

            if (departamento.UsaTamaMl)
            {
                cbTama.Enabled = true;
                cbTama.Items.Clear();
                cbTama.Items.AddRange(new object[] { "390", "590" }); 
                cbTama.SelectedIndex = 0; 
            }
            else
            {
                cbTama.Enabled = false;
                cbTama.Items.Clear();
                cbTama.Items.Add("No disponible"); 
                cbTama.SelectedIndex = 0;
            }
        }
    }
}
