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
    public partial class frmFC05WriteCoil : Form
    {
        public frmFC05WriteCoil()
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

        private void frmFC05WriteCoil_Load(object sender, EventArgs e)
        {
            lblIPSlave.Text = classDatos.IPSlave;
            modbus_Client.IPAddress = classDatos.IPSlave;
            txbDireccion.Text = classDatos.direccionFC05;
            Conectar();
        }


        private void lblValorBool_Click(object sender, EventArgs e)
        {
            if (lblValorBool.Text == "true")
            {
                lblValorBool.Text = "false";
            }
            else
            {
                lblValorBool.Text = "true";
            }
        }

        private void btnFC05_Click(object sender, EventArgs e)
        {
            if (txbDireccion.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            else
            {
                if (modbus_Client.Connected)
                {
                    modbus_Client.WriteSingleCoil(int.Parse(txbDireccion.Text), Convert.ToBoolean(lblValorBool.Text));
                }
                else
                {
                    MessageBox.Show("No hay conexión con el esclavo.");
                }
            }
            
        
        }

        private void frmFC05WriteCoil_FormClosing(object sender, FormClosingEventArgs e)
        {
            classDatos.direccionFC05 = txbDireccion.Text;
            Desconectar();
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
    }
}
