namespace PuntoDeVenta
{
    partial class fCorteDeCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCorteDeCaja));
            cbVendedores = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dtpFecha1 = new DateTimePicker();
            lIva = new Label();
            label9 = new Label();
            lSub = new Label();
            label7 = new Label();
            lTot = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            dtpFecha2 = new DateTimePicker();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbVendedores
            // 
            cbVendedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVendedores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbVendedores.ForeColor = Color.Blue;
            cbVendedores.FormattingEnabled = true;
            cbVendedores.Location = new Point(182, 11);
            cbVendedores.Name = "cbVendedores";
            cbVendedores.Size = new Size(203, 29);
            cbVendedores.TabIndex = 32;
            cbVendedores.SelectionChangeCommitted += cbVendedores_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(87, 16);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 31;
            label1.Text = "Vendedor : ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGoldenrod;
            label2.Location = new Point(5, 52);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 33;
            label2.Text = "Del : ";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpFecha1
            // 
            dtpFecha1.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpFecha1.Format = DateTimePickerFormat.Short;
            dtpFecha1.Location = new Point(101, 51);
            dtpFecha1.Name = "dtpFecha1";
            dtpFecha1.Size = new Size(131, 27);
            dtpFecha1.TabIndex = 34;
            // 
            // lIva
            // 
            lIva.BorderStyle = BorderStyle.FixedSingle;
            lIva.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lIva.ForeColor = Color.Blue;
            lIva.Location = new Point(197, 423);
            lIva.Name = "lIva";
            lIva.Size = new Size(157, 25);
            lIva.TabIndex = 41;
            lIva.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkGoldenrod;
            label9.Location = new Point(110, 423);
            label9.Name = "label9";
            label9.Size = new Size(86, 25);
            label9.TabIndex = 40;
            label9.Text = "Iva : ";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lSub
            // 
            lSub.BorderStyle = BorderStyle.FixedSingle;
            lSub.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lSub.ForeColor = Color.Blue;
            lSub.Location = new Point(198, 397);
            lSub.Name = "lSub";
            lSub.Size = new Size(157, 25);
            lSub.TabIndex = 39;
            lSub.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGoldenrod;
            label7.Location = new Point(111, 397);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 38;
            label7.Text = "Sub :";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lTot
            // 
            lTot.BorderStyle = BorderStyle.FixedSingle;
            lTot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lTot.ForeColor = Color.Blue;
            lTot.Location = new Point(197, 448);
            lTot.Name = "lTot";
            lTot.Size = new Size(157, 25);
            lTot.TabIndex = 37;
            lTot.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGoldenrod;
            label4.Location = new Point(110, 448);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 36;
            label4.Text = "Total : ";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 82);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(393, 312);
            dataGridView1.TabIndex = 35;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // dtpFecha2
            // 
            dtpFecha2.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpFecha2.Format = DateTimePickerFormat.Short;
            dtpFecha2.Location = new Point(339, 52);
            dtpFecha2.Name = "dtpFecha2";
            dtpFecha2.Size = new Size(131, 27);
            dtpFecha2.TabIndex = 43;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGoldenrod;
            label3.Location = new Point(242, 54);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 42;
            label3.Text = "Al : ";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(358, 401);
            label5.Name = "label5";
            label5.Size = new Size(33, 23);
            label5.TabIndex = 44;
            label5.Text = "Mx";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(358, 450);
            label6.Name = "label6";
            label6.Size = new Size(33, 23);
            label6.TabIndex = 45;
            label6.Text = "Mx";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fCorteDeCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(482, 482);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpFecha2);
            Controls.Add(label3);
            Controls.Add(lIva);
            Controls.Add(label9);
            Controls.Add(lSub);
            Controls.Add(label7);
            Controls.Add(lTot);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(dtpFecha1);
            Controls.Add(label2);
            Controls.Add(cbVendedores);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "fCorteDeCaja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Corte De Caja";
            Load += fCorteDeCaja_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbVendedores;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpFecha1;
        private Label lIva;
        private Label label9;
        private Label lSub;
        private Label label7;
        private Label lTot;
        private Label label4;
        private DataGridView dataGridView1;
        private DateTimePicker dtpFecha2;
        private Label label3;
        private Label label5;
        private Label label6;
    }
}