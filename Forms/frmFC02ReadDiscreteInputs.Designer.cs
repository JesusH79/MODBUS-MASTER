namespace MODBUS_MASTER.Forms
{
    partial class frmFC02ReadDiscreteInputs
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
            lblConexion = new Label();
            txbDireccion = new TextBox();
            txbNumeroCoils = new TextBox();
            btnFC02ReadDiscreteInputs = new Button();
            rtxValoresCoils = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 0;
            label1.Text = "IP SLAVE:";
            // 
            // lblIPSlave
            // 
            lblIPSlave.AutoSize = true;
            lblIPSlave.Location = new Point(112, 11);
            lblIPSlave.Margin = new Padding(4, 0, 4, 0);
            lblIPSlave.Name = "lblIPSlave";
            lblIPSlave.Size = new Size(28, 28);
            lblIPSlave.TabIndex = 1;
            lblIPSlave.Text = "IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(116, 56);
            label2.TabIndex = 2;
            label2.Text = "DIRECCION \r\nINICIAL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 131);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 3;
            label3.Text = "No. COILS:";
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.FlatStyle = FlatStyle.Flat;
            lblConexion.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConexion.Location = new Point(15, 189);
            lblConexion.Margin = new Padding(4, 0, 4, 0);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(66, 46);
            lblConexion.TabIndex = 4;
            lblConexion.Text = "NC";
            lblConexion.Click += lblConexion_Click;
            // 
            // txbDireccion
            // 
            txbDireccion.Location = new Point(134, 60);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(125, 34);
            txbDireccion.TabIndex = 6;
            // 
            // txbNumeroCoils
            // 
            txbNumeroCoils.Location = new Point(134, 125);
            txbNumeroCoils.Name = "txbNumeroCoils";
            txbNumeroCoils.Size = new Size(125, 34);
            txbNumeroCoils.TabIndex = 7;
            // 
            // btnFC02ReadDiscreteInputs
            // 
            btnFC02ReadDiscreteInputs.Location = new Point(112, 189);
            btnFC02ReadDiscreteInputs.Name = "btnFC02ReadDiscreteInputs";
            btnFC02ReadDiscreteInputs.Size = new Size(146, 42);
            btnFC02ReadDiscreteInputs.TabIndex = 8;
            btnFC02ReadDiscreteInputs.Text = "READ COILS";
            btnFC02ReadDiscreteInputs.UseVisualStyleBackColor = true;
            btnFC02ReadDiscreteInputs.Click += btnFC02ReadDiscreteInputs_Click;
            // 
            // rtxValoresCoils
            // 
            rtxValoresCoils.Location = new Point(15, 267);
            rtxValoresCoils.Name = "rtxValoresCoils";
            rtxValoresCoils.ReadOnly = true;
            rtxValoresCoils.Size = new Size(244, 219);
            rtxValoresCoils.TabIndex = 9;
            rtxValoresCoils.Text = "";
            // 
            // frmFC02ReadDiscreteInputs
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 510);
            Controls.Add(rtxValoresCoils);
            Controls.Add(btnFC02ReadDiscreteInputs);
            Controls.Add(txbNumeroCoils);
            Controls.Add(txbDireccion);
            Controls.Add(lblConexion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblIPSlave);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmFC02ReadDiscreteInputs";
            Text = "frmFC02ReadDiscreteInputs";
            FormClosing += frmFC02ReadDiscreteInputs_FormClosing;
            Load += frmFC02ReadDiscreteInputs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblIPSlave;
        private Label label2;
        private Label label3;
        private Label lblConexion;
        private TextBox txbDireccion;
        private TextBox txbNumeroCoils;
        private Button btnFC02ReadDiscreteInputs;
        private RichTextBox rtxValoresCoils;
    }
}