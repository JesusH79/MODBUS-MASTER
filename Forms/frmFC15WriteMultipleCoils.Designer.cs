namespace MODBUS_MASTER.Forms
{
    partial class frmFC15WriteMultipleCoils
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblIPSlave = new Label();
            label2 = new Label();
            txbDireccionInicial = new TextBox();
            lblConexion = new Label();
            label3 = new Label();
            txbNumeroCoils = new TextBox();
            btnAplicar = new Button();
            dgvValoresColis = new DataGridView();
            btnFC15 = new Button();
            Direccion = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvValoresColis).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 0;
            label1.Text = "IP SLAVE:";
            // 
            // lblIPSlave
            // 
            lblIPSlave.AutoSize = true;
            lblIPSlave.Location = new Point(123, 23);
            lblIPSlave.Margin = new Padding(4, 0, 4, 0);
            lblIPSlave.Name = "lblIPSlave";
            lblIPSlave.Size = new Size(33, 28);
            lblIPSlave.TabIndex = 1;
            lblIPSlave.Text = "IP ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 56);
            label2.TabIndex = 2;
            label2.Text = "DIRECCION\r\nINICIAL";
            // 
            // txbDireccionInicial
            // 
            txbDireccionInicial.Location = new Point(155, 86);
            txbDireccionInicial.Name = "txbDireccionInicial";
            txbDireccionInicial.Size = new Size(78, 34);
            txbDireccionInicial.TabIndex = 3;
            txbDireccionInicial.TextAlign = HorizontalAlignment.Center;
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConexion.Location = new Point(313, 86);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(66, 46);
            lblConexion.TabIndex = 4;
            lblConexion.Text = "NC";
            lblConexion.Click += lblConexion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 161);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 56);
            label3.TabIndex = 5;
            label3.Text = "NUMERO DE\r\nCOILS";
            // 
            // txbNumeroCoils
            // 
            txbNumeroCoils.Location = new Point(155, 171);
            txbNumeroCoils.Name = "txbNumeroCoils";
            txbNumeroCoils.Size = new Size(78, 34);
            txbNumeroCoils.TabIndex = 6;
            txbNumeroCoils.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(297, 165);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(112, 47);
            btnAplicar.TabIndex = 7;
            btnAplicar.Text = "APLICAR";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // dgvValoresColis
            // 
            dgvValoresColis.AllowUserToAddRows = false;
            dgvValoresColis.AllowUserToDeleteRows = false;
            dgvValoresColis.AllowUserToResizeColumns = false;
            dgvValoresColis.AllowUserToResizeRows = false;
            dgvValoresColis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvValoresColis.Columns.AddRange(new DataGridViewColumn[] { Direccion, Valor });
            dgvValoresColis.Location = new Point(12, 259);
            dgvValoresColis.Name = "dgvValoresColis";
            dgvValoresColis.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvValoresColis.RowHeadersWidth = 51;
            dgvValoresColis.Size = new Size(338, 188);
            dgvValoresColis.TabIndex = 8;
            dgvValoresColis.EditingControlShowing += dgvValoresColis_EditingControlShowing;
            // 
            // btnFC15
            // 
            btnFC15.Location = new Point(356, 259);
            btnFC15.Name = "btnFC15";
            btnFC15.Size = new Size(112, 47);
            btnFC15.TabIndex = 9;
            btnFC15.Text = "WRITE";
            btnFC15.UseVisualStyleBackColor = true;
            btnFC15.Click += btnFC15_Click;
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
            // frmFC15WriteMultipleCoils
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(480, 711);
            Controls.Add(btnFC15);
            Controls.Add(dgvValoresColis);
            Controls.Add(btnAplicar);
            Controls.Add(txbNumeroCoils);
            Controls.Add(label3);
            Controls.Add(lblConexion);
            Controls.Add(txbDireccionInicial);
            Controls.Add(label2);
            Controls.Add(lblIPSlave);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmFC15WriteMultipleCoils";
            Text = "frmFC15WriteMultipleCoils";
            FormClosing += frmFC15WriteMultipleCoils_FormClosing;
            Load += frmFC15WriteMultipleCoils_Load;
            ((System.ComponentModel.ISupportInitialize)dgvValoresColis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblIPSlave;
        private Label label2;
        private TextBox txbDireccionInicial;
        private Label lblConexion;
        private Label label3;
        private TextBox txbNumeroCoils;
        private Button btnAplicar;
        private DataGridView dgvValoresColis;
        private Button btnFC15;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Valor;
    }
}