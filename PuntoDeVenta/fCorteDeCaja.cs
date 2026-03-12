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
    public partial class fCorteDeCaja : Form
    {
        public fCorteDeCaja()
        {
            InitializeComponent();
        }

        private void fCorteDeCaja_Load(object sender, EventArgs e)
        {
            cbVendedores.DataSource = Clases.Datos.Vendedores();
            cbVendedores.DisplayMember = "Nombre";
            cbVendedores.ValueMember = "Id";
            dtpFecha1.Value = DateTime.Now;
            dtpFecha2.Value = DateTime.Now;
        }

        private void cbVendedores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = Clases.Datos.LasVenta(cbVendedores.SelectedValue.ToString(), dtpFecha1.Value.ToString("yyyyMMdd"), dtpFecha2.Value.ToString("yyyyMMdd"));
            dataGridView1.DataSource = dt;
            lSub.Text = string.Format("{0:#,0.00}", dt.Compute("Sum(SubTotal)", ""));
            lIva.Text = string.Format("{0:#,0.00}", dt.Compute("Sum(Iva)", ""));
            lTot.Text = string.Format("{0:#,0.00}", dt.Compute("Sum(Total)", ""));

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int r = 0; r < dataGridView1.Rows.Count; r++)
            {
                if (r % 2 == 0)
                    dataGridView1.Rows[r].DefaultCellStyle.BackColor = Color.Beige;
                else
                    dataGridView1.Rows[r].DefaultCellStyle.BackColor = Color.Moccasin;
            }
        }
    }
}
