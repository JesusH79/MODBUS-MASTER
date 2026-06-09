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
            btnFCO4ReadInputRegister = new Button();
            txbDireccion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblValorRegistro = new Label();
            lblConexion = new Label();
            lblIPSlave = new Label();
            label4 = new Label();
            rtxValoresRegistros = new RichTextBox();
            label3 = new Label();
            txbNumeroRegistros = new TextBox();
            SuspendLayout();
            // 
            // btnFCO4ReadInputRegister
            // 
            btnFCO4ReadInputRegister.Location = new Point(164, 178);
            btnFCO4ReadInputRegister.Margin = new Padding(4);
            btnFCO4ReadInputRegister.Name = "btnFCO4ReadInputRegister";
            btnFCO4ReadInputRegister.Size = new Size(143, 46);
            btnFCO4ReadInputRegister.TabIndex = 0;
            btnFCO4ReadInputRegister.Text = "READ IR";
            btnFCO4ReadInputRegister.UseVisualStyleBackColor = true;
            btnFCO4ReadInputRegister.Click += btnFCO4ReadInputRegister_Click;
            // 
            // txbDireccion
            // 
            txbDireccion.Location = new Point(164, 61);
            txbDireccion.Margin = new Padding(4);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(143, 34);
            txbDireccion.TabIndex = 1;
            txbDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 61);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 2;
            label1.Text = "DIRECCION:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 242);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 3;
            label2.Text = "VALORES:";
            // 
            // lblValorRegistro
            // 
            lblValorRegistro.AutoSize = true;
            lblValorRegistro.Location = new Point(164, 242);
            lblValorRegistro.Name = "lblValorRegistro";
            lblValorRegistro.Size = new Size(60, 28);
            lblValorRegistro.TabIndex = 4;
            lblValorRegistro.Text = "XXXX";
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConexion.Location = new Point(34, 178);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(66, 46);
            lblConexion.TabIndex = 5;
            lblConexion.Text = "NC";
            lblConexion.Click += lblConexion_Click;
            // 
            // lblIPSlave
            // 
            lblIPSlave.AutoSize = true;
            lblIPSlave.Location = new Point(119, 10);
            lblIPSlave.Name = "lblIPSlave";
            lblIPSlave.Size = new Size(65, 28);
            lblIPSlave.TabIndex = 6;
            lblIPSlave.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 10);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
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
            label3.Size = new Size(152, 28);
            label3.TabIndex = 9;
            label3.Text = "No. REGISTROS:";
            // 
            // txbNumeroRegistros
            // 
            txbNumeroRegistros.Location = new Point(167, 118);
            txbNumeroRegistros.Margin = new Padding(4);
            txbNumeroRegistros.Name = "txbNumeroRegistros";
            txbNumeroRegistros.Size = new Size(143, 34);
            txbNumeroRegistros.TabIndex = 10;
            txbNumeroRegistros.TextAlign = HorizontalAlignment.Center;
            // 
            // frmFC04ReadInputRegister
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 471);
            Controls.Add(txbNumeroRegistros);
            Controls.Add(label3);
            Controls.Add(rtxValoresRegistros);
            Controls.Add(label4);
            Controls.Add(lblIPSlave);
            Controls.Add(lblConexion);
            Controls.Add(lblValorRegistro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbDireccion);
            Controls.Add(btnFCO4ReadInputRegister);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmFC04ReadInputRegister";
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
        private Label lblValorRegistro;
        private Label lblConexion;
        private Label lblIPSlave;
        private Label label4;
        private RichTextBox rtxValoresRegistros;
        private Label label3;
        private TextBox txbNumeroRegistros;
    }
}