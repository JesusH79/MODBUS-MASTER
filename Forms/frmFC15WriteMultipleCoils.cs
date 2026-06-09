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
    public partial class frmFC15WriteMultipleCoils : Form
    {
        public frmFC15WriteMultipleCoils()
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


        private void frmFC15WriteMultipleCoils_Load(object sender, EventArgs e)
        {
            lblIPSlave.Text = classDatos.IPSlave;
            modbus_Client.IPAddress = classDatos.IPSlave;
            txbDireccionInicial.Text = classDatos.direccionFC05;
            txbNumeroCoils.Text = classDatos.noCoilsFC15;
            Conectar();

        }

        private void frmFC15WriteMultipleCoils_FormClosing(object sender, FormClosingEventArgs e)
        {
            classDatos.direccionFC15 = txbDireccionInicial.Text;
            classDatos.noCoilsFC15 = txbNumeroCoils.Text;
            Desconectar();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            dgvValoresColis.Rows.Clear();
            if (txbDireccionInicial.Text != "" && txbNumeroCoils.Text != "")
            {
                string[] row;
                int direccion = int.Parse(txbDireccionInicial.Text);
                int numeroCoils = int.Parse(txbNumeroCoils.Text);

                for (int i = 0; i < numeroCoils; i++)
                {
                    row = new string[] { $"{direccion + i}", "" };
                    dgvValoresColis.Rows.Add(row);
                }
                dgvValoresColis.Columns["Direccion"].ReadOnly = true;

            }
            else
            {
                MessageBox.Show("Por favor, ingresa la dirección inicial y el número de coils.");
            }
        }

        private void btnFC15_Click(object sender, EventArgs e)
        {
            try
            {
                int direccionInicial = int.Parse(txbDireccionInicial.Text);
                int numeroCoils = int.Parse(txbNumeroCoils.Text);
                int valorCoil;
                string valorCoils_string;
                bool[] valoresCoils = new bool[numeroCoils];
                for (int i = 0; i < numeroCoils; i++)
                {
                    valorCoil = Convert.ToInt32(dgvValoresColis.Rows[i].Cells[1].Value);

                    if (valorCoil == 1)
                    {
                        valorCoils_string = "true";
                    }
                    else
                    {
                        valorCoils_string = "false";
                    }
                    valoresCoils[i] = Convert.ToBoolean(valorCoils_string); // Puedes cambiar esto a true si quieres escribir 1s
                }
                modbus_Client.WriteMultipleCoils(direccionInicial, valoresCoils);
                MessageBox.Show("Coils escritos correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al escribir coils: " + ex.Message);
            }
        }

        private void dgvValoresColis_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            if (dgvValoresColis.CurrentCell.ColumnIndex == 1)
            {
                e.Control.KeyPress -= Cell_KeyPress; // Evita suscripción duplicada
                e.Control.KeyPress += Cell_KeyPress;
            }

        }

        private void Cell_KeyPress(object? sender, KeyPressEventArgs e)
        {
            DataGridViewCell currentCell = dgvValoresColis.CurrentCell;

            if (e.KeyChar == ' ')
            {
                string currentValue = (currentCell.Value == null || currentCell.Value.ToString() == "")
                                      ? "0"
                                      : currentCell.Value.ToString();

                // Establece el valor en el TextBox interno
                TextBox tb = sender as TextBox;
                if (tb != null)
                    tb.Text = (currentValue == "1") ? "0" : "1";

                e.Handled = true;
            }
            else if (e.KeyChar == '1' || e.KeyChar == '0')
            {
                // Establece el valor en el TextBox interno directamente
                TextBox tb = sender as TextBox;
                if (tb != null)
                    tb.Text = e.KeyChar.ToString();

                e.Handled = true;
            }
            else
            {
                e.Handled = true;
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

       
    }
}
