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
    public partial class Busqueda : Form
    {
        string miTabla, miRetorno, miOrdenar, resultado = null;
        DataTable tabla;
        public Busqueda()
        {
            InitializeComponent();
        }
        public string Buscar(string tabla, string retorno, string ordenar)
        {
            miTabla = tabla;
            miRetorno = retorno;
            miOrdenar = ordenar;
            this.ShowDialog();
            return resultado;
        }
        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (tabla != null && tabla.Rows.Count > 0)
            {
                resultado = dataGridView1.CurrentRow.Cells[miRetorno].Value.ToString();
            }
            Close();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            string miSelect = $"Select {miRetorno},{miOrdenar} from {miTabla} where {miOrdenar} like '%{tbFiltrar.Text}%'";
            tabla = Clases.Datos.Consulta(miSelect);
            dataGridView1.DataSource = tabla;
            dataGridView1.Columns[1].Width = dataGridView1.Width - dataGridView1.Columns[0].Width - 20;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            resultado = null;
            Close();
        }

        private void tbFiltrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                bBuscar_Click(sender, e);
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                bAceptar_Click(sender, e);
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

        private void pPie_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tbFiltrar_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
        }
    }
}
