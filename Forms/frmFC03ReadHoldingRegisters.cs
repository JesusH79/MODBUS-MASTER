using EasyModbus;
using MODBUS_MASTER.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MODBUS_MASTER.Forms
{
    public partial class frmFC03ReadHoldingRegisters : Form
    {
        public frmFC03ReadHoldingRegisters()
        {
            InitializeComponent();
        }

        int numero_ciclos = 0;
        ModbusClient modbus_Client = new ModbusClient();

        public void reiniciar_elementos()
        {
            tmrReadHoldingRegisters.Enabled = false;
            btnFC03ReadHoldingRegisters.Text = "START READING";
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

        private void frmFC03ReadHoldingRegisters_Load(object sender, EventArgs e)
        {
            lblIPSlave.Text = classDatos.IPSlave;
            modbus_Client.IPAddress = classDatos.IPSlave;
            txbDireccion.Text = classDatos.direccionFC04;
            tmrReadHoldingRegisters.Interval = 1000;
            tmrReadHoldingRegisters.Stop();
            Conectar();
        }

        private void frmFC03ReadHoldingRegisters_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrReadHoldingRegisters.Enabled = false;
            btnFC03ReadHoldingRegisters.Text = "START READING";
            Desconectar();
            classDatos.direccionFC03 = txbDireccion.Text;
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

        private void btnFC03ReadHoldingRegisters_Click(object sender, EventArgs e)
        {
            if (txbDireccion.Text == "" || txbNumeroRegistros.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            else
            {
                if (tmrReadHoldingRegisters.Enabled)
                {
                    reiniciar_elementos();
                    numero_ciclos = 0;
                }
                else
                {
                    tmrReadHoldingRegisters.Enabled = true;
                    btnFC03ReadHoldingRegisters.Text = "STOP READING";
                }

            }
        }

        private void tmrReadHoldingRegisters_Tick(object sender, EventArgs e)
        {
            int[] holdingReadRegisters;
            rtxValoresRegistros.Clear();
            if (modbus_Client.Connected)
            {
                try
                {
                    holdingReadRegisters = modbus_Client.ReadHoldingRegisters(int.Parse(txbDireccion.Text), int.Parse(txbNumeroRegistros.Text));

                    for (int i = 0; i < holdingReadRegisters.Length; i++)
                    {
                        rtxValoresRegistros.Text += ($"Register {i}: {holdingReadRegisters[i]} \r\n");
                    }
                    numero_ciclos++;
                    lblNumeroCiclo.Text = numero_ciclos.ToString();
                }
                catch (Exception ex)
                {
                    reiniciar_elementos();
                    CustomMessageBox.Show("Error: " + ex.Message, "Aviso", 500, 300, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                CustomMessageBox.Show("No hay conexión con el esclavo.", "Aviso", 500, 300, MessageBoxButtons.OK, MessageBoxIcon.Information);
                reiniciar_elementos();
            }
        }


    }
}
