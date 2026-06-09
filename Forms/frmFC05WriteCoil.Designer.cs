namespace MODBUS_MASTER.Forms
{
    partial class frmFC05WriteCoil
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
            lblValorBool = new Label();
            txbDireccion = new TextBox();
            btnFC05 = new Button();
            lblConexion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 0;
            label1.Text = "IP SLAVE:";
            // 
            // lblIPSlave
            // 
            lblIPSlave.AutoSize = true;
            lblIPSlave.Location = new Point(122, 24);
            lblIPSlave.Margin = new Padding(4, 0, 4, 0);
            lblIPSlave.Name = "lblIPSlave";
            lblIPSlave.Size = new Size(65, 28);
            lblIPSlave.TabIndex = 1;
            lblIPSlave.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 78);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 2;
            label2.Text = "DIRECCION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 125);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 3;
            label3.Text = "VALOR";
            // 
            // lblValorBool
            // 
            lblValorBool.AutoSize = true;
            lblValorBool.BackColor = SystemColors.ButtonFace;
            lblValorBool.Location = new Point(131, 125);
            lblValorBool.Margin = new Padding(4, 0, 4, 0);
            lblValorBool.Name = "lblValorBool";
            lblValorBool.Size = new Size(51, 28);
            lblValorBool.TabIndex = 4;
            lblValorBool.Text = "false";
            lblValorBool.Click += lblValorBool_Click;
            // 
            // txbDireccion
            // 
            txbDireccion.Location = new Point(131, 78);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(67, 34);
            txbDireccion.TabIndex = 5;
            // 
            // btnFC05
            // 
            btnFC05.Location = new Point(131, 191);
            btnFC05.Name = "btnFC05";
            btnFC05.Size = new Size(90, 47);
            btnFC05.TabIndex = 6;
            btnFC05.Text = "WRITE";
            btnFC05.UseVisualStyleBackColor = true;
            btnFC05.Click += btnFC05_Click;
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.BackColor = Color.Red;
            lblConexion.BorderStyle = BorderStyle.FixedSingle;
            lblConexion.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConexion.Location = new Point(32, 192);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(68, 48);
            lblConexion.TabIndex = 7;
            lblConexion.Text = "NC";
            lblConexion.Click += lblConexion_Click;
            // 
            // frmFC05WriteCoil
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(257, 259);
            Controls.Add(lblConexion);
            Controls.Add(btnFC05);
            Controls.Add(txbDireccion);
            Controls.Add(lblValorBool);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblIPSlave);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmFC05WriteCoil";
            Text = "FC05WriteCoils";
            FormClosing += frmFC05WriteCoil_FormClosing;
            Load += frmFC05WriteCoil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblIPSlave;
        private Label label2;
        private Label label3;
        private Label lblValorBool;
        private TextBox txbDireccion;
        private Button btnFC05;
        private Label lblConexion;
    }
}