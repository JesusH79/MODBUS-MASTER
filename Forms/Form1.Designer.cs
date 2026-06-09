namespace MODBUS_MASTER
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            label1 = new Label();
            txbIPSlave = new TextBox();
            btnFC05 = new Button();
            btnFC06 = new Button();
            btnFC04 = new Button();
            btnFC15 = new Button();
            btnFC16 = new Button();
            btnFC02 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(88, 35);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 0;
            label1.Text = "IP SLAVE";
            // 
            // txbIPSlave
            // 
            txbIPSlave.Font = new Font("Segoe UI", 12F);
            txbIPSlave.Location = new Point(182, 35);
            txbIPSlave.Name = "txbIPSlave";
            txbIPSlave.Size = new Size(135, 34);
            txbIPSlave.TabIndex = 1;
            txbIPSlave.Text = "192.168.1.22";
            // 
            // btnFC05
            // 
            btnFC05.BackColor = Color.LightYellow;
            btnFC05.FlatStyle = FlatStyle.Popup;
            btnFC05.Location = new Point(12, 109);
            btnFC05.Name = "btnFC05";
            btnFC05.Size = new Size(189, 72);
            btnFC05.TabIndex = 2;
            btnFC05.Text = "WRITE \r\nSINGLE COILS";
            btnFC05.UseVisualStyleBackColor = false;
            btnFC05.Click += btnFC05_Click;
            // 
            // btnFC06
            // 
            btnFC06.BackColor = Color.LightYellow;
            btnFC06.FlatStyle = FlatStyle.Popup;
            btnFC06.Location = new Point(240, 109);
            btnFC06.Name = "btnFC06";
            btnFC06.Size = new Size(189, 72);
            btnFC06.TabIndex = 3;
            btnFC06.Text = "WRITE\r\nSINGLE REGISTER";
            btnFC06.UseVisualStyleBackColor = false;
            btnFC06.Click += btnFC06_Click;
            // 
            // btnFC04
            // 
            btnFC04.BackColor = Color.LightYellow;
            btnFC04.FlatStyle = FlatStyle.Popup;
            btnFC04.Location = new Point(240, 302);
            btnFC04.Name = "btnFC04";
            btnFC04.Size = new Size(189, 72);
            btnFC04.TabIndex = 4;
            btnFC04.Text = "READ INPUT REGISTERS";
            btnFC04.UseVisualStyleBackColor = false;
            btnFC04.Click += btnFC04_Click;
            // 
            // btnFC15
            // 
            btnFC15.BackColor = Color.LightYellow;
            btnFC15.FlatStyle = FlatStyle.Popup;
            btnFC15.Location = new Point(12, 208);
            btnFC15.Name = "btnFC15";
            btnFC15.Size = new Size(189, 72);
            btnFC15.TabIndex = 5;
            btnFC15.Text = "WRITE MULTPLES COILS";
            btnFC15.UseVisualStyleBackColor = false;
            btnFC15.Click += btnFC15_Click;
            // 
            // btnFC16
            // 
            btnFC16.BackColor = Color.LightYellow;
            btnFC16.FlatStyle = FlatStyle.Popup;
            btnFC16.Location = new Point(240, 208);
            btnFC16.Name = "btnFC16";
            btnFC16.Size = new Size(189, 72);
            btnFC16.TabIndex = 6;
            btnFC16.Text = "WRITE MULTIMPLE REGISTERS";
            btnFC16.UseVisualStyleBackColor = false;
            btnFC16.Click += btnFC16_Click;
            // 
            // btnFC02
            // 
            btnFC02.BackColor = Color.LightYellow;
            btnFC02.FlatStyle = FlatStyle.Popup;
            btnFC02.Location = new Point(12, 302);
            btnFC02.Name = "btnFC02";
            btnFC02.Size = new Size(189, 72);
            btnFC02.TabIndex = 7;
            btnFC02.Text = "READ DISCRETE COILS";
            btnFC02.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(453, 399);
            Controls.Add(btnFC02);
            Controls.Add(btnFC16);
            Controls.Add(btnFC15);
            Controls.Add(btnFC04);
            Controls.Add(btnFC06);
            Controls.Add(btnFC05);
            Controls.Add(txbIPSlave);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPrincipal";
            Text = "MASTER MODBUS";
            FormClosing += frmPrincipal_FormClosing;
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbIPSlave;
        private Button btnFC05;
        private Button btnFC06;
        private Button btnFC04;
        private Button btnFC15;
        private Button btnFC16;
        private Button btnFC02;
    }
}
