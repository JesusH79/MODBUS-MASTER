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
        bool conexion = false;
        ModbusClient modbus_Client = new ModbusClient();


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
                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
            }
        }

        private void frmFC04ReadInputRegister_Load(object sender, EventArgs e)
        {
            lblIPSlave.Text = classDatos.IPSlave;
            modbus_Client.IPAddress = classDatos.IPSlave;
            txbDireccion.Text = classDatos.direccionFC04;
            Conectar();
        }

        private void frmFC04ReadInputRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Desconectar();
            classDatos.direccionFC04 = txbDireccion.Text;
        }

        private void lblConexion_Click(object sender, EventArgs e)
        {
            if (modbus_Client.Connected)
            {
                Desconectar();
            }
            else
            {
                Conectar();
            }
        }

        private void btnFCO4ReadInputRegister_Click(object sender, EventArgs e)
        {
            int[] inputRegisters;

            if (txbDireccion.Text == "" || txbNumeroRegistros.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            else
            {
                rtxValoresRegistros.Clear();
                if (modbus_Client.Connected)
                {
                    
                    inputRegisters = modbus_Client.ReadInputRegisters(int.Parse(txbDireccion.Text), int.Parse(txbNumeroRegistros.Text));
                    for (int i = 0; i < inputRegisters.Length; i++)
                    {
                        rtxValoresRegistros.Text += ($"Register {i}: {inputRegisters[i]} \r\n");
                    }

                }
                else
                {
                    MessageBox.Show("No hay conexión con el esclavo.");
                }
            }
        }
    }
}
