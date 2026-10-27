namespace MODBUS_MASTER.Forms
{
    partial class frmFC04ReadInputRegister
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
            btnFCO4ReadInputRegister = new Button();
            txbDireccion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblNumeroCiclo = new Label();
            lblConexion = new Label();
            lblIPSlave = new Label();
            label4 = new Label();
            rtxValoresRegistros = new RichTextBox();
            label3 = new Label();
            txbNumeroRegistros = new TextBox();
            tmrReadInputRegisters = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnFCO4ReadInputRegister
            // 
            btnFCO4ReadInputRegister.ForeColor = SystemColors.ActiveCaptionText;
            btnFCO4ReadInputRegister.Location = new Point(135, 178);
            btnFCO4ReadInputRegister.Margin = new Padding(4);
            btnFCO4ReadInputRegister.Name = "btnFCO4ReadInputRegister";
            btnFCO4ReadInputRegister.Size = new Size(195, 46);
            btnFCO4ReadInputRegister.TabIndex = 0;
            btnFCO4ReadInputRegister.Text = "START READING";
            btnFCO4ReadInputRegister.UseVisualStyleBackColor = true;
            btnFCO4ReadInputRegister.Click += btnFCO4ReadInputRegister_Click;
            // 
            // txbDireccion
            // 
            txbDireccion.Location = new Point(187, 61);
            txbDireccion.Margin = new Padding(4);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(143, 39);
            txbDireccion.TabIndex = 1;
            txbDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 61);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 2;
            label1.Text = "DIRECCION:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 242);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 3;
            label2.Text = "LECTURAS:";
            // 
            // lblNumeroCiclo
            // 
            lblNumeroCiclo.AutoSize = true;
            lblNumeroCiclo.Location = new Point(164, 242);
            lblNumeroCiclo.Name = "lblNumeroCiclo";
            lblNumeroCiclo.Size = new Size(70, 32);
            lblNumeroCiclo.TabIndex = 4;
            lblNumeroCiclo.Text = "XXXX";
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConexion.Location = new Point(34, 178);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(78, 54);
            lblConexion.TabIndex = 5;
            lblConexion.Text = "NC";
            lblConexion.Click += lblConexion_Click;
            // 
            // lblIPSlave
            // 
            lblIPSlave.AutoSize = true;
            lblIPSlave.Location = new Point(119, 10);
            lblIPSlave.Name = "lblIPSlave";
            lblIPSlave.Size = new Size(78, 32);
            lblIPSlave.TabIndex = 6;
            lblIPSlave.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 10);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 7;
            label4.Text = "IP SLAVE:";
            // 
            // rtxValoresRegistros
            // 
            rtxValoresRegistros.Location = new Point(27, 288);
            rtxValoresRegistros.Name = "rtxValoresRegistros";
            rtxValoresRegistros.ReadOnly = true;
            rtxValoresRegistros.Size = new Size(292, 139);
            rtxValoresRegistros.TabIndex = 8;
            rtxValoresRegistros.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 124);
            label3.Name = "label3";
            label3.Size = new Size(182, 32);
            label3.TabIndex = 9;
            label3.Text = "No. REGISTROS:";
            // 
            // txbNumeroRegistros
            // 
            txbNumeroRegistros.Location = new Point(187, 117);
            txbNumeroRegistros.Margin = new Padding(4);
            txbNumeroRegistros.Name = "txbNumeroRegistros";
            txbNumeroRegistros.Size = new Size(143, 39);
            txbNumeroRegistros.TabIndex = 10;
            txbNumeroRegistros.TextAlign = HorizontalAlignment.Center;
            // 
            // tmrReadInputRegisters
            // 
            tmrReadInputRegisters.Interval = 300;
            tmrReadInputRegisters.Tick += tmrReadInputRegisters_Tick;
            // 
            // frmFC04ReadInputRegister
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 672);
            Controls.Add(txbNumeroRegistros);
            Controls.Add(label3);
            Controls.Add(rtxValoresRegistros);
            Controls.Add(label4);
            Controls.Add(lblIPSlave);
            Controls.Add(lblConexion);
            Controls.Add(lblNumeroCiclo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbDireccion);
            Controls.Add(btnFCO4ReadInputRegister);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmFC04ReadInputRegister";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FC04";
            FormClosing += frmFC04ReadInputRegister_FormClosing;
            Load += frmFC04ReadInputRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFCO4ReadInputRegister;
        private TextBox txbDireccion;
        private Label label1;
        private Label label2;
        private Label lblNumeroCiclo;
        private Label lblConexion;
        private Label lblIPSlave;
        private Label label4;
        private RichTextBox rtxValoresRegistros;
        private Label label3;
        private TextBox txbNumeroRegistros;
        private System.Windows.Forms.Timer tmrReadInputRegisters;
    }
}