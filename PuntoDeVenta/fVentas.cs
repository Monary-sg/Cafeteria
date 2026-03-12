using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;using System.Windows.Forms;  // Asegúrate de tener este using


namespace PuntoDeVenta
{
    public partial class fVentas : Form
    {
        DataTable dt;

        public fVentas()
        {
            InitializeComponent();
        }

        private void fVentas_Load(object sender, EventArgs e)
        {
            CargaImagen1("PV1");
            CargaImagen("CF1");
            timer1.Start();
         
            lFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbVendedores.DataSource = Clases.Datos.Vendedores();
            cbVendedores.ValueMember = "Id";
            cbVendedores.DisplayMember = "Nombre";
            Activar();
        }
        private void Activar()
        {
            lFolio.Text = Clases.Datos.SiguienteFolio().ToString();
            CargaDatos();
        }
        private void CargaImagen(string archivo)
        {
            string archivito = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), $"..\\..\\..\\Imagenes\\{archivo}.png");
            if (!File.Exists(archivito))
            {
                archivito = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), $"..\\..\\..\\Imagenes\\{archivo}.jpg");
            }

            pbImagen2.Image = Image.FromFile(archivito);
        }
        private void CargaImagen1(string archivo)
        {
            string archivito = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), $"..\\..\\..\\Imagenes\\{archivo}.png");
            if (!File.Exists(archivito))
            {
                archivito = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), $"..\\..\\..\\Imagenes\\{archivo}.jpg");
            }
            pbImagen.Image = Image.FromFile(archivito);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            CargaImagen1($"PV{r.Next(1, 10)}");
            CargaImagen($"CF{r.Next(1, 10)}");
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (tbCodigo.Text.EndsWith('*'))
                {
                    lCantidad.Text = tbCodigo.Text.Substring(0, tbCodigo.Text.Length - 1) + " X";
                    lCantidad.Tag = tbCodigo.Text.Substring(0, tbCodigo.Text.Length - 1);
                    tbCodigo.Clear();
                }

                int pos = tbCodigo.Text.IndexOf('*');
                if (pos > 0)
                {
                    lCantidad.Text = tbCodigo.Text.Substring(0, pos) + " X";
                    lCantidad.Tag = tbCodigo.Text.Substring(0, pos);
                    tbCodigo.Text = tbCodigo.Text.Substring(pos + 1, tbCodigo.Text.Length - 1 - pos);
                }
                if (tbCodigo.Text.Length > 0)
                {
                    Clases.Articulo a = new Clases.Articulo(tbCodigo.Text);
                    if (a.Nuevo)
                    {
                        MessageBox.Show("Articulo no registrado", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbCodigo.Focus();
                    }
                    int ren = 0;

                    Clases.Datos.GuardaVenta(int.Parse(lFolio.Text), 0, tbCodigo.Text, int.Parse(lCantidad.Tag.ToString()), a.Precio, a.TasaIva, a.TamaMl);
                    lCantidad.Text = "1 X";
                    lCantidad.Tag = 1;
                    tbCodigo.Clear();
                    tbCodigo.Focus();
                    CargaDatos();
                }
            }
        }
        private void CargaDatos()
        {
            dt = Clases.Datos.LaVenta(lFolio.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Renglon"].Visible = false;
            dataGridView1.Columns["SubTotal"].Visible = false;
            dataGridView1.Columns["TasaIva"].Visible = false;
            dataGridView1.Columns["Iva"].Visible = false;

            dataGridView1.Columns["Nombre"].Width = 200;

            if (dataGridView1.Columns.Contains("Cantidad"))
            {
                dataGridView1.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
                dataGridView1.Columns["Cantidad"].Width = 80;
            }


            if (dataGridView1.Columns.Contains("Precio"))
            {
                dataGridView1.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns["Precio"].DefaultCellStyle.Format = "N2";
                dataGridView1.Columns["Precio"].Width = 100;
            }

            if (dataGridView1.Columns.Contains("Total"))
            {
                dataGridView1.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns["Total"].DefaultCellStyle.Format = "N2";
                dataGridView1.Columns["Total"].Width = 80;
            }





            lSub.Text = string.Format("{0:#,0.00}", dt.Compute("Sum(SubTotal)", ""));
            lIva.Text = string.Format("{0:#,0.00}", dt.Compute("Sum(Iva)", ""));
            lTot.Text = string.Format("{0:#,0.00}", dt.Compute("Sum(Total)", ""));
            tbCodigo.Focus();
        }
        private void tbCodigo_TextChanged(object sender, EventArgs e)
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

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Deseas eliminar el articulo\n" + dataGridView1.CurrentRow.Cells["Nombre"].Value, "Precaucion.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Clases.Datos.EliminaRenglon(int.Parse(lFolio.Text), (int)dataGridView1.CurrentRow.Cells["Renglon"].Value);
                    CargaDatos();
                }
                tbCodigo.Focus();
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                tbCodigo.Focus();
                return;
            }
            if (MessageBox.Show($"Deseas eliminar los {dataGridView1.Rows.Count} articulos de la venta", "Precaucion.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Clases.Datos.EliminaVenta(int.Parse(lFolio.Text));
                CargaDatos();
                tbCodigo.Focus();
            }

        }
        private System.Windows.Forms.Timer processingTimer = new System.Windows.Forms.Timer();
        private int processingStep = 0;  


        private void bGuardar_Click(object sender, EventArgs e)
        {

                var result = MessageBox.Show("¿La compra fue Pagada?", "Confirmar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    MessageBox.Show("Procesando datos, por favor espere...", "Procesando...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    processingTimer.Interval = 500;  
                    processingTimer.Tick += (s, args) =>
                    {
                        
                        switch (processingStep)
                        {
                            case 0:
                                Console.WriteLine("Procesando datos... Cargando información.");
                                break;
                            case 1:
                                Console.WriteLine("Validando datos...");
                                break;
                            case 2:
                                Console.WriteLine("Confirmando pago...");
                                break;
                            case 3:
                                Console.WriteLine("Guardando datos de la venta...");
                                Clases.Datos.GuardaVenta(lFolio.Text, cbVendedores.SelectedValue.ToString(), DateTime.Now, lSub.Text, lIva.Text, lTot.Text, dt);
                                processingTimer.Stop();
                                MessageBox.Show("Datos procesados con éxito. La venta ha sido guardada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Activar();  
                                break;
                        }

                      
                        processingStep++;
                    };

                    processingTimer.Start();
                }
            else
            {
            
                MessageBox.Show("Error: El pago no fue realizado. La venta no se puede procesar.", "Error de Pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            Busqueda f = new Busqueda();
            string res = f.Buscar("Articulos", "Codigo", "Nombre");
            if (res != null)
            {
                tbCodigo.Text += res;
                tbCodigo_KeyPress(sender, Clases.Datos.enter);
            }
        }

        private void fVentas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                bBuscar_Click(sender, e);
            if (e.Control && e.KeyCode == Keys.G)
                bGuardar_Click(sender, e);
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {

        }

        private void bEliminarArticulo_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un artículo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

             var filaSeleccionada = dataGridView1.SelectedRows[0];
            string nombreArticulo = filaSeleccionada.Cells["Nombre"].Value.ToString();
            int renglon = Convert.ToInt32(filaSeleccionada.Cells["Renglon"].Value);

            var confirmResult = MessageBox.Show($"¿Desea eliminar el artículo {nombreArticulo}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                Clases.Datos.EliminaRenglon(int.Parse(lFolio.Text), renglon);

                CargaDatos();

                MessageBox.Show("Artículo eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void bEditarCantidad_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
