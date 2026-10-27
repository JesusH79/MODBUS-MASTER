using AutoUpdaterDotNET;
using MODBUS_MASTER.Forms;
using MODBUS_MASTER.Models;
using MODBUS_MASTER.Properties;
using static System.Windows.Forms.DataFormats;

namespace MODBUS_MASTER
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            /*
             para subir isntaldor a repsoitorio github
              git add .
              git commit -m "Actualización"
              git push*/

            txbIPSlave.Text = Settings.Default.IP;
            //CustomMessageBox.Show("Bienvenido al programa MODBUS MASTER", "Aviso", 500, 300, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnFC05_Click(object sender, EventArgs e)
        {
            classDatos.IPSlave = txbIPSlave.Text;
            try
            {

                // Crear instancia del segundo formulario
                frmFC05WriteCoil frmFC05 = new();

                // Mostrar el formulario como ventana independiente
                frmFC05.ShowDialog();

                // Si quieres que sea modal (bloquea el principal hasta cerrar)
                // ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFC06_Click(object sender, EventArgs e)
        {
            classDatos.IPSlave = txbIPSlave.Text;
            try
            {
                // Crear instancia del segundo formulario
                frmFC06WriteRegister frmFC06 = new();

                // Mostrar el formulario como ventana independiente
                frmFC06.ShowDialog();

                // Si quieres que sea modal (bloquea el principal hasta cerrar)
                // ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.IP = txbIPSlave.Text;
            Settings.Default.Save();
        }

        private void btnFC04_Click(object sender, EventArgs e)
        {
            classDatos.IPSlave = txbIPSlave.Text;
            try
            {
                // Crear instancia del segundo formulario
                frmFC04ReadInputRegister frmFC04 = new();

                // Mostrar el formulario como ventana independiente
                frmFC04.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFC15_Click(object sender, EventArgs e)
        {
            classDatos.IPSlave = txbIPSlave.Text;
            try
            {
                // Crear instancia del segundo formulario
                frmFC15WriteMultipleCoils frmFC15 = new();

                // Mostrar el formulario como ventana independiente
                frmFC15.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFC16_Click(object sender, EventArgs e)
        {
            classDatos.IPSlave = txbIPSlave.Text;
            try
            {
                // Crear instancia del segundo formulario
                frmFC16WriteMultipleRegisters frmFC16 = new();

                // Mostrar el formulario como ventana independiente
                frmFC16.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFC02_Click(object sender, EventArgs e)
        {
            classDatos.IPSlave = txbIPSlave.Text;
            try
            {
                // Crear instancia del segundo formulario
                frmFC02ReadDiscreteInputs frmFC02 = new();

                // Mostrar el formulario como ventana independiente
                frmFC02.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFC03_Click(object sender, EventArgs e)
        {
            classDatos.IPSlave = txbIPSlave.Text;
            try
            {
                // Crear instancia del segundo formulario
                frmFC03ReadHoldingRegisters frmFC03 = new();

                // Mostrar el formulario como ventana independiente
                frmFC03.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
