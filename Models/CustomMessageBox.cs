using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MODBUS_MASTER.Models
{
    public class CustomMessageBox : Form
    {
        private Label lblMessage;
        private Button btnOk;
        private Button btnCancel;
        private PictureBox pictureBox;

        private CustomMessageBox(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            this.Text = title;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.AutoSize = false;
            this.Size = new Size(350, 200);
            this.StartPosition = FormStartPosition.Manual; // Clave para controlar posición

            pictureBox = new PictureBox
            {
                Location = new Point(20, 25),
                Size = new Size(48, 48),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            switch (icon)
            {
                case MessageBoxIcon.Information:
                    pictureBox.Image = SystemIcons.Information.ToBitmap();
                    break;
                case MessageBoxIcon.Warning:
                    pictureBox.Image = SystemIcons.Warning.ToBitmap();
                    break;
                case MessageBoxIcon.Error:
                    pictureBox.Image = SystemIcons.Error.ToBitmap();
                    break;
                case MessageBoxIcon.Question:
                    pictureBox.Image = SystemIcons.Question.ToBitmap();
                    break;
            }

            lblMessage = new Label
            {
                Text = message,
                Location = new Point(65, 20),
                Size = new Size(260, 65),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter
            };

            btnOk = new Button
            {
                Text = "Aceptar",
                DialogResult = DialogResult.OK,
                Location = new Point(140, 90),
                Size = new Size(80, 40)
            };

            btnCancel = new Button
            {
                Text = "Cancelar",
                DialogResult = DialogResult.Cancel,
                Location = new Point(250, 90),
                Size = new Size(80, 30),
                Visible = (buttons == MessageBoxButtons.OKCancel)
            };

            this.Controls.Add(pictureBox);
            this.Controls.Add(lblMessage);
            this.Controls.Add(btnOk);
            this.Controls.Add(btnCancel);

            this.AcceptButton = btnOk;
            this.CancelButton = btnCancel;
        }

        /// <summary>
        /// Muestra el mensaje en una posición X,Y específica de la pantalla.
        /// </summary>
        public static DialogResult Show(string message, string title, int x, int y,
            MessageBoxButtons buttons = MessageBoxButtons.OK,
            MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            var msgBox = new CustomMessageBox(message, title, buttons, icon)
            {
                Location = new Point(x, y)
            };
            return msgBox.ShowDialog();
        }

        /// <summary>
        /// Muestra el mensaje relativo a una esquina/posición predefinida de la pantalla.
        /// </summary>
        public static DialogResult Show(string message, string title, ScreenPosition position,
            MessageBoxButtons buttons = MessageBoxButtons.OK,
            MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            var msgBox = new CustomMessageBox(message, title, buttons, icon);

            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int x = 0, y = 0;

            switch (position)
            {
                case ScreenPosition.TopLeft:
                    x = screen.Left; y = screen.Top;
                    break;
                case ScreenPosition.TopRight:
                    x = screen.Right - msgBox.Width; y = screen.Top;
                    break;
                case ScreenPosition.BottomLeft:
                    x = screen.Left; y = screen.Bottom - msgBox.Height;
                    break;
                case ScreenPosition.BottomRight:
                    x = screen.Right - msgBox.Width; y = screen.Bottom - msgBox.Height;
                    break;
                case ScreenPosition.Center:
                    x = (screen.Width - msgBox.Width) / 2;
                    y = (screen.Height - msgBox.Height) / 2;
                    break;
            }

            msgBox.Location = new Point(x, y);
            return msgBox.ShowDialog();
        }
    }

    public enum ScreenPosition
    {
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight,
        Center
    }


}
