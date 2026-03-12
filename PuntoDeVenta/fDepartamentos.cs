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
    public partial class fDepartamentos : Form
    {
        Clases.Departamento MiDepa;
        public fDepartamentos()
        {
            InitializeComponent();
        }

        private void fDepartamentos_Load(object sender, EventArgs e)
        {
            lNuevo.Text = string.Empty;
            Activar(true);
        }
        private void Activar(bool estatus)
        {
            pcabecera.Enabled = estatus;
            pDetalle.Enabled = estatus == false;
            pPie.Enabled = !estatus;
            if (estatus)
            {
                tbId.Clear();
                tbNombre.Text = string.Empty;
                tbId.Text = Clases.Datos.SiguienteDepa().ToString();
                CbMili.Checked = false;
                tbId.Focus();
            }
            else
            {
                tbNombre.Focus();
            }
        }
        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MiDepa = new Clases.Departamento(int.Parse(tbId.Text));
                tbNombre.Text = MiDepa.Nombre;

                if (MiDepa.Nuevo)
                    lNuevo.Text = "Nuevo";
                else
                    lNuevo.Text = "Editando";
               
                Activar(false);
                bEliminar.Enabled = !MiDepa.Nuevo;
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Cancelar el registro\n" + tbNombre.Text, "Cuidado:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Activar(true);
            else
                tbNombre.Focus();


        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Eliminar el registro\n" + tbNombre.Text, "Cuidado:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MiDepa.Eliminar();
                Activar(true);
            }
            else
                tbNombre.Focus();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            MiDepa.Id = int.Parse(tbId.Text);
            MiDepa.Nombre = tbNombre.Text;
            MiDepa.UsaTamaMl = CbMili.Checked;
            string res = MiDepa.Guardar();
            if (res != "OK")
                MessageBox.Show("El departamento de \n" + tbNombre.Text + "\nQuedó registrado con el Id: " + res, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Activar(true);
        }

        private void bGuardar_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void fDepartamentos_KeyDown(object sender, KeyEventArgs e)
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
                if (e.KeyCode == Keys.I && bImprimir.Enabled)
                    bImprimir_Click(sender, new EventArgs());
            }
        }

        private void bImprimir_Click(object sender, EventArgs e)
        {

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            Busqueda f = new Busqueda();
            string res = f.Buscar("Departamentos", "Id", "Nombre");
            if (res != null)
            {
                tbId.Text = res;
                tbId_KeyPress(sender, Clases.Datos.enter);
            }
        }
    }
}
