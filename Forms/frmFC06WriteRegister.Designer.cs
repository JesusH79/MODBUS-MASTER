namespace MODBUS_MASTER.Forms
{
    partial class frmFC06WriteRegister
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
            label3 = new Label();
            label4 = new Label();
            btnFC06WriteRegister = new Button();
            txbDireccion = new TextBox();
            txbValor = new TextBox();
            lblConexion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 23);
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
            lblIPSlave.Location = new Point(131, 23);
            lblIPSlave.Margin = new Padding(4, 0, 4, 0);
            lblIPSlave.Name = "lblIPSlave";
            lblIPSlave.Size = new Size(65, 28);
            lblIPSlave.TabIndex = 1;
            lblIPSlave.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 68);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 2;
            label3.Text = "DIRECCION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 131);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 3;
            label4.Text = "VALOR";
            // 
            // btnFC06WriteRegister
            // 
            btnFC06WriteRegister.Location = new Point(131, 208);
            btnFC06WriteRegister.Name = "btnFC06WriteRegister";
            btnFC06WriteRegister.Size = new Size(125, 48);
            btnFC06WriteRegister.TabIndex = 4;
            btnFC06WriteRegister.Text = "WRITE HR";
            btnFC06WriteRegister.UseVisualStyleBackColor = true;
            btnFC06WriteRegister.Click += btnFC06WriteRegister_Click;
            // 
            // txbDireccion
            // 
            txbDireccion.Location = new Point(131, 68);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(125, 34);
            txbDireccion.TabIndex = 5;
            // 
            // txbValor
            // 
            txbValor.Location = new Point(131, 128);
            txbValor.Name = "txbValor";
            txbValor.Size = new Size(125, 34);
            txbValor.TabIndex = 6;
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.BackColor = Color.Red;
            lblConexion.BorderStyle = BorderStyle.FixedSingle;
            lblConexion.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConexion.Location = new Point(43, 208);
            lblConexion.Margin = new Padding(4, 0, 4, 0);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(68, 48);
            lblConexion.TabIndex = 7;
            lblConexion.Text = "NC";
            lblConexion.Click += lblConexion_Click;
            // 
            // frmFC06WriteRegister
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(297, 300);
            Controls.Add(lblConexion);
            Controls.Add(txbValor);
            Controls.Add(txbDireccion);
            Controls.Add(btnFC06WriteRegister);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblIPSlave);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmFC06WriteRegister";
            Text = "Write Single Register";
            FormClosing += frmFC06WriteRegister_FormClosing;
            Load += frmFC06WriteRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblIPSlave;
        private Label label3;
        private Label label4;
        private Button btnFC06WriteRegister;
        private TextBox txbDireccion;
        private TextBox txbValor;
        private Label lblConexion;
    }
}