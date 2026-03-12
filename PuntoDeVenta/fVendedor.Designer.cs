namespace PuntoDeVenta
{
    partial class fVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fVendedor));
            Lid = new Label();
            Lnom = new Label();
            pPie = new Panel();
            bEliminar = new Button();
            imageList1 = new ImageList(components);
            bCancelar = new Button();
            bGuardar = new Button();
            tbId = new TextBox();
            tbNom = new TextBox();
            imageList2 = new ImageList(components);
            bBuscar = new Button();
            lNuevo = new Label();
            Pini = new Panel();
            Pde = new Panel();
            pPie.SuspendLayout();
            Pini.SuspendLayout();
            Pde.SuspendLayout();
            SuspendLayout();
            // 
            // Lid
            // 
            Lid.AutoSize = true;
            Lid.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lid.ForeColor = Color.AntiqueWhite;
            Lid.Location = new Point(26, 24);
            Lid.Name = "Lid";
            Lid.Size = new Size(29, 19);
            Lid.TabIndex = 0;
            Lid.Text = "ID:";
            // 
            // Lnom
            // 
            Lnom.AutoSize = true;
            Lnom.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lnom.ForeColor = Color.AntiqueWhite;
            Lnom.Location = new Point(7, 10);
            Lnom.Name = "Lnom";
            Lnom.Size = new Size(72, 19);
            Lnom.TabIndex = 1;
            Lnom.Text = "Nombre:";
            Lnom.Click += Lnom_Click;
            // 
            // pPie
            // 
            pPie.BackColor = Color.Tan;
            pPie.Controls.Add(bEliminar);
            pPie.Controls.Add(bCancelar);
            pPie.Controls.Add(bGuardar);
            pPie.Dock = DockStyle.Bottom;
            pPie.Location = new Point(0, 197);
            pPie.Name = "pPie";
            pPie.Size = new Size(662, 82);
            pPie.TabIndex = 8;
            // 
            // bEliminar
            // 
            bEliminar.ImageAlign = ContentAlignment.TopCenter;
            bEliminar.ImageKey = "Eliminar.png";
            bEliminar.ImageList = imageList1;
            bEliminar.Location = new Point(188, 6);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(75, 69);
            bEliminar.TabIndex = 2;
            bEliminar.Text = "Eliminar";
            bEliminar.TextAlign = ContentAlignment.BottomCenter;
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
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += bGuardar_Click;
            // 
            // tbId
            // 
            tbId.Location = new Point(65, 24);
            tbId.Name = "tbId";
            tbId.Size = new Size(169, 23);
            tbId.TabIndex = 9;
            tbId.KeyPress += tbId_KeyPress;
            // 
            // tbNom
            // 
            tbNom.Location = new Point(7, 32);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(276, 23);
            tbNom.TabIndex = 10;
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
            bBuscar.Location = new Point(240, 24);
            bBuscar.Name = "bBuscar";
            bBuscar.Size = new Size(28, 28);
            bBuscar.TabIndex = 8;
            bBuscar.UseVisualStyleBackColor = true;
            bBuscar.Click += bBuscar_Click;
            // 
            // lNuevo
            // 
            lNuevo.AutoSize = true;
            lNuevo.Font = new Font("Corbel", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lNuevo.ForeColor = Color.SaddleBrown;
            lNuevo.Location = new Point(171, 50);
            lNuevo.Name = "lNuevo";
            lNuevo.Size = new Size(63, 14);
            lNuevo.TabIndex = 11;
            lNuevo.Text = "Disponible";
            // 
            // Pini
            // 
            Pini.Controls.Add(tbId);
            Pini.Controls.Add(lNuevo);
            Pini.Controls.Add(Lid);
            Pini.Controls.Add(bBuscar);
            Pini.Location = new Point(0, -2);
            Pini.Name = "Pini";
            Pini.Size = new Size(295, 118);
            Pini.TabIndex = 12;
            // 
            // Pde
            // 
            Pde.Controls.Add(tbNom);
            Pde.Controls.Add(Lnom);
            Pde.Location = new Point(294, 77);
            Pde.Name = "Pde";
            Pde.Size = new Size(366, 122);
            Pde.TabIndex = 13;
            // 
            // fVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 182, 133);
            ClientSize = new Size(662, 279);
            Controls.Add(Pde);
            Controls.Add(Pini);
            Controls.Add(pPie);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Vendedores ";
            Load += fVendedor_Load;
            KeyDown += fVendedor_KeyDown;
            pPie.ResumeLayout(false);
            Pini.ResumeLayout(false);
            Pini.PerformLayout();
            Pde.ResumeLayout(false);
            Pde.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Lid;
        private Label Lnom;
        private Panel pPie;
        private Button bEliminar;
        private Button bCancelar;
        private Button bGuardar;
        private TextBox tbId;
        private TextBox tbNom;
        private ImageList imageList1;
        private ImageList imageList2;
        private Button bBuscar;
        private Label lNuevo;
        private Panel Pini;
        private Panel Pde;
    }
}