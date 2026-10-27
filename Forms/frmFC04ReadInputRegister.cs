using EasyModbus;
using MODBUS_MASTER.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static EasyModbus.ModbusServer;

namespace MODBUS_MASTER.Forms
{
    public partial class frmFC04ReadInputRegister : Form
    {
        public frmFC04ReadInputRegister()
        {
            InitializeComponent();
        }
  
        int numero_ciclos = 0;
        ModbusClient modbus_Client = new ModbusClient();
        

        public void reiniciar_elementos()
        {
            tmrReadInputRegisters.Enabled = false;
            btnFCO4ReadInputRegister.Text = "START READING";
        }

        public void Conectar()
        {
            try
            {
                modbus_Client.Connect();
                lblConexion.Text = "OK";
                lblConexion.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);

                CustomMessageBox.Show("Error: " + ex.Message, "Aviso", 500, 300, MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblConexion.Text = "NC";
                lblConexion.BackColor = Color.Red;
            }
        }

        public void Desconectar()
        {
            try
            {
                modbus_Client.Disconnect();
                lblConexion.Text = "NC";
                lblConexion.BackColor = Color.Red;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error: " + ex.Message, "Aviso", 500, 300, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmFC04ReadInputRegister_Load(object sender, EventArgs e)
        {
            lblIPSlave.Text = classDatos.IPSlave;
            modbus_Client.IPAddress = classDatos.IPSlave;
            txbDireccion.Text = classDatos.direccionFC04;
            tmrReadInputRegisters.Interval = 1000;
            tmrReadInputRegisters.Stop();
            Conectar();
        }

        private void frmFC04ReadInputRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrReadInputRegisters.Enabled = false;
            btnFCO4ReadInputRegister.Text = "START READING";
            Desconectar();
            classDatos.direccionFC04 = txbDireccion.Text;
        }

        private void lblConexion_Click(object sender, EventArgs e)
        {
            if (modbus_Client.Connected)
            {
                reiniciar_elementos();
                Desconectar();
                
            }
            else
            {
                Conectar();
            }
        }

        private void btnFCO4ReadInputRegister_Click(object sender, EventArgs e)
        {


            if (txbDireccion.Text == "" || txbNumeroRegistros.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            else
            {
                if (tmrReadInputRegisters.Enabled)
                {
                    reiniciar_elementos();
                    numero_ciclos = 0;
                }
                else
                {
                    tmrReadInputRegisters.Enabled = true;
                    btnFCO4ReadInputRegister.Text = "STOP READING";
                }
                
            }
        }

        private void tmrReadInputRegisters_Tick(object sender, EventArgs e)
        {
            int[] inputRegisters;
            rtxValoresRegistros.Clear();
            if (modbus_Client.Connected)
            {
                try
                {
                    inputRegisters = modbus_Client.ReadInputRegisters(int.Parse(txbDireccion.Text), int.Parse(txbNumeroRegistros.Text));
                   
                    for (int i = 0; i < inputRegisters.Length; i++)
                    {
                        rtxValoresRegistros.Text += ($"Register {i}: {inputRegisters[i]} \r\n");
                    }
                    numero_ciclos++;
                    lblNumeroCiclo.Text = numero_ciclos.ToString();
                }
                catch (Exception ex)
                {
                    reiniciar_elementos();
                    CustomMessageBox.Show("Error: " + ex.Message , "Aviso", 500, 300, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

            }
            else
            {
                CustomMessageBox.Show("No hay conexión con el esclavo.", "Aviso", 500, 300, MessageBoxButtons.OK, MessageBoxIcon.Information);
                reiniciar_elementos() ;
            }
        }
    }
}
