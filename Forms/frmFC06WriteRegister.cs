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
    public partial class frmFC06WriteRegister : Form
    {
        public frmFC06WriteRegister()
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
        private void frmFC06WriteRegister_Load(object sender, EventArgs e)
        {
            lblIPSlave.Text = classDatos.IPSlave;
            modbus_Client.IPAddress = classDatos.IPSlave;
            txbDireccion.Text = classDatos.direccionFC06;
            txbValor.Text = classDatos.valorFC06;
            Conectar();
        }

        private void btnFC06WriteRegister_Click(object sender, EventArgs e)
        {
            if(txbDireccion.Text == "" || txbValor.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }else
            {
                if (modbus_Client.Connected)
                {
                    modbus_Client.WriteSingleRegister(int.Parse(txbDireccion.Text), int.Parse(txbValor.Text));
                    MessageBox.Show("valor en registro actualizado");
                }
                else
                {
                    MessageBox.Show("No hay conexión con el esclavo.");
                }
            }
            
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

        private void frmFC06WriteRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Desconectar();
            classDatos.direccionFC06 = txbDireccion.Text;
            classDatos.valorFC06 = txbValor.Text;
        }
    }
}
