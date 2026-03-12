namespace PuntoDeVenta
{
    partial class Busqueda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busqueda));
            label1 = new Label();
            tbFiltrar = new TextBox();
            bBuscar = new Button();
            imageList2 = new ImageList(components);
            toolTip1 = new ToolTip(components);
            bCancelar = new Button();
            imageList1 = new ImageList(components);
            bAceptar = new Button();
            pPie = new Panel();
            dataGridView1 = new DataGridView();
            pPie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Filtrar";
            label1.Click += label1_Click;
            // 
            // tbFiltrar
            // 
            tbFiltrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbFiltrar.Location = new Point(78, 15);
            tbFiltrar.Name = "tbFiltrar";
            tbFiltrar.Size = new Size(501, 29);
            tbFiltrar.TabIndex = 1;
            tbFiltrar.TextChanged += tbFiltrar_TextChanged;
            tbFiltrar.KeyPress += tbFiltrar_KeyPress;
            // 
            // bBuscar
            // 
            bBuscar.FlatAppearance.BorderSize = 0;
            bBuscar.ImageIndex = 0;
            bBuscar.ImageList = imageList2;
            bBuscar.Location = new Point(548, 13);
            bBuscar.Name = "bBuscar";
            bBuscar.Size = new Size(31, 31);
            bBuscar.TabIndex = 8;
            toolTip1.SetToolTip(bBuscar, "Filtra los datos");
            bBuscar.UseVisualStyleBackColor = true;
            bBuscar.Click += bBuscar_Click;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "Buscar.png");
            imageList2.Images.SetKeyName(1, "Imprimir.png");
            // 
            // toolTip1
            // 
            toolTip1.ForeColor = Color.Red;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Punto de Venta";
            toolTip1.Popup += toolTip1_Popup;
            // 
            // bCancelar
            // 
            bCancelar.DialogResult = DialogResult.No;
            bCancelar.ImageAlign = ContentAlignment.TopCenter;
            bCancelar.ImageIndex = 0;
            bCancelar.ImageList = imageList1;
            bCancelar.Location = new Point(107, 7);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(75, 69);
            bCancelar.TabIndex = 1;
            bCancelar.Text = "Cancelar";
            bCancelar.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(bCancelar, "[Esc] Ignora los datos en proceso");
            bCancelar.UseVisualStyleBackColor = true;
            bCancelar.Click += bCancelar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Cancelar.png");
            imageList1.Images.SetKeyName(1, "Aceptar.png");
            // 
            // bAceptar
            // 
            bAceptar.DialogResult = DialogResult.Yes;
            bAceptar.ImageAlign = ContentAlignment.TopCenter;
            bAceptar.ImageIndex = 1;
            bAceptar.ImageList = imageList1;
            bAceptar.Location = new Point(26, 7);
            bAceptar.Name = "bAceptar";
            bAceptar.Size = new Size(75, 69);
            bAceptar.TabIndex = 0;
            bAceptar.Text = "Aceptar";
            bAceptar.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(bAceptar, "[ Enter ] Acepta el registro actual");
            bAceptar.UseVisualStyleBackColor = true;
            bAceptar.Click += bAceptar_Click;
            // 
            // pPie
            // 
            pPie.BackColor = Color.Tan;
            pPie.Controls.Add(bCancelar);
            pPie.Controls.Add(bAceptar);
            pPie.Dock = DockStyle.Bottom;
            pPie.Location = new Point(0, 368);
            pPie.Name = "pPie";
            pPie.Size = new Size(595, 82);
            pPie.TabIndex = 9;
            pPie.Paint += pPie_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 50);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(571, 312);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            dataGridView1.DoubleClick += bAceptar_Click;
            dataGridView1.KeyPress += dataGridView1_KeyPress;
            // 
            // Busqueda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(595, 450);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(pPie);
            Controls.Add(bBuscar);
            Controls.Add(tbFiltrar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Busqueda";
            Text = "Busqueda";
            pPie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbFiltrar;
        private Button bBuscar;
        private ImageList imageList2;
        private ToolTip toolTip1;
        private ImageList imageList1;
        private Button bCancelar;
        private Button bAceptar;
        private Panel pPie;
        private DataGridView dataGridView1;
    }
}