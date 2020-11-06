using System;
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
            catch (Exception ex) {
            }


        }
        public void limpiarDatosProducto() {
            txtNombreProducto.Text = "";
            txtCatProducto.Text = "";
            txtDescripProducto.Text = "";
            txtPreProducto.Text = "";
            txtCantProducto.Text = "";
            mensajeSeleccion.Text = "";
            idSelecionado.Text = "";
        }
        public void cargarProductos() {
            dtgvProductos.DataSource = null;
            dtgvProductos.DataSource = producto.CargarProducto();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

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
                limpiarDatosProducto();
                cargarProductos();
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
            cargarProductos();

        }

        private void WindowManager_Load(object sender, EventArgs e)
        {
            cargarProductos();
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
                mensajeSeleccion.Text = "fllo";
            }
        }


        private void dtgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idSelecionado.Text != "") {
                producto.EditarProducto(txtNombreProducto.Text, txtCatProducto.Text, txtDescripProducto.Text, Convert.ToDecimal(txtPreProducto.Text), Convert.ToDecimal(txtCantProducto.Text), Convert.ToInt32(idSelecionado.Text));
                cargarProductos();
                lblMensajeProducto.Text = "Edición exitosa";
                limpiarDatosProducto();
                

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dtgvProductos.CurrentRow.Cells[0].Value.ToString() != "")
            {
                producto.EliminarProducto(Convert.ToInt32(dtgvProductos.CurrentRow.Cells[0].Value.ToString()));
                cargarProductos();
            }

        }
    }
}
