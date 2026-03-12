using Microsoft.VisualBasic;

namespace PuntoDeVenta
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private bool Abierta(string formulario)
        {
            bool res = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == formulario)
                {
                    res = true;
                    f.Activate();
                    break;
                }
            }
            return res;
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Abierta("fDepartamentos"))
            {
                fDepartamentos f = new fDepartamentos();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Abierta("fArticulos") == false)
            {
                fArticulos f = new fArticulos();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count > 1)
                e.Cancel = true;
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Abierta("fVentas") == false)
            {
                fVentas f = new fVentas();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void corteDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Abierta("fCorteDeCaja") == false)
            {
                fCorteDeCaja f = new fCorteDeCaja();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lFecha.Text = DateTime.Now.ToString("d");
            lhora.Text = DateTime.Now.ToString("t");


        }

        private void verificadorDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Abierta("fVendedor"))
            {
                fVendedor f = new fVendedor();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {


            var result = MessageBox.Show("¿Seguro que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void datosDeLaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Abierta("DEmpresa"))
            {
                DEmpresa f = new DEmpresa();
                f.MdiParent = this;
                f.Show();
            }

        }
    }

}


