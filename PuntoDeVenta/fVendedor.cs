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
    public partial class fVendedor : Form
    {
        Clases.Vendedor Vend;
        public fVendedor()
        {
            InitializeComponent();
        }
        private void Activar(bool estatus)
        {
            Pini.Enabled = estatus;
            Pde.Enabled = estatus == false;
            pPie.Enabled = !estatus;
            if (estatus)
            {
                tbId.Clear();
                tbNom.Text = string.Empty;
                tbId.Text = Clases.Datos.SiguienteVend().ToString();
                tbId.Focus();
            }
            else
            {
                tbNom.Focus();
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lnom_Click(object sender, EventArgs e)
        {

        }

        private void fVendedor_Load(object sender, EventArgs e)
        {
            lNuevo.Text = string.Empty;
            Activar(true); lNuevo.Text = string.Empty;

        }

        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Vend = new Clases.Vendedor(int.Parse(tbId.Text));
                tbNom.Text = Vend.Nombre;

                if (Vend.Nuevo)
                    lNuevo.Text = "Disponible";
                else
                    lNuevo.Text = "Editando";
                Activar(false);
                bEliminar.Enabled = !Vend.Nuevo;
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Cancelar el registro\n" + tbNom.Text, "Cuidado:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Activar(true);
            else
                tbNom.Focus();

        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Eliminar el registro\n" + tbNom.Text, "Cuidado:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Vend.Eliminar();
                Activar(true);
            }
            else
                tbNom.Focus();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            Vend.Id = int.Parse(tbId.Text);
            Vend.Nombre = tbNom.Text;
            string res = Vend.Guardar();
            if (res != "OK")
                MessageBox.Show("El departamento de \n" + tbNom.Text + "\nQuedó registrado con el Id: " + res, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Activar(true);
        }

        private void fVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && bCancelar.Enabled)
                bCancelar_Click(sender, new EventArgs());

            if (e.KeyCode == Keys.F1 && bBuscar.Enabled)
                bBuscar_Click(sender, new EventArgs());

            if (e.Control)
            {
                if (e.KeyCode == Keys.G && bGuardar.Enabled)
                    bGuardar_Click(sender, new EventArgs());
                if (e.KeyCode == Keys.Delete && bEliminar.Enabled)
                    bEliminar_Click(sender, new EventArgs());

            }
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            Busqueda f = new Busqueda();
            string res = f.Buscar("Vendedores", "Id", "Nombre");
            if (res != null)
            {
                tbId.Text = res;
                tbId_KeyPress(sender, Clases.Datos.enter);
            }
        }
    }
}
