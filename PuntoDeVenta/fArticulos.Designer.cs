namespace PuntoDeVenta
{
    partial class fArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fArticulos));
            dataGridView1 = new DataGridView();
            pPie = new Panel();
            label3 = new Label();
            ltama = new Label();
            label5 = new Label();
            lActivo = new Label();
            lTasaIva = new Label();
            label4 = new Label();
            lDepartamento = new Label();
            label2 = new Label();
            bImprimir = new Button();
            imageList1 = new ImageList(components);
            bEliminar = new Button();
            bEditar = new Button();
            bNuevo = new Button();
            bBuscar = new Button();
            imageList2 = new ImageList(components);
            tbFiltrar = new TextBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pPie.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 44);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(573, 312);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            dataGridView1.DoubleClick += bEditar_Click;
            dataGridView1.KeyPress += dataGridView1_KeyPress;
            // 
            // pPie
            // 
            pPie.BackColor = Color.Tan;
            pPie.Controls.Add(label3);
            pPie.Controls.Add(ltama);
            pPie.Controls.Add(label5);
            pPie.Controls.Add(lActivo);
            pPie.Controls.Add(lTasaIva);
            pPie.Controls.Add(label4);
            pPie.Controls.Add(lDepartamento);
            pPie.Controls.Add(label2);
            pPie.Controls.Add(bImprimir);
            pPie.Controls.Add(bEliminar);
            pPie.Controls.Add(bEditar);
            pPie.Controls.Add(bNuevo);
            pPie.Dock = DockStyle.Bottom;
            pPie.Location = new Point(0, 368);
            pPie.Name = "pPie";
            pPie.Size = new Size(677, 82);
            pPie.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGoldenrod;
            label3.Location = new Point(495, 31);
            label3.Name = "label3";
            label3.Size = new Size(29, 21);
            label3.TabIndex = 22;
            label3.Text = "ml";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ltama
            // 
            ltama.BorderStyle = BorderStyle.FixedSingle;
            ltama.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ltama.ForeColor = Color.DarkGoldenrod;
            ltama.Location = new Point(434, 29);
            ltama.Name = "ltama";
            ltama.Size = new Size(85, 23);
            ltama.TabIndex = 21;
            ltama.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.Khaki;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGoldenrod;
            label5.Location = new Point(318, 29);
            label5.Name = "label5";
            label5.Size = new Size(115, 22);
            label5.TabIndex = 20;
            label5.Text = "Tamaño:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lActivo
            // 
            lActivo.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lActivo.ForeColor = Color.DarkGoldenrod;
            lActivo.Location = new Point(490, 52);
            lActivo.Name = "lActivo";
            lActivo.Size = new Size(177, 23);
            lActivo.TabIndex = 19;
            lActivo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lTasaIva
            // 
            lTasaIva.BorderStyle = BorderStyle.FixedSingle;
            lTasaIva.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lTasaIva.ForeColor = Color.DarkGoldenrod;
            lTasaIva.Location = new Point(434, 51);
            lTasaIva.Name = "lTasaIva";
            lTasaIva.Size = new Size(55, 23);
            lTasaIva.TabIndex = 18;
            lTasaIva.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.Khaki;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGoldenrod;
            label4.Location = new Point(318, 51);
            label4.Name = "label4";
            label4.Size = new Size(115, 22);
            label4.TabIndex = 17;
            label4.Text = "Tasa Iva: ";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lDepartamento
            // 
            lDepartamento.BorderStyle = BorderStyle.FixedSingle;
            lDepartamento.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lDepartamento.ForeColor = Color.DarkGoldenrod;
            lDepartamento.Location = new Point(434, 5);
            lDepartamento.Name = "lDepartamento";
            lDepartamento.Size = new Size(237, 23);
            lDepartamento.TabIndex = 16;
            lDepartamento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.Khaki;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGoldenrod;
            label2.Location = new Point(318, 5);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 4;
            label2.Text = "Departamento: ";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // bImprimir
            // 
            bImprimir.DialogResult = DialogResult.No;
            bImprimir.ImageAlign = ContentAlignment.TopCenter;
            bImprimir.ImageIndex = 3;
            bImprimir.ImageList = imageList1;
            bImprimir.Location = new Point(237, 7);
            bImprimir.Name = "bImprimir";
            bImprimir.Size = new Size(75, 69);
            bImprimir.TabIndex = 3;
            bImprimir.Text = "Imprimir";
            bImprimir.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(bImprimir, "[ Ctrl + I ] Imprime el catalogo de articulos");
            bImprimir.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Nuevo.png");
            imageList1.Images.SetKeyName(1, "Editar.png");
            imageList1.Images.SetKeyName(2, "Eliminar.png");
            imageList1.Images.SetKeyName(3, "Imprimir.png");
            // 
            // bEliminar
            // 
            bEliminar.DialogResult = DialogResult.Yes;
            bEliminar.Enabled = false;
            bEliminar.ImageAlign = ContentAlignment.TopCenter;
            bEliminar.ImageIndex = 2;
            bEliminar.ImageList = imageList1;
            bEliminar.Location = new Point(160, 7);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(75, 69);
            bEliminar.TabIndex = 2;
            bEliminar.Text = "Eliminar";
            bEliminar.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(bEliminar, "[ Ctrl + Supr ] elimina el articulo seleccionado");
            bEliminar.UseVisualStyleBackColor = true;
            bEliminar.Click += bEliminar_Click;
            // 
            // bEditar
            // 
            bEditar.DialogResult = DialogResult.No;
            bEditar.Enabled = false;
            bEditar.ImageAlign = ContentAlignment.TopCenter;
            bEditar.ImageIndex = 1;
            bEditar.ImageList = imageList1;
            bEditar.Location = new Point(83, 7);
            bEditar.Name = "bEditar";
            bEditar.Size = new Size(75, 69);
            bEditar.TabIndex = 1;
            bEditar.Text = "Editar";
            bEditar.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(bEditar, "[ Ctrl + E] Edita el articulo seleccionado");
            bEditar.UseVisualStyleBackColor = true;
            bEditar.Click += bEditar_Click;
            // 
            // bNuevo
            // 
            bNuevo.DialogResult = DialogResult.Yes;
            bNuevo.ImageAlign = ContentAlignment.TopCenter;
            bNuevo.ImageIndex = 0;
            bNuevo.ImageList = imageList1;
            bNuevo.Location = new Point(6, 7);
            bNuevo.Name = "bNuevo";
            bNuevo.Size = new Size(75, 69);
            bNuevo.TabIndex = 0;
            bNuevo.Text = "Nuevo";
            bNuevo.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(bNuevo, "[ Insert ] Agrega un nuevo articulo");
            bNuevo.UseVisualStyleBackColor = true;
            bNuevo.Click += bNuevo_Click;
            // 
            // bBuscar
            // 
            bBuscar.FlatAppearance.BorderSize = 0;
            bBuscar.ImageIndex = 0;
            bBuscar.ImageList = imageList2;
            bBuscar.Location = new Point(638, 8);
            bBuscar.Name = "bBuscar";
            bBuscar.Size = new Size(31, 31);
            bBuscar.TabIndex = 13;
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
            // tbFiltrar
            // 
            tbFiltrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbFiltrar.Location = new Point(65, 9);
            tbFiltrar.Name = "tbFiltrar";
            tbFiltrar.Size = new Size(595, 29);
            tbFiltrar.TabIndex = 12;
            tbFiltrar.KeyPress += tbFiltrar_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 11;
            label1.Text = "Filtrar";
            // 
            // toolTip1
            // 
            toolTip1.ForeColor = Color.Red;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Punto de Venta";
            // 
            // fArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(677, 450);
            Controls.Add(dataGridView1);
            Controls.Add(pPie);
            Controls.Add(bBuscar);
            Controls.Add(tbFiltrar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fArticulos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Articulos Disponibles";
            Load += fArticulos_Load;
            KeyDown += fArticulos_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pPie.ResumeLayout(false);
            pPie.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel pPie;
        private Button bEditar;
        private ImageList imageList1;
        private ToolTip toolTip1;
        private Button bNuevo;
        private Button bBuscar;
        private ImageList imageList2;
        private TextBox tbFiltrar;
        private Label label1;
        private Button bImprimir;
        private Button bEliminar;
        private Label lDepartamento;
        private Label label2;
        private Label lTasaIva;
        private Label label4;
        private Label lActivo;
        private Label ltama;
        private Label label5;
        private Label label3;
    }
}