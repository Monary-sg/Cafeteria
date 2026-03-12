namespace PuntoDeVenta
{
    partial class fDepartamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDepartamentos));
            label1 = new Label();
            tbId = new TextBox();
            tbNombre = new TextBox();
            label2 = new Label();
            lNuevo = new Label();
            pcabecera = new Panel();
            bImprimir = new Button();
            imageList2 = new ImageList(components);
            bBuscar = new Button();
            pDetalle = new Panel();
            CbMili = new CheckBox();
            pPie = new Panel();
            bEliminar = new Button();
            imageList1 = new ImageList(components);
            bCancelar = new Button();
            bGuardar = new Button();
            toolTip1 = new ToolTip(components);
            pcabecera.SuspendLayout();
            pDetalle.SuspendLayout();
            pPie.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(75, 20);
            label1.Name = "label1";
            label1.Size = new Size(27, 19);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // tbId
            // 
            tbId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbId.Location = new Point(107, 12);
            tbId.Name = "tbId";
            tbId.Size = new Size(100, 29);
            tbId.TabIndex = 1;
            tbId.KeyPress += tbId_KeyPress;
            // 
            // tbNombre
            // 
            tbNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombre.Location = new Point(107, 32);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(343, 29);
            tbNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGoldenrod;
            label2.Location = new Point(26, 40);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 2;
            label2.Text = "Nombre: ";
            // 
            // lNuevo
            // 
            lNuevo.AutoSize = true;
            lNuevo.Font = new Font("Corbel", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lNuevo.ForeColor = Color.SaddleBrown;
            lNuevo.Location = new Point(67, 9);
            lNuevo.Name = "lNuevo";
            lNuevo.Size = new Size(38, 13);
            lNuevo.TabIndex = 4;
            lNuevo.Text = "Nuevo";
            // 
            // pcabecera
            // 
            pcabecera.BackColor = Color.Ivory;
            pcabecera.Controls.Add(bImprimir);
            pcabecera.Controls.Add(bBuscar);
            pcabecera.Controls.Add(tbId);
            pcabecera.Controls.Add(lNuevo);
            pcabecera.Controls.Add(label1);
            pcabecera.Dock = DockStyle.Top;
            pcabecera.Location = new Point(0, 0);
            pcabecera.Name = "pcabecera";
            pcabecera.Size = new Size(469, 51);
            pcabecera.TabIndex = 5;
            // 
            // bImprimir
            // 
            bImprimir.FlatAppearance.BorderSize = 0;
            bImprimir.ImageIndex = 1;
            bImprimir.ImageList = imageList2;
            bImprimir.Location = new Point(235, 11);
            bImprimir.Name = "bImprimir";
            bImprimir.Size = new Size(31, 31);
            bImprimir.TabIndex = 8;
            toolTip1.SetToolTip(bImprimir, "[ Ctrl + I ] Imprime el catalogo de departamentos");
            bImprimir.UseVisualStyleBackColor = true;
            bImprimir.Click += bImprimir_Click;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "Buscar.png");
            imageList2.Images.SetKeyName(1, "Imprimir.png");
            // 
            // bBuscar
            // 
            bBuscar.FlatAppearance.BorderSize = 0;
            bBuscar.ImageIndex = 0;
            bBuscar.ImageList = imageList2;
            bBuscar.Location = new Point(206, 11);
            bBuscar.Name = "bBuscar";
            bBuscar.Size = new Size(31, 31);
            bBuscar.TabIndex = 7;
            toolTip1.SetToolTip(bBuscar, "[ F1 ] Busca un departamento");
            bBuscar.UseVisualStyleBackColor = true;
            bBuscar.Click += bBuscar_Click;
            // 
            // pDetalle
            // 
            pDetalle.BackColor = Color.Ivory;
            pDetalle.Controls.Add(CbMili);
            pDetalle.Controls.Add(tbNombre);
            pDetalle.Controls.Add(label2);
            pDetalle.Dock = DockStyle.Fill;
            pDetalle.Location = new Point(0, 51);
            pDetalle.Name = "pDetalle";
            pDetalle.Size = new Size(469, 167);
            pDetalle.TabIndex = 6;
            // 
            // CbMili
            // 
            CbMili.AutoSize = true;
            CbMili.Location = new Point(107, 7);
            CbMili.Name = "CbMili";
            CbMili.Size = new Size(121, 19);
            CbMili.TabIndex = 4;
            CbMili.Text = "Requiere Mililitros";
            CbMili.UseVisualStyleBackColor = true;
            // 
            // pPie
            // 
            pPie.BackColor = Color.Tan;
            pPie.Controls.Add(bEliminar);
            pPie.Controls.Add(bCancelar);
            pPie.Controls.Add(bGuardar);
            pPie.Dock = DockStyle.Bottom;
            pPie.Location = new Point(0, 136);
            pPie.Name = "pPie";
            pPie.Size = new Size(469, 82);
            pPie.TabIndex = 7;
            // 
            // bEliminar
            // 
            bEliminar.ImageAlign = ContentAlignment.TopCenter;
            bEliminar.ImageIndex = 1;
            bEliminar.ImageList = imageList1;
            bEliminar.Location = new Point(188, 6);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(75, 69);
            bEliminar.TabIndex = 2;
            bEliminar.Text = "Eliminar";
            bEliminar.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(bEliminar, "[Ctrl + Supr] Elimina el registro en la base de datos");
            bEliminar.UseVisualStyleBackColor = true;
            bEliminar.Click += bEliminar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Cancelar.png");
            imageList1.Images.SetKeyName(1, "Eliminar.png");
            imageList1.Images.SetKeyName(2, "Guardar.png");
            // 
            // bCancelar
            // 
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
            // bGuardar
            // 
            bGuardar.ImageAlign = ContentAlignment.TopCenter;
            bGuardar.ImageIndex = 2;
            bGuardar.ImageList = imageList1;
            bGuardar.Location = new Point(26, 7);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(75, 69);
            bGuardar.TabIndex = 0;
            bGuardar.Text = "Guardar";
            bGuardar.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(bGuardar, "[Ctrl + G] Guarda el registro en la base de datos");
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += bGuardar_Click;
            bGuardar.KeyDown += bGuardar_KeyDown;
            // 
            // toolTip1
            // 
            toolTip1.ForeColor = Color.Red;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Punto de Venta";
            // 
            // fDepartamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(469, 218);
            Controls.Add(pPie);
            Controls.Add(pDetalle);
            Controls.Add(pcabecera);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fDepartamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catalogo de Departamentos";
            Load += fDepartamentos_Load;
            KeyDown += fDepartamentos_KeyDown;
            pcabecera.ResumeLayout(false);
            pcabecera.PerformLayout();
            pDetalle.ResumeLayout(false);
            pDetalle.PerformLayout();
            pPie.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox tbId;
        private TextBox tbNombre;
        private Label label2;
        private Label lNuevo;
        private Panel pcabecera;
        private Panel pDetalle;
        private Panel pPie;
        private Button bGuardar;
        private ImageList imageList1;
        private Button bEliminar;
        private Button bCancelar;
        private ToolTip toolTip1;
        private Button bImprimir;
        private ImageList imageList2;
        private Button bBuscar;
        private CheckBox CbMili;
    }
}