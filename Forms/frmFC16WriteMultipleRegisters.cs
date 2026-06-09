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
    public partial class frmFC16WriteMultipleRegisters : Form
    {
        public frmFC16WriteMultipleRegisters()
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
        private void frmFC16WriteMultipleRegisters_Load(object sender, EventArgs e)
        {
            lblIPSlave.Text = classDatos.IPSlave;
            modbus_Client.IPAddress = classDatos.IPSlave;
            txbDireccionInicial.Text = classDatos.direccionFC16;
            txbNumeroRegistros.Text = classDatos.noRegistrosFC16;
            Conectar();
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

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            dgvRegisters.Rows.Clear();
            if (txbDireccionInicial.Text != "" && txbNumeroRegistros.Text != "")
            {
                string[] row;
                int direccion = int.Parse(txbDireccionInicial.Text);
                int numeroRegistros = int.Parse(txbNumeroRegistros.Text);

                for (int i = 0; i < numeroRegistros; i++)
                {
                    row = new string[] { $"{direccion + i}", "" };
                    dgvRegisters.Rows.Add(row);
                }
                dgvRegisters.Columns["Direccion"].ReadOnly = true;

            }
            else
            {
                MessageBox.Show("Por favor, ingresa la dirección inicial y el número de registros.");
            }
        }

        private void btnFC16WriteRegisters_Click(object sender, EventArgs e)
        {
            try
            {
                int direccionInicial = int.Parse(txbDireccionInicial.Text);
                int numeroRegistros = int.Parse(txbNumeroRegistros.Text);
                int valorRegistro;
                int[] valoresRegistros = new int[numeroRegistros];
                for (int i = 0; i < numeroRegistros; i++)
                {
                    valorRegistro = Convert.ToInt32(dgvRegisters.Rows[i].Cells[1].Value);
                    valoresRegistros[i] = valorRegistro;
                }
                modbus_Client.WriteMultipleRegisters(direccionInicial, valoresRegistros);
                MessageBox.Show("Registros escritos correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al escribir los registros: " + ex.Message);
            }
        }

       

        private void dgvRegisters_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;

            if (dgvRegisters.CurrentCell.ColumnIndex == 1)
            {
                if (txt != null)
                {

                    txt.KeyPress -= new KeyPressEventHandler(Grid_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(Grid_KeyPress);
                }
            }
            else
            {

                txt.KeyPress -= new KeyPressEventHandler(Grid_KeyPress);
            }
        }

        private void Grid_KeyPress(object? sender, KeyPressEventArgs e)
        {
            DataGridViewCell celda = dgvRegisters.SelectedCells[0];
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
