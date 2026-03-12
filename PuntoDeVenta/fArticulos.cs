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
    public partial class fArticulos : Form
    {
        DataTable tabla;
        public fArticulos()
        {
            InitializeComponent();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            tabla = Clases.Datos.Consulta($"Select * from articulos where nombre like '%" + tbFiltrar.Text + "%'");
            dataGridView1.DataSource = tabla;

            bEditar.Enabled = dataGridView1.RowCount > 0;
            bEliminar.Enabled = tabla.Rows.Count > 0;

            dataGridView1.Columns["Departamento"].Visible = false;
            dataGridView1.Columns["TasaIva"].Visible = false;
            dataGridView1.Columns["Activo"].Visible = false;

            if (dataGridView1.Columns.Contains("Nombre"))
                dataGridView1.Columns["Nombre"].Width = 252;

            if (dataGridView1.Columns.Contains("Codigo"))
                dataGridView1.Columns["Codigo"].Width = 160;

            if (dataGridView1.Columns.Contains("Precio"))
            {
                dataGridView1.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns["Precio"].DefaultCellStyle.Format = "C2";
                dataGridView1.Columns["Precio"].Width = 160;
            }

            if (dataGridView1.Columns.Contains("TamaMl"))
                dataGridView1.Columns["TamaMl"].Width = 160;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void tbFiltrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                bBuscar_Click(sender, e);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["Activo"].Value.ToString() == "S")
            {
                lActivo.Text = "Activo";
                lActivo.ForeColor = Color.Green;
            }
            else
            {
                lActivo.Text = "Inactivo";
                lActivo.ForeColor = Color.Red;
            }
            ltama.Text = dataGridView1.Rows[e.RowIndex].Cells["TamaMl"].Value.ToString();
            lTasaIva.Text = dataGridView1.Rows[e.RowIndex].Cells["TasaIva"].Value.ToString();
            lDepartamento.Text = dataGridView1.Rows[e.RowIndex].Cells["Departamento"].Value.ToString();
            Clases.Departamento d = new Clases.Departamento(int.Parse(lDepartamento.Text));
            lDepartamento.Text += " - " + d.Nombre;
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el articulo:\n" + dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString(), "Precaución:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Clases.Articulo a = new Clases.Articulo(dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());
                a.Eliminar();
                bBuscar_Click(sender, e);
            }
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            fArticulo f = new fArticulo();
            f.ShowDialog();
            bBuscar_Click(sender, e);
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            fArticulo f = new fArticulo(dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());
            f.ShowDialog();
            bBuscar_Click(sender, e);
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                bEditar_Click(sender, e);
        }

        private void fArticulos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
                bNuevo_Click(sender, e);

            if (e.Control)
            {
                if (e.KeyCode == Keys.E)
                    bEditar_Click(sender, e);
                if (e.KeyCode == Keys.Delete)
                    bEliminar_Click(sender, e);
                //if (e.KeyCode == Keys.I )
                //    bImprimir_Click(sender, new EventArgs());
            }
        }

        private void fArticulos_Load(object sender, EventArgs e)
        {

        }
    }
}
