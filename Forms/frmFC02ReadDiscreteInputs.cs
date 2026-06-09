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
    public partial class frmFC02ReadDiscreteInputs : Form
    {
        public frmFC02ReadDiscreteInputs()
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
        private void frmFC02ReadDiscreteInputs_Load(object sender, EventArgs e)
        {
            lblIPSlave.Text = classDatos.IPSlave;
            modbus_Client.IPAddress = classDatos.IPSlave;
            txbDireccion.Text = classDatos.direccionFC02;
            Conectar();
        }

        private void frmFC02ReadDiscreteInputs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Desconectar();
            classDatos.direccionFC02 = txbDireccion.Text;
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

        private void btnFC02ReadDiscreteInputs_Click(object sender, EventArgs e)
        {
            bool[] inputCoils;

            if (txbDireccion.Text == "" || txbNumeroCoils.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            else
            {
                rtxValoresCoils.Clear();
                if (modbus_Client.Connected)
                {

                    inputCoils = modbus_Client.ReadDiscreteInputs(int.Parse(txbDireccion.Text), int.Parse(txbNumeroCoils.Text));
                    for (int i = 0; i < inputCoils.Length; i++)
                    {
                        rtxValoresCoils.Text = ($"Discrete Input {i}: {inputCoils[i]} \r\n");
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
