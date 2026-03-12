namespace PuntoDeVenta
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            menuStrip1 = new MenuStrip();
            archivosToolStripMenuItem = new ToolStripMenuItem();
            departamentosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            articulosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            datosDeLaEmpresaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            movimientosToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            verificadorDeVentasToolStripMenuItem = new ToolStripMenuItem();
            informesToolStripMenuItem = new ToolStripMenuItem();
            corteDeCajaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            toolStripMenuItem6 = new ToolStripSeparator();
            toolStripMenuItem7 = new ToolStripSeparator();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            aCercaDeToolStripMenuItem = new ToolStripMenuItem();
            ayudaEnLineaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripSeparator();
            documentacionToolStripMenuItem = new ToolStripMenuItem();
            ventanasToolStripMenuItem = new ToolStripMenuItem();
            cascadaToolStripMenuItem = new ToolStripMenuItem();
            mosaicoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            lFecha = new Label();
            lhora = new Label();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LemonChiffon;
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivosToolStripMenuItem, movimientosToolStripMenuItem, informesToolStripMenuItem, ayudaToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1324, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            archivosToolStripMenuItem.BackColor = Color.Tan;
            archivosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { departamentosToolStripMenuItem, toolStripMenuItem1, articulosToolStripMenuItem, toolStripMenuItem2, datosDeLaEmpresaToolStripMenuItem, toolStripMenuItem3 });
            archivosToolStripMenuItem.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            archivosToolStripMenuItem.ForeColor = Color.DarkGoldenrod;
            archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            archivosToolStripMenuItem.Size = new Size(82, 23);
            archivosToolStripMenuItem.Text = "Archivos";
            archivosToolStripMenuItem.ToolTipText = "Departamentos, articulos,Datos Generales";
            // 
            // departamentosToolStripMenuItem
            // 
            departamentosToolStripMenuItem.BackColor = Color.AntiqueWhite;
            departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            departamentosToolStripMenuItem.Size = new Size(218, 24);
            departamentosToolStripMenuItem.Text = "Departamentos";
            departamentosToolStripMenuItem.Click += departamentosToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(215, 6);
            // 
            // articulosToolStripMenuItem
            // 
            articulosToolStripMenuItem.BackColor = Color.Tan;
            articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            articulosToolStripMenuItem.Size = new Size(218, 24);
            articulosToolStripMenuItem.Text = "Articulos";
            articulosToolStripMenuItem.Click += articulosToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(215, 6);
            // 
            // datosDeLaEmpresaToolStripMenuItem
            // 
            datosDeLaEmpresaToolStripMenuItem.BackColor = Color.AntiqueWhite;
            datosDeLaEmpresaToolStripMenuItem.Name = "datosDeLaEmpresaToolStripMenuItem";
            datosDeLaEmpresaToolStripMenuItem.Size = new Size(218, 24);
            datosDeLaEmpresaToolStripMenuItem.Text = "Datos de la Empresa";
            datosDeLaEmpresaToolStripMenuItem.Click += datosDeLaEmpresaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(215, 6);
            // 
            // movimientosToolStripMenuItem
            // 
            movimientosToolStripMenuItem.BackColor = Color.Moccasin;
            movimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ventasToolStripMenuItem, toolStripMenuItem4, verificadorDeVentasToolStripMenuItem });
            movimientosToolStripMenuItem.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            movimientosToolStripMenuItem.ForeColor = Color.DarkGoldenrod;
            movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            movimientosToolStripMenuItem.Size = new Size(112, 23);
            movimientosToolStripMenuItem.Text = "Movimientos";
            movimientosToolStripMenuItem.ToolTipText = "Ventas y Vendedores";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.BackColor = Color.Tan;
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(160, 24);
            ventasToolStripMenuItem.Text = "Ventas";
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(157, 6);
            // 
            // verificadorDeVentasToolStripMenuItem
            // 
            verificadorDeVentasToolStripMenuItem.BackColor = Color.AntiqueWhite;
            verificadorDeVentasToolStripMenuItem.Name = "verificadorDeVentasToolStripMenuItem";
            verificadorDeVentasToolStripMenuItem.Size = new Size(160, 24);
            verificadorDeVentasToolStripMenuItem.Text = "Vendedores";
            verificadorDeVentasToolStripMenuItem.Click += verificadorDeVentasToolStripMenuItem_Click;
            // 
            // informesToolStripMenuItem
            // 
            informesToolStripMenuItem.BackColor = Color.Tan;
            informesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { corteDeCajaToolStripMenuItem, toolStripMenuItem5, toolStripMenuItem6, toolStripMenuItem7 });
            informesToolStripMenuItem.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            informesToolStripMenuItem.ForeColor = Color.DarkGoldenrod;
            informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            informesToolStripMenuItem.Size = new Size(83, 23);
            informesToolStripMenuItem.Text = "Informes";
            informesToolStripMenuItem.ToolTipText = "Corte de Caja";
            // 
            // corteDeCajaToolStripMenuItem
            // 
            corteDeCajaToolStripMenuItem.BackColor = Color.AntiqueWhite;
            corteDeCajaToolStripMenuItem.Name = "corteDeCajaToolStripMenuItem";
            corteDeCajaToolStripMenuItem.Size = new Size(167, 24);
            corteDeCajaToolStripMenuItem.Text = "Corte de Caja";
            corteDeCajaToolStripMenuItem.Click += corteDeCajaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(164, 6);
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(164, 6);
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(164, 6);
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.BackColor = Color.Moccasin;
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aCercaDeToolStripMenuItem, ayudaEnLineaToolStripMenuItem, toolStripMenuItem10, documentacionToolStripMenuItem, ventanasToolStripMenuItem });
            ayudaToolStripMenuItem.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ayudaToolStripMenuItem.ForeColor = Color.DarkGoldenrod;
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 23);
            ayudaToolStripMenuItem.Text = "Ayuda";
            ayudaToolStripMenuItem.ToolTipText = "Ventanas y Ayuda";
            // 
            // aCercaDeToolStripMenuItem
            // 
            aCercaDeToolStripMenuItem.BackColor = Color.Tan;
            aCercaDeToolStripMenuItem.Name = "aCercaDeToolStripMenuItem";
            aCercaDeToolStripMenuItem.Size = new Size(188, 24);
            aCercaDeToolStripMenuItem.Text = "A cerca de...";
            // 
            // ayudaEnLineaToolStripMenuItem
            // 
            ayudaEnLineaToolStripMenuItem.BackColor = Color.AntiqueWhite;
            ayudaEnLineaToolStripMenuItem.Name = "ayudaEnLineaToolStripMenuItem";
            ayudaEnLineaToolStripMenuItem.Size = new Size(188, 24);
            ayudaEnLineaToolStripMenuItem.Text = "Ayuda en Linea";
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(185, 6);
            // 
            // documentacionToolStripMenuItem
            // 
            documentacionToolStripMenuItem.BackColor = Color.Tan;
            documentacionToolStripMenuItem.Name = "documentacionToolStripMenuItem";
            documentacionToolStripMenuItem.Size = new Size(188, 24);
            documentacionToolStripMenuItem.Text = "Documentacion";
            // 
            // ventanasToolStripMenuItem
            // 
            ventanasToolStripMenuItem.BackColor = Color.AntiqueWhite;
            ventanasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadaToolStripMenuItem, mosaicoToolStripMenuItem });
            ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            ventanasToolStripMenuItem.Size = new Size(188, 24);
            ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // cascadaToolStripMenuItem
            // 
            cascadaToolStripMenuItem.BackColor = Color.Linen;
            cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            cascadaToolStripMenuItem.Size = new Size(180, 24);
            cascadaToolStripMenuItem.Text = "Cascada";
            cascadaToolStripMenuItem.Click += cascadaToolStripMenuItem_Click;
            // 
            // mosaicoToolStripMenuItem
            // 
            mosaicoToolStripMenuItem.BackColor = Color.Linen;
            mosaicoToolStripMenuItem.Name = "mosaicoToolStripMenuItem";
            mosaicoToolStripMenuItem.Size = new Size(180, 24);
            mosaicoToolStripMenuItem.Text = "Mosaico";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.BackColor = Color.Tan;
            salirToolStripMenuItem.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 23);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.ToolTipText = "Salida del programa";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // lFecha
            // 
            lFecha.AccessibleRole = AccessibleRole.Window;
            lFecha.AllowDrop = true;
            lFecha.AutoSize = true;
            lFecha.BackColor = Color.LemonChiffon;
            lFecha.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lFecha.ForeColor = Color.Black;
            lFecha.Location = new Point(1002, 0);
            lFecha.Name = "lFecha";
            lFecha.RightToLeft = RightToLeft.No;
            lFecha.Size = new Size(0, 26);
            lFecha.TabIndex = 20;
            lFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lhora
            // 
            lhora.AccessibleRole = AccessibleRole.Window;
            lhora.AllowDrop = true;
            lhora.AutoSize = true;
            lhora.BackColor = Color.LemonChiffon;
            lhora.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lhora.ForeColor = Color.Black;
            lhora.Location = new Point(1187, 2);
            lhora.Name = "lhora";
            lhora.RightToLeft = RightToLeft.No;
            lhora.Size = new Size(0, 26);
            lhora.TabIndex = 22;
            lhora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            toolTip1.ForeColor = Color.RosyBrown;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Punto de Venta";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1324, 570);
            Controls.Add(lhora);
            Controls.Add(lFecha);
            Controls.Add(menuStrip1);
            Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.DarkGoldenrod;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Menu";
            Text = "Menu Cafeteria";
            WindowState = FormWindowState.Maximized;
            FormClosing += Menu_FormClosing;
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivosToolStripMenuItem;
        private ToolStripMenuItem departamentosToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem articulosToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem datosDeLaEmpresaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem movimientosToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem verificadorDeVentasToolStripMenuItem;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ToolStripMenuItem corteDeCajaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripSeparator toolStripMenuItem7;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem aCercaDeToolStripMenuItem;
        private ToolStripMenuItem ayudaEnLineaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem10;
        private ToolStripMenuItem documentacionToolStripMenuItem;
        private ToolStripMenuItem ventanasToolStripMenuItem;
        private ToolStripMenuItem cascadaToolStripMenuItem;
        private ToolStripMenuItem mosaicoToolStripMenuItem;
        private Label lFecha;
        private Label lhora;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolTip toolTip1;
    }
}