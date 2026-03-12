namespace PuntoDeVenta
{
    partial class fVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fVentas));
            bBuscar = new Button();
            imageList2 = new ImageList(components);
            tbCodigo = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            pbImagen = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lCantidad = new Label();
            lFecha = new Label();
            lFolio = new Label();
            label5 = new Label();
            lTot = new Label();
            label4 = new Label();
            lSub = new Label();
            label7 = new Label();
            lIva = new Label();
            label9 = new Label();
            toolTip1 = new ToolTip(components);
            bEliminar = new Button();
            imageList1 = new ImageList(components);
            bGuardar = new Button();
            bEliminarArticulo = new Button();
            cbVendedores = new ComboBox();
            pbImagen2 = new PictureBox();
            pProcesando = new Panel();
            lProcesando = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen2).BeginInit();
            pProcesando.SuspendLayout();
            SuspendLayout();
            // 
            // bBuscar
            // 
            bBuscar.FlatAppearance.BorderSize = 0;
            bBuscar.ImageIndex = 0;
            bBuscar.ImageList = imageList2;
            bBuscar.Location = new Point(423, 90);
            bBuscar.Name = "bBuscar";
            bBuscar.Size = new Size(30, 29);
            bBuscar.TabIndex = 11;
            toolTip1.SetToolTip(bBuscar, "[ F1 ] Buscar articulos");
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
            // tbCodigo
            // 
            tbCodigo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbCodigo.Location = new Point(12, 89);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(441, 31);
            tbCodigo.TabIndex = 10;
            tbCodigo.TextChanged += tbCodigo_TextChanged;
            tbCodigo.KeyPress += tbCodigo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(14, 44);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 12;
            label1.Text = "Lo Atiende : ";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 132);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(511, 225);
            dataGridView1.TabIndex = 14;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            dataGridView1.KeyPress += dataGridView1_KeyPress;
            // 
            // pbImagen
            // 
            pbImagen.BackColor = Color.White;
            pbImagen.BorderStyle = BorderStyle.FixedSingle;
            pbImagen.Location = new Point(556, 69);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(313, 180);
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagen.TabIndex = 15;
            pbImagen.TabStop = false;
            pbImagen.Click += pbImagen_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lCantidad
            // 
            lCantidad.AutoSize = true;
            lCantidad.Font = new Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lCantidad.ForeColor = Color.Goldenrod;
            lCantidad.Location = new Point(473, 90);
            lCantidad.Name = "lCantidad";
            lCantidad.Size = new Size(50, 33);
            lCantidad.TabIndex = 18;
            lCantidad.Tag = "1";
            lCantidad.Text = "1 X";
            // 
            // lFecha
            // 
            lFecha.AutoSize = true;
            lFecha.BorderStyle = BorderStyle.FixedSingle;
            lFecha.Font = new Font("Candara", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lFecha.ForeColor = Color.Black;
            lFecha.Location = new Point(893, 20);
            lFecha.Name = "lFecha";
            lFecha.Size = new Size(2, 28);
            lFecha.TabIndex = 19;
            lFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lFolio
            // 
            lFolio.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lFolio.ForeColor = Color.SaddleBrown;
            lFolio.Location = new Point(115, 8);
            lFolio.Name = "lFolio";
            lFolio.Size = new Size(116, 23);
            lFolio.TabIndex = 21;
            lFolio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGoldenrod;
            label5.Location = new Point(14, 9);
            label5.Name = "label5";
            label5.Size = new Size(97, 23);
            label5.TabIndex = 20;
            label5.Text = "Folio Venta : ";
            // 
            // lTot
            // 
            lTot.BorderStyle = BorderStyle.FixedSingle;
            lTot.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lTot.ForeColor = Color.Blue;
            lTot.Location = new Point(104, 437);
            lTot.Name = "lTot";
            lTot.Size = new Size(149, 34);
            lTot.TabIndex = 23;
            lTot.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGoldenrod;
            label4.Location = new Point(14, 437);
            label4.Name = "label4";
            label4.Size = new Size(86, 34);
            label4.TabIndex = 22;
            label4.Text = "Total : ";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lSub
            // 
            lSub.BorderStyle = BorderStyle.FixedSingle;
            lSub.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lSub.ForeColor = Color.Blue;
            lSub.Location = new Point(104, 359);
            lSub.Name = "lSub";
            lSub.Size = new Size(149, 34);
            lSub.TabIndex = 25;
            lSub.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGoldenrod;
            label7.Location = new Point(12, 359);
            label7.Name = "label7";
            label7.Size = new Size(86, 34);
            label7.TabIndex = 24;
            label7.Text = "Sub :";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lIva
            // 
            lIva.BorderStyle = BorderStyle.FixedSingle;
            lIva.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lIva.ForeColor = Color.Blue;
            lIva.Location = new Point(106, 399);
            lIva.Name = "lIva";
            lIva.Size = new Size(147, 33);
            lIva.TabIndex = 27;
            lIva.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkGoldenrod;
            label9.Location = new Point(12, 399);
            label9.Name = "label9";
            label9.Size = new Size(88, 32);
            label9.TabIndex = 26;
            label9.Text = "Iva : ";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolTip1
            // 
            toolTip1.ForeColor = Color.Red;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Punto de Venta";
            // 
            // bEliminar
            // 
            bEliminar.DialogResult = DialogResult.Yes;
            bEliminar.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bEliminar.ImageAlign = ContentAlignment.TopCenter;
            bEliminar.ImageIndex = 5;
            bEliminar.ImageList = imageList1;
            bEliminar.Location = new Point(541, 264);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(102, 69);
            bEliminar.TabIndex = 28;
            bEliminar.Text = "Cancelar Venta";
            bEliminar.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(bEliminar, "[ Supr ] Elimina  la venta completa");
            bEliminar.UseVisualStyleBackColor = true;
            bEliminar.Click += bEliminar_Click;
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
            imageList1.Images.SetKeyName(4, "Guardar.png");
            imageList1.Images.SetKeyName(5, "Cancelar.png");
            imageList1.Images.SetKeyName(6, "Aceptar.png");
            // 
            // bGuardar
            // 
            bGuardar.DialogResult = DialogResult.Yes;
            bGuardar.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bGuardar.ImageAlign = ContentAlignment.TopCenter;
            bGuardar.ImageIndex = 6;
            bGuardar.ImageList = imageList1;
            bGuardar.Location = new Point(423, 366);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(100, 69);
            bGuardar.TabIndex = 29;
            bGuardar.Text = "Guardar";
            bGuardar.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(bGuardar, "[ Ctrl + G ] Guarda  la venta completa");
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += bGuardar_Click;
            // 
            // bEliminarArticulo
            // 
            bEliminarArticulo.DialogResult = DialogResult.No;
            bEliminarArticulo.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bEliminarArticulo.ImageAlign = ContentAlignment.TopCenter;
            bEliminarArticulo.ImageIndex = 2;
            bEliminarArticulo.ImageList = imageList1;
            bEliminarArticulo.Location = new Point(541, 339);
            bEliminarArticulo.Name = "bEliminarArticulo";
            bEliminarArticulo.Size = new Size(102, 69);
            bEliminarArticulo.TabIndex = 32;
            bEliminarArticulo.Text = "Eliminar ";
            bEliminarArticulo.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(bEliminarArticulo, "Eliminar Articulo Seleccionado");
            bEliminarArticulo.UseVisualStyleBackColor = true;
            bEliminarArticulo.Click += bEliminarArticulo_Click;
            // 
            // cbVendedores
            // 
            cbVendedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVendedores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbVendedores.ForeColor = Color.Blue;
            cbVendedores.FormattingEnabled = true;
            cbVendedores.Location = new Point(115, 41);
            cbVendedores.Name = "cbVendedores";
            cbVendedores.Size = new Size(216, 29);
            cbVendedores.TabIndex = 30;
            // 
            // pbImagen2
            // 
            pbImagen2.BackColor = Color.White;
            pbImagen2.BorderStyle = BorderStyle.FixedSingle;
            pbImagen2.Location = new Point(692, 254);
            pbImagen2.Name = "pbImagen2";
            pbImagen2.Size = new Size(313, 210);
            pbImagen2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagen2.TabIndex = 31;
            pbImagen2.TabStop = false;
            // 
            // pProcesando
            // 
            pProcesando.Controls.Add(lProcesando);
            pProcesando.Location = new Point(556, 8);
            pProcesando.Name = "pProcesando";
            pProcesando.Size = new Size(208, 55);
            pProcesando.TabIndex = 33;
            // 
            // lProcesando
            // 
            lProcesando.AutoSize = true;
            lProcesando.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lProcesando.ForeColor = Color.Crimson;
            lProcesando.Location = new Point(18, 12);
            lProcesando.Name = "lProcesando";
            lProcesando.Size = new Size(0, 19);
            lProcesando.TabIndex = 0;
            lProcesando.TextAlign = ContentAlignment.MiddleCenter;
            lProcesando.Click += label2_Click;
            // 
            // timer2
            // 
            timer2.Interval = 3000;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(259, 370);
            label2.Name = "label2";
            label2.Size = new Size(33, 23);
            label2.TabIndex = 45;
            label2.Text = "Mx";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(259, 447);
            label3.Name = "label3";
            label3.Size = new Size(33, 23);
            label3.TabIndex = 46;
            label3.Text = "Mx";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1013, 473);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pProcesando);
            Controls.Add(bEliminarArticulo);
            Controls.Add(pbImagen2);
            Controls.Add(cbVendedores);
            Controls.Add(bGuardar);
            Controls.Add(bEliminar);
            Controls.Add(lIva);
            Controls.Add(label9);
            Controls.Add(lSub);
            Controls.Add(label7);
            Controls.Add(lTot);
            Controls.Add(label4);
            Controls.Add(lFolio);
            Controls.Add(label5);
            Controls.Add(lFecha);
            Controls.Add(lCantidad);
            Controls.Add(pbImagen);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(bBuscar);
            Controls.Add(tbCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta";
            Load += fVentas_Load;
            KeyDown += fVentas_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen2).EndInit();
            pProcesando.ResumeLayout(false);
            pProcesando.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bBuscar;
        private ImageList imageList2;
        private TextBox tbCodigo;
        private Label label1;
        private DataGridView dataGridView1;
        private PictureBox pbImagen;
        private System.Windows.Forms.Timer timer1;
        private Label lCantidad;
        private Label lFecha;
        private Label lFolio;
        private Label label5;
        private Label lTot;
        private Label label4;
        private Label lSub;
        private Label label7;
        private Label lIva;
        private Label label9;
        private ToolTip toolTip1;
        private Button bEliminar;
        private ImageList imageList1;
        private Button bGuardar;
        private ComboBox cbVendedores;
        private PictureBox pbImagen2;
        private Button bEliminarArticulo;
        private Panel pProcesando;
        private Label lProcesando;
        private System.Windows.Forms.Timer timer2;
        private Label label2;
        private Label label3;
    }
}