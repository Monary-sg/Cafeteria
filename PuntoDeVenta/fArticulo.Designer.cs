namespace PuntoDeVenta
{
    partial class fArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fArticulo));
            toolTip1 = new ToolTip(components);
            bCancelar = new Button();
            imageList1 = new ImageList(components);
            bAceptar = new Button();
            button2 = new Button();
            imageList2 = new ImageList(components);
            button1 = new Button();
            pPie = new Panel();
            label1 = new Label();
            tbCodigo = new TextBox();
            tbNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbDepartamento = new ComboBox();
            tbPrecio = new TextBox();
            label4 = new Label();
            cbTasaIva = new ComboBox();
            label5 = new Label();
            chbActivo = new CheckBox();
            label6 = new Label();
            cbTama = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            pPie.SuspendLayout();
            SuspendLayout();
            // 
            // toolTip1
            // 
            toolTip1.ForeColor = Color.RosyBrown;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Punto de Venta";
            // 
            // bCancelar
            // 
            bCancelar.DialogResult = DialogResult.OK;
            bCancelar.ImageAlign = ContentAlignment.TopCenter;
            bCancelar.ImageIndex = 1;
            bCancelar.ImageList = imageList1;
            bCancelar.Location = new Point(389, 10);
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
            imageList1.Images.SetKeyName(0, "Aceptar.png");
            imageList1.Images.SetKeyName(1, "Cancelar.png");
            // 
            // bAceptar
            // 
            bAceptar.ImageAlign = ContentAlignment.TopCenter;
            bAceptar.ImageIndex = 0;
            bAceptar.ImageList = imageList1;
            bAceptar.Location = new Point(308, 10);
            bAceptar.Name = "bAceptar";
            bAceptar.Size = new Size(75, 69);
            bAceptar.TabIndex = 0;
            bAceptar.Text = "Aceptar";
            bAceptar.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(bAceptar, "[ Enter ] Acepta el registro actual");
            bAceptar.UseVisualStyleBackColor = true;
            bAceptar.Click += bAceptar_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.ImageIndex = 0;
            button2.ImageList = imageList2;
            button2.Location = new Point(611, 28);
            button2.Name = "button2";
            button2.Size = new Size(57, 56);
            button2.TabIndex = 2;
            button2.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(button2, "[ Enter ] Acepta el registro actual");
            button2.UseVisualStyleBackColor = true;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "a.png");
            imageList2.Images.SetKeyName(1, "a2.png");
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.ImageIndex = 1;
            button1.ImageList = imageList2;
            button1.Location = new Point(611, 92);
            button1.Name = "button1";
            button1.Size = new Size(57, 56);
            button1.TabIndex = 29;
            button1.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(button1, "[ Enter ] Acepta el registro actual");
            button1.UseVisualStyleBackColor = true;
            // 
            // pPie
            // 
            pPie.BackColor = Color.Tan;
            pPie.Controls.Add(bCancelar);
            pPie.Controls.Add(bAceptar);
            pPie.Dock = DockStyle.Bottom;
            pPie.Location = new Point(0, 276);
            pPie.Name = "pPie";
            pPie.Size = new Size(800, 82);
            pPie.TabIndex = 10;
            // 
            // label1
            // 
            label1.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(63, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 11;
            label1.Text = "Codigo: ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbCodigo
            // 
            tbCodigo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tbCodigo.ForeColor = Color.FromArgb(192, 0, 0);
            tbCodigo.Location = new Point(169, 18);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(119, 27);
            tbCodigo.TabIndex = 12;
            // 
            // tbNombre
            // 
            tbNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombre.ForeColor = Color.Blue;
            tbNombre.Location = new Point(169, 63);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(195, 27);
            tbNombre.TabIndex = 14;
            // 
            // label2
            // 
            label2.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGoldenrod;
            label2.Location = new Point(63, 65);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 13;
            label2.Text = "Nombre: ";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGoldenrod;
            label3.Location = new Point(26, 115);
            label3.Name = "label3";
            label3.Size = new Size(137, 23);
            label3.TabIndex = 15;
            label3.Text = "Departamento: ";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbDepartamento
            // 
            cbDepartamento.DisplayMember = "cbDepartamento.DisplayMember = \"Nombre\"; // Columna para mostrar\ncbDepartamento.ValueMember = \"Id\";      // Columna para el valor\ncbDepartamento.DataSource = tablaDepartamentos;";
            cbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamento.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbDepartamento.ForeColor = Color.Blue;
            cbDepartamento.FormattingEnabled = true;
            cbDepartamento.Items.AddRange(new object[] { "cbDepartamento.DisplayMember = \"Nombre\"; ", "cbDepartamento.ValueMember = \"Id\"; ", "cbDepartamento.DataSource = tablaDepartamentos;" });
            cbDepartamento.Location = new Point(169, 115);
            cbDepartamento.Name = "cbDepartamento";
            cbDepartamento.Size = new Size(244, 28);
            cbDepartamento.TabIndex = 16;
            cbDepartamento.ValueMember = "cbDepartamento.DisplayMember = \"Nombre\"; ";
            cbDepartamento.SelectedIndexChanged += cbDepartamento_SelectedIndexChanged;
            // 
            // tbPrecio
            // 
            tbPrecio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tbPrecio.ForeColor = Color.Blue;
            tbPrecio.Location = new Point(169, 166);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(119, 27);
            tbPrecio.TabIndex = 18;
            // 
            // label4
            // 
            label4.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGoldenrod;
            label4.Location = new Point(63, 168);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 17;
            label4.Text = "Precio: ";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbTasaIva
            // 
            cbTasaIva.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTasaIva.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbTasaIva.ForeColor = Color.Blue;
            cbTasaIva.FormattingEnabled = true;
            cbTasaIva.Items.AddRange(new object[] { "0", "16" });
            cbTasaIva.Location = new Point(509, 120);
            cbTasaIva.Name = "cbTasaIva";
            cbTasaIva.Size = new Size(72, 28);
            cbTasaIva.TabIndex = 20;
            cbTasaIva.SelectedIndexChanged += cbTasaIva_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGoldenrod;
            label5.Location = new Point(432, 120);
            label5.Name = "label5";
            label5.Size = new Size(76, 23);
            label5.TabIndex = 19;
            label5.Text = "Tasa Iva : ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chbActivo
            // 
            chbActivo.AutoSize = true;
            chbActivo.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chbActivo.ForeColor = Color.DarkGoldenrod;
            chbActivo.Location = new Point(310, 170);
            chbActivo.Name = "chbActivo";
            chbActivo.Size = new Size(73, 23);
            chbActivo.TabIndex = 25;
            chbActivo.Text = "Activo";
            chbActivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGoldenrod;
            label6.Location = new Point(428, 34);
            label6.Name = "label6";
            label6.Size = new Size(76, 23);
            label6.TabIndex = 26;
            label6.Text = "Tamaño:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbTama
            // 
            cbTama.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTama.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbTama.ForeColor = Color.Blue;
            cbTama.FormattingEnabled = true;
            cbTama.Items.AddRange(new object[] { "Grande", "Pequeño" });
            cbTama.Location = new Point(501, 32);
            cbTama.Name = "cbTama";
            cbTama.Size = new Size(95, 28);
            cbTama.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGoldenrod;
            label7.Location = new Point(679, 9);
            label7.Name = "label7";
            label7.Size = new Size(90, 19);
            label7.TabIndex = 28;
            label7.Text = "--Mililitros--";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGoldenrod;
            label8.Location = new Point(674, 44);
            label8.Name = "label8";
            label8.Size = new Size(98, 23);
            label8.TabIndex = 30;
            label8.Text = "〘390ml〙";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkGoldenrod;
            label9.Location = new Point(674, 110);
            label9.Name = "label9";
            label9.Size = new Size(98, 23);
            label9.TabIndex = 31;
            label9.Text = "〘590ml〙";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 358);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(cbTama);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(chbActivo);
            Controls.Add(cbTasaIva);
            Controls.Add(label5);
            Controls.Add(tbPrecio);
            Controls.Add(label4);
            Controls.Add(cbDepartamento);
            Controls.Add(label3);
            Controls.Add(tbNombre);
            Controls.Add(label2);
            Controls.Add(tbCodigo);
            Controls.Add(label1);
            Controls.Add(pPie);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fArticulo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Articulos";
            Load += fArticulo_Load;
            pPie.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private Button bCancelar;
        private ImageList imageList1;
        private Button bAceptar;
        private Panel pPie;
        private Label label1;
        private TextBox tbCodigo;
        private TextBox tbNombre;
        private Label label2;
        private Label label3;
        private ComboBox cbDepartamento;
        private TextBox tbPrecio;
        private Label label4;
        private ComboBox cbTasaIva;
        private Label label5;
        private CheckBox chbActivo;
        private Label label6;
        private ComboBox cbTama;
        private Button button2;
        private Label label7;
        private ImageList imageList2;
        private Button button1;
        private Label label8;
        private Label label9;
    }
}