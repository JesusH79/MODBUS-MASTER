namespace MODBUS_MASTER.Forms
{
    partial class frmFC16WriteMultipleRegisters
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
            label1 = new Label();
            lblIPSlave = new Label();
            label2 = new Label();
            label3 = new Label();
            txbDireccionInicial = new TextBox();
            txbNumeroRegistros = new TextBox();
            lblConexion = new Label();
            dgvRegisters = new DataGridView();
            Direccion = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            btnFC16WriteRegisters = new Button();
            btnAplicar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRegisters).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 0;
            label1.Text = "IP SLAVE:";
            // 
            // lblIPSlave
            // 
            lblIPSlave.AutoSize = true;
            lblIPSlave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIPSlave.Location = new Point(116, 32);
            lblIPSlave.Margin = new Padding(4, 0, 4, 0);
            lblIPSlave.Name = "lblIPSlave";
            lblIPSlave.Size = new Size(28, 28);
            lblIPSlave.TabIndex = 1;
            lblIPSlave.Text = "IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 28);
            label2.TabIndex = 2;
            label2.Text = "DIRECCION INICIAL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 147);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(155, 28);
            label3.TabIndex = 3;
            label3.Text = "NO. REGISTROS:";
            // 
            // txbDireccionInicial
            // 
            txbDireccionInicial.Location = new Point(208, 99);
            txbDireccionInicial.Margin = new Padding(4);
            txbDireccionInicial.Name = "txbDireccionInicial";
            txbDireccionInicial.Size = new Size(80, 34);
            txbDireccionInicial.TabIndex = 4;
            // 
            // txbNumeroRegistros
            // 
            txbNumeroRegistros.Location = new Point(208, 147);
            txbNumeroRegistros.Margin = new Padding(4);
            txbNumeroRegistros.Name = "txbNumeroRegistros";
            txbNumeroRegistros.Size = new Size(80, 34);
            txbNumeroRegistros.TabIndex = 5;
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConexion.Location = new Point(313, 81);
            lblConexion.Margin = new Padding(4, 0, 4, 0);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(66, 46);
            lblConexion.TabIndex = 6;
            lblConexion.Text = "NC";
            lblConexion.Click += lblConexion_Click;
            // 
            // dgvRegisters
            // 
            dgvRegisters.AllowUserToAddRows = false;
            dgvRegisters.AllowUserToDeleteRows = false;
            dgvRegisters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegisters.Columns.AddRange(new DataGridViewColumn[] { Direccion, Valor });
            dgvRegisters.Location = new Point(13, 266);
            dgvRegisters.Margin = new Padding(4);
            dgvRegisters.Name = "dgvRegisters";
            dgvRegisters.RowHeadersWidth = 51;
            dgvRegisters.Size = new Size(426, 263);
            dgvRegisters.TabIndex = 7;
            dgvRegisters.EditingControlShowing += dgvRegisters_EditingControlShowing;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.Width = 125;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.MinimumWidth = 6;
            Valor.Name = "Valor";
            Valor.Width = 125;
            // 
            // btnFC16WriteRegisters
            // 
            btnFC16WriteRegisters.Location = new Point(16, 201);
            btnFC16WriteRegisters.Margin = new Padding(4);
            btnFC16WriteRegisters.Name = "btnFC16WriteRegisters";
            btnFC16WriteRegisters.Size = new Size(129, 57);
            btnFC16WriteRegisters.TabIndex = 8;
            btnFC16WriteRegisters.Text = "WRITE";
            btnFC16WriteRegisters.UseVisualStyleBackColor = true;
            btnFC16WriteRegisters.Click += btnFC16WriteRegisters_Click;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(310, 131);
            btnAplicar.Margin = new Padding(4);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(129, 57);
            btnAplicar.TabIndex = 9;
            btnAplicar.Text = "APLICAR";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // frmFC16WriteMultipleRegisters
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(454, 679);
            Controls.Add(btnAplicar);
            Controls.Add(btnFC16WriteRegisters);
            Controls.Add(dgvRegisters);
            Controls.Add(lblConexion);
            Controls.Add(txbNumeroRegistros);
            Controls.Add(txbDireccionInicial);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblIPSlave);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmFC16WriteMultipleRegisters";
            Text = "frmFC16WriteMultipleRegisters";
            Load += frmFC16WriteMultipleRegisters_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegisters).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblIPSlave;
        private Label label2;
        private Label label3;
        private TextBox txbDireccionInicial;
        private TextBox txbNumeroRegistros;
        private Label lblConexion;
        private DataGridView dgvRegisters;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Valor;
        private Button btnFC16WriteRegisters;
        private Button btnAplicar;
    }
}