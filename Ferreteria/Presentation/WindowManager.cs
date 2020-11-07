﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Entities;

namespace Presentation
{
    public partial class WindowManager : Form
    {
        public WindowManager()
        {
            InitializeComponent();
        }
        LProducto producto = new LProducto();
        LServicio servicio = new LServicio();
        LTransporte transporte = new LTransporte();

        public void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else {
                    e.Handled = true;
                }

            }
            catch (Exception) {
            }


        }
        public void LimpiarDatosProducto() {
            txtNombreProducto.Text = "";
            txtCatProducto.Text = "";
            txtDescripProducto.Text = "";
            txtPreProducto.Text = "";
            txtCantProducto.Text = "";
            mensajeSeleccion.Text = "";
            idSelecionado.Text = "";
        }
        public void CargarProductos() {
            dtgvProductos.DataSource = null;
            dtgvProductos.DataSource = producto.CargarProducto();
        }
        public void LimpiarDatosServicio()
        {
            txtNombreServicio.Text = "";
            txtCategoriaServicio.Text = "";
            txtDescripcionServicio.Text = "";
            txtPrecioServicio.Text = "";
            mensajeSeleccionServicio.Text = "";
            idSeleccionadoServicio.Text = "";
        }

        public void CargarServicios()
        {
            dtgvServicios.DataSource = null;
            dtgvServicios.DataSource = servicio.CargarServicio();
        }

        public void LimpiarDatosTransporte()
        {
            txtNumeroVehiculo.Text = "";
            txtIdConductor.Text = "";
        }

        public void CargarTransportes()
        {
            dtgvTransportes.DataSource = null;
            dtgvTransportes.DataSource = transporte.CargarTransportes();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (idSeleccionadoServicio.Text != "")
            {
                servicio.EditarServicio(txtNombreServicio.Text, txtCategoriaServicio.Text, txtDescripcionServicio.Text, Convert.ToDecimal(txtPrecioServicio.Text), Convert.ToInt32(idSeleccionadoServicio.Text));
                CargarServicios();
                lblMensajeServicio.Text = "Edición exitosa";
                LimpiarDatosServicio();


            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtNombreServicio.Text != "" && txtCategoriaServicio.Text != "" && txtPrecioServicio.Text != "" && txtDescripcionServicio.Text != "")
            {
                servicio.RegistrarServicio(txtNombreServicio.Text, txtCategoriaServicio.Text, txtDescripcionServicio.Text, Convert.ToDecimal(txtPrecioServicio.Text));
                lblMensajeServicio.Text = "Registro exitoso";
                LimpiarDatosServicio();
                CargarServicios();
            }
            else
            {
                lblMensajeProducto.Text = "Debe completar todos los espacios";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                mensajeSeleccionServicio.Text = "Servicio seleccionado:";
                idSeleccionadoServicio.Text = dtgvServicios.CurrentRow.Cells[0].Value.ToString();
                txtNombreServicio.Text = dtgvServicios.CurrentRow.Cells[1].Value.ToString();
                txtCategoriaServicio.Text = dtgvServicios.CurrentRow.Cells[2].Value.ToString();
                txtPrecioServicio.Text = dtgvServicios.CurrentRow.Cells[4].Value.ToString();
                txtDescripcionServicio.Text = dtgvServicios.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                mensajeSeleccion.Text = "Error al seleccionar";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dtgvServicios.CurrentRow.Cells[0].Value.ToString() != "")
            {
                servicio.EliminarServicio(Convert.ToInt32(dtgvServicios.CurrentRow.Cells[0].Value.ToString()));
                CargarServicios();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text != "" && txtCatProducto.Text != "" && txtPreProducto.Text != "" && txtCantProducto.Text != "" && txtDescripProducto.Text != "")
            {
                producto.RegistrarProducto(txtNombreProducto.Text, txtCatProducto.Text, txtDescripProducto.Text, Convert.ToDecimal(txtPreProducto.Text), Convert.ToDecimal(txtCantProducto.Text));
                lblMensajeProducto.Text = "Registro exitoso";
                LimpiarDatosProducto();
                CargarProductos();
            }
            else {
                lblMensajeProducto.Text = "Debe completar todos los espacios";
            }
        }

        private void txtPreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtCantProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CargarProductos();

        }

        private void WindowManager_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarServicios();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                mensajeSeleccion.Text = "Producto seleccionado:";
                idSelecionado.Text = dtgvProductos.CurrentRow.Cells[0].Value.ToString();
                txtNombreProducto.Text = dtgvProductos.CurrentRow.Cells[1].Value.ToString();
                txtCatProducto.Text = dtgvProductos.CurrentRow.Cells[2].Value.ToString();
                txtPreProducto.Text = dtgvProductos.CurrentRow.Cells[3].Value.ToString();
                txtCantProducto.Text = dtgvProductos.CurrentRow.Cells[4].Value.ToString();
                txtDescripProducto.Text = dtgvProductos.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {
                mensajeSeleccion.Text = "Error al seleccionar";
            }
        }


        private void dtgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idSelecionado.Text != "") {
                producto.EditarProducto(txtNombreProducto.Text, txtCatProducto.Text, txtDescripProducto.Text, Convert.ToDecimal(txtPreProducto.Text), Convert.ToDecimal(txtCantProducto.Text), Convert.ToInt32(idSelecionado.Text));
                CargarProductos();
                lblMensajeProducto.Text = "Edición exitosa";
                LimpiarDatosProducto();
                

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dtgvProductos.CurrentRow.Cells[0].Value.ToString() != "")
            {
                producto.EliminarProducto(Convert.ToInt32(dtgvProductos.CurrentRow.Cells[0].Value.ToString()));
                CargarProductos();
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtNumeroVehiculo.Text != "" && txtIdConductor.Text != "")
            {
                transporte.RegistrarTransporte(txtNumeroVehiculo.Text, txtIdConductor.Text, true);
                lblMensajeTransporte.Text = "Registro exitoso";
                LimpiarDatosTransporte();
                CargarTransportes();
            }
            else
            {
                lblMensajeProducto.Text = "Debe completar todos los espacios";
            }
        }
    }
}
