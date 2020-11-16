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
        LServicio servicio = new LServicio();
        LTransporte transporte = new LTransporte();
        PedidoL pedido = new PedidoL();

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
            dtgvProductos.DataSource = producto.CargarProducto("", "");
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
            dtgvServicios.DataSource = servicio.CargarServicio("","");
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
            CargarTransportes();
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

        private void button15_Click(object sender, EventArgs e)
        {
            if (idSeleccionadoTransporte.Text != "")
            {
                transporte.EditarTransporte(txtNumeroVehiculo.Text, txtIdConductor.Text, true, Convert.ToInt32(idSeleccionadoTransporte.Text));
                CargarTransportes();
                lblMensajeTransporte.Text = "Edición exitosa";
                LimpiarDatosTransporte();


            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                mensajeSeleccionTransporte.Text = "Transporte seleccionado:";
                idSeleccionadoTransporte.Text = dtgvTransportes.CurrentRow.Cells[0].Value.ToString();
                txtIdConductor.Text = dtgvTransportes.CurrentRow.Cells[1].Value.ToString();
                txtNumeroVehiculo.Text = dtgvTransportes.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                mensajeSeleccion.Text = "Error al seleccionar";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (dtgvTransportes.CurrentRow.Cells[0].Value.ToString() != "")
            {
                transporte.EliminarTransporte(Convert.ToInt32(dtgvTransportes.CurrentRow.Cells[0].Value.ToString()));
                CargarTransportes();
            }
        }

        private void cmbReportes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbReportes.SelectedIndex == 0)
            {
                dtpDia.Visible = false;
                Reporte1();
            }
            else if (cmbReportes.SelectedIndex == 1)
            {
                dtpDia.Visible = false;
                //Reporte2();
            }
        }

        private void LimpiarGrafico()
        {
            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }
        }

        private void Reporte1()
        {
            LimpiarGrafico();
            int productos = 0;
            int servicios = 0;

            productos += pedido.CargarPedidoCompletoProducto().Count;
            productos += pedido.CargarPedidoClienteProducto().Count;
            
            servicios += pedido.CargarPedidoCompletoServicio().Count;
            servicios += pedido.CargarPedidoSoloServicioServicio().Count;
            servicios += pedido.CargarPedidoClienteServicio().Count;

            chart.Titles[0].Text = "Reporte Ventas Productos y Servicios";
            chart.Series["Series"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart.Series["Series"].IsValueShownAsLabel = true;
            chart.Series["Series"].Points.AddXY("Productos", productos);
            chart.Series["Series"].Points.AddXY("Servicios", servicios);
        }

        //private void Reporte2()
        //{
        //    LimpiarGrafico();

        //    chart.Titles[0].Text = "Cantidad de ventas por categoría de productos";
        //    chart.Series["Series"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        //    chart.Series["Series"].IsValueShownAsLabel = true;

        //    foreach (string i in producto.CargarCategoriaProducto())
        //    {
        //        chart.Series["Series"].Points.AddXY(i, 0);
        //        foreach (var j in pedido.CargarCantidadPedidoCompletoProductoCategoria())
        //        {
        //            if (j == i)
        //            {
        //                //chart.Series["Series"].Points[0].YValues += j;
        //            }
        //        }
        //    }
        //}
    }
}
