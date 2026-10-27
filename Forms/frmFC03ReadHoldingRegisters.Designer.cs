namespace MODBUS_MASTER.Forms
{
    partial class frmFC03ReadHoldingRegisters
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
            txbNumeroRegistros = new TextBox();
            label3 = new Label();
            rtxValoresRegistros = new RichTextBox();
            label4 = new Label();
            lblIPSlave = new Label();
            lblConexion = new Label();
            lblNumeroCiclo = new Label();
            label2 = new Label();
            label1 = new Label();
            txbDireccion = new TextBox();
            btnFC03ReadHoldingRegisters = new Button();
            tmrReadHoldingRegisters = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // txbNumeroRegistros
            // 
            txbNumeroRegistros.Location = new Point(198, 130);
            txbNumeroRegistros.Margin = new Padding(5);
            txbNumeroRegistros.Name = "txbNumeroRegistros";
            txbNumeroRegistros.Size = new Size(185, 39);
            txbNumeroRegistros.TabIndex = 21;
            txbNumeroRegistros.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 133);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(182, 32);
            label3.TabIndex = 20;
            label3.Text = "No. REGISTROS:";
            // 
            // rtxValoresRegistros
            // 
            rtxValoresRegistros.Location = new Point(16, 365);
            rtxValoresRegistros.Margin = new Padding(4);
            rtxValoresRegistros.Name = "rtxValoresRegistros";
            rtxValoresRegistros.ReadOnly = true;
            rtxValoresRegistros.Size = new Size(378, 262);
            rtxValoresRegistros.TabIndex = 19;
            rtxValoresRegistros.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 12);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 18;
            label4.Text = "IP SLAVE:";
            // 
            // lblIPSlave
            // 
            lblIPSlave.AutoSize = true;
            lblIPSlave.Location = new Point(134, 12);
            lblIPSlave.Margin = new Padding(4, 0, 4, 0);
            lblIPSlave.Name = "lblIPSlave";
            lblIPSlave.Size = new Size(78, 32);
            lblIPSlave.TabIndex = 17;
            lblIPSlave.Text = "label4";
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConexion.Location = new Point(48, 200);
            lblConexion.Margin = new Padding(4, 0, 4, 0);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(78, 54);
            lblConexion.TabIndex = 16;
            lblConexion.Text = "NC";
            // 
            // lblNumeroCiclo
            // 
            lblNumeroCiclo.AutoSize = true;
            lblNumeroCiclo.Location = new Point(198, 295);
            lblNumeroCiclo.Margin = new Padding(4, 0, 4, 0);
            lblNumeroCiclo.Name = "lblNumeroCiclo";
            lblNumeroCiclo.Size = new Size(70, 32);
            lblNumeroCiclo.TabIndex = 15;
            lblNumeroCiclo.Text = "XXXX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 295);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 14;
            label2.Text = "LECTURAS:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 13;
            label1.Text = "DIRECCION:";
            // 
            // txbDireccion
            // 
            txbDireccion.Location = new Point(198, 65);
            txbDireccion.Margin = new Padding(5);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(185, 39);
            txbDireccion.TabIndex = 12;
            txbDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // btnFC03ReadHoldingRegisters
            // 
            btnFC03ReadHoldingRegisters.ForeColor = SystemColors.ActiveCaptionText;
            btnFC03ReadHoldingRegisters.Location = new Point(168, 200);
            btnFC03ReadHoldingRegisters.Margin = new Padding(5);
            btnFC03ReadHoldingRegisters.Name = "btnFC03ReadHoldingRegisters";
            btnFC03ReadHoldingRegisters.Size = new Size(253, 59);
            btnFC03ReadHoldingRegisters.TabIndex = 11;
            btnFC03ReadHoldingRegisters.Text = "START READING";
            btnFC03ReadHoldingRegisters.UseVisualStyleBackColor = true;
            btnFC03ReadHoldingRegisters.Click += btnFC03ReadHoldingRegisters_Click;
            // 
            // tmrReadHoldingRegisters
            // 
            tmrReadHoldingRegisters.Interval = 300;
            tmrReadHoldingRegisters.Tick += tmrReadHoldingRegisters_Tick;
            // 
            // frmFC03ReadHoldingRegisters
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 680);
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
            Controls.Add(btnFC03ReadHoldingRegisters);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmFC03ReadHoldingRegisters";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FC03";
            FormClosing += frmFC03ReadHoldingRegisters_FormClosing;
            Load += frmFC03ReadHoldingRegisters_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbNumeroRegistros;
        private Label label3;
        private RichTextBox rtxValoresRegistros;
        private Label label4;
        private Label lblIPSlave;
        private Label lblConexion;
        private Label lblNumeroCiclo;
        private Label label2;
        private Label label1;
        private TextBox txbDireccion;
        private Button btnFC03ReadHoldingRegisters;
        private System.Windows.Forms.Timer tmrReadHoldingRegisters;
    }
}