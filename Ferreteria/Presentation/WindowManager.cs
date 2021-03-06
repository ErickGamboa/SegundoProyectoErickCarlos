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
using Entities.Reportes;

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
        LUsuario usuario = new LUsuario();

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

            /*
             This method clean the Products tab. Null values are saved to the components of tab
                 */
        }
        public void LimpiarDatosProducto() {
            txtNombreProducto.Text = "";
            txtCatProducto.Text = "";
            txtDescripProducto.Text = "";
            txtPreProducto.Text = "";
            txtCantProducto.Text = "";
            mensajeSeleccion.Text = "";
            idSelecionado.Text = "";
            checkBox1.Checked = true;
        }

        /*
         This method connect the logic layer with presentation layer. Call one data grid view 
         and save objects that brings a logic method
             */

        public void CargarProductos() {
            dtgvProductos.DataSource = null;
            dtgvProductos.DataSource = producto.CargarProducto("", "");
        }

        /*
         This method clean the Services tab. Null values are saved to the components of tab
             */

        public void LimpiarDatosServicio()
        {
            txtNombreServicio.Text = "";
            txtCategoriaServicio.Text = "";
            txtDescripcionServicio.Text = "";
            txtPrecioServicio.Text = "";
            mensajeSeleccionServicio.Text = "";
            idSeleccionadoServicio.Text = "";
            checkBox2.Checked = true;
        }

        /*
         This method connect the logic layer with presentation layer. Call one data grid view 
         and save objects that brings a logic method
             */

        public void CargarServicios()
        {
            dtgvServicios.DataSource = null;
            dtgvServicios.DataSource = servicio.CargarServicio("","");
        }

        /*
         This method clean the transports tab. Null values are saved to the components of tab
             */

        public void LimpiarDatosTransporte()
        {
            txtNumeroVehiculo.Text = "";
            CargarConductores();
            checkBox3.Checked = true;
        }

        /*
         This method connect the logic layer with presentation layer. Call one data grid view 
         and save objects that brings a logic method
             */

        public void CargarTransportes()
        {
            dtgvTransportes.DataSource = null;
            dtgvTransportes.DataSource = transporte.CargarTransportes();
        }

        private void CargarConductores()
        {
            foreach (TransporteE t in transporte.CargarTransportes())
            {
                foreach (UsuarioE u in usuario.CargarUsuario())
                {
                    if (u.Codigo.Substring(0, 3).Equals("CON") && t.CodigoConductor != u.Codigo)
                    {
                        cmbConductor.Items.Add(u.Codigo);
                    }
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (idSeleccionadoServicio.Text != "")
            {
                servicio.EditarServicio(txtNombreServicio.Text, txtCategoriaServicio.Text, txtDescripcionServicio.Text.ToUpper(), Convert.ToDecimal(txtPrecioServicio.Text), checkBox2.Checked, Convert.ToInt32(idSeleccionadoServicio.Text));
                CargarServicios();
                lblMensajeServicio.Text = "Edición exitosa";
                LimpiarDatosServicio();


            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtNombreServicio.Text != "" && txtCategoriaServicio.Text != "" && txtPrecioServicio.Text != "" && txtDescripcionServicio.Text != "")
            {
                servicio.RegistrarServicio(txtNombreServicio.Text, txtCategoriaServicio.Text, txtDescripcionServicio.Text.ToUpper(), Convert.ToDecimal(txtPrecioServicio.Text));
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
                txtPrecioServicio.Text = dtgvServicios.CurrentRow.Cells[5].Value.ToString();
                txtDescripcionServicio.Text = dtgvServicios.CurrentRow.Cells[3].Value.ToString();
                checkBox2.Checked = Convert.ToBoolean(dtgvServicios.CurrentRow.Cells[4].Value);

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
                producto.RegistrarProducto(txtNombreProducto.Text, txtCatProducto.Text, txtDescripProducto.Text.ToUpper(), Convert.ToDecimal(txtPreProducto.Text), Convert.ToDecimal(txtCantProducto.Text));
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
            CargarConductores();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                mensajeSeleccion.Text = "Producto seleccionado:";
                idSelecionado.Text = dtgvProductos.CurrentRow.Cells[1].Value.ToString();
                txtNombreProducto.Text = dtgvProductos.CurrentRow.Cells[2].Value.ToString();
                txtCatProducto.Text = dtgvProductos.CurrentRow.Cells[3].Value.ToString();
                txtPreProducto.Text = dtgvProductos.CurrentRow.Cells[6].Value.ToString();
                txtCantProducto.Text = dtgvProductos.CurrentRow.Cells[0].Value.ToString();
                txtDescripProducto.Text = dtgvProductos.CurrentRow.Cells[4].Value.ToString();
                checkBox1.Checked = Convert.ToBoolean(dtgvProductos.CurrentRow.Cells[5].Value);
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
                producto.EditarProducto(txtNombreProducto.Text, txtCatProducto.Text, txtDescripProducto.Text.ToUpper(), Convert.ToDecimal(txtPreProducto.Text), Convert.ToDecimal(txtCantProducto.Text), checkBox1.Checked, Convert.ToInt32(idSelecionado.Text));
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
            if (txtNumeroVehiculo.Text != "" && cmbConductor.Text != "")
            {
                transporte.RegistrarTransporte(txtNumeroVehiculo.Text, cmbConductor.Text, true);
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
                transporte.EditarTransporte(txtNumeroVehiculo.Text, cmbConductor.Text, checkBox4.Checked, checkBox3.Checked, Convert.ToInt32(idSeleccionadoTransporte.Text));
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
                cmbConductor.SelectedItem = dtgvTransportes.CurrentRow.Cells[1].Value.ToString();
                txtNumeroVehiculo.Text = dtgvTransportes.CurrentRow.Cells[4].Value.ToString();
                checkBox3.Checked = Convert.ToBoolean(dtgvProductos.CurrentRow.Cells[3].Value);
                checkBox4.Checked = Convert.ToBoolean(dtgvProductos.CurrentRow.Cells[2].Value);
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
                Reporte2();
            }
            else if (cmbReportes.SelectedIndex == 2)
            {
                dtpDia.Visible = false;
                Reporte3();
            }
            else if (cmbReportes.SelectedIndex == 3)
            {
                dtpDia.Visible = false;
                Reporte4();
            }

            else if (cmbReportes.SelectedIndex == 4)
            {
                dtpDia.Visible = false;
                Reporte5();
            }

            else if (cmbReportes.SelectedIndex == 5)
            {
                dtpDia.Visible = false;
                Reporte6();
            }
            else if (cmbReportes.SelectedIndex == 6)
            {
                dtpDia.Visible = false;
                Reporte7();
            }

            else if (cmbReportes.SelectedIndex == 7)
            {
                dtpDia.Visible = true;
                Reporte8(dtpDia.Value.Date);
            }
            else if (cmbReportes.SelectedIndex == 8)
            {
                dtpDia.Visible = true;
                Reporte9(dtpDia.Value.Date);
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
            decimal productos = 0;
            decimal servicios = 0;

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

        private void Reporte2()
        {
            LimpiarGrafico();
            List<Reporte2E> reporte = new List<Reporte2E>();

            foreach (string s in producto.CargarCategoriaProducto())
            {
                reporte.Add(new Reporte2E(0, s));
            }

            foreach (Reporte2E r1 in pedido.CargarCantidadPCoPCategoria())
            {
                foreach (Reporte2E r2 in reporte)
                {
                    if (r1.Categoria == r2.Categoria)
                    {
                        r2.Cantidad += r1.Cantidad;
                        break;
                    }
                }
            }

            foreach (Reporte2E r1 in pedido.CargarCantidadPClPCategoria())
            {
                foreach (Reporte2E r2 in reporte)
                {
                    if (r1.Categoria == r2.Categoria)
                    {
                        r2.Cantidad += r1.Cantidad;
                        break;
                    }
                }
            }

            chart.Titles[0].Text = "Cantidad de ventas por categoría de productos";
            chart.Series["Series"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart.Series["Series"].IsValueShownAsLabel = true;

            foreach (Reporte2E r in reporte)
            {
                chart.Series["Series"].Points.AddXY(r.Categoria, r.Cantidad);
            }
        }
        private void Reporte3()
        {
            LimpiarGrafico();
            List<Reporte2E> reporte = new List<Reporte2E>();

            foreach (string s in servicio.CargarCategoriaServicio())
            {
                reporte.Add(new Reporte2E(0, s));
            }

            foreach (Reporte2E r1 in pedido.CargarCantidadPCoSCategoria())
            {
                foreach (Reporte2E r2 in reporte)
                {
                    if (r1.Categoria == r2.Categoria)
                    {
                        r2.Cantidad += r1.Cantidad;
                        break;
                    }
                }
            }

            foreach (Reporte2E r1 in pedido.CargarCantidadPSSCategoria())
            {
                foreach (Reporte2E r2 in reporte)
                {
                    if (r1.Categoria == r2.Categoria)
                    {
                        r2.Cantidad += r1.Cantidad;
                        break;
                    }
                }
            }

            foreach (Reporte2E r1 in pedido.CargarCantidadPClSCategoria())
            {
                foreach (Reporte2E r2 in reporte)
                {
                    if (r1.Categoria == r2.Categoria)
                    {
                        r2.Cantidad += r1.Cantidad;
                        break;
                    }
                }
            }

            chart.Titles[0].Text = "Cantidad de ventas por categoría de servicios";
            chart.Series["Series"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart.Series["Series"].IsValueShownAsLabel = true;

            foreach (Reporte2E r in reporte)
            {
                chart.Series["Series"].Points.AddXY(r.Categoria, r.Cantidad);
            }
        }

        private void Reporte8(DateTime dia)
        {
            LimpiarGrafico();
            List<string> reporte = new List<string>();

            foreach (string s in pedido.CargarPCOServiciosDia(dia))
            {
                reporte.Add(s);
            }

            foreach (string s in pedido.CargarPSServiciosDia(dia))
            {
                reporte.Add(s);
            }

            foreach (string s in pedido.CargarPCLServiciosDia(dia))
            {
                reporte.Add(s);
            }

            chart.Titles[0].Text = "Servicios solicitados en un día específico";
            chart.Series["Series"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart.Series["Series"].IsValueShownAsLabel = false;

            foreach (string r in reporte)
            {
                chart.Series["Series"].Points.AddXY(r, 1);
            }
        }

        private void Reporte9(DateTime dia)
        {
            LimpiarGrafico();
            List<Reporte9E> reporte = new List<Reporte9E>();

            foreach (UsuarioE u in usuario.CargarUsuario())
            {
                if (!u.Codigo.Substring(0,3).Equals("ADM") || !u.Codigo.Substring(0, 3).Equals("CAJ"))
                {
                    reporte.Add(new Reporte9E(u.Codigo, 0));
                }
            }

            foreach (string s in pedido.CargarPCOEmpleadosDia(dia))
            {
                foreach (Reporte9E r in reporte)
                {
                    if (s.Equals(r.CodigoUsuario))
                    {
                        r.RealizoVentas = 1;
                    }
                }
            }

            foreach (string s in pedido.CargarPSEmpleadosDia(dia))
            {
                foreach (Reporte9E r in reporte)
                {
                    if (s.Equals(r.CodigoUsuario))
                    {
                        r.RealizoVentas = 1;
                    }
                }
            }

            chart.Titles[0].Text = "Servicios solicitados en un día específico";
            chart.Series["Series"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart.Series["Series"].IsValueShownAsLabel = false;

            foreach (Reporte9E r in reporte)
            {
                chart.Series["Series"].Points.AddXY(r.CodigoUsuario, r.RealizoVentas);
            }
        }

        private void dtpDia_ValueChanged(object sender, EventArgs e)
        {
            if (cmbReportes.SelectedIndex == 7)
            {
                Reporte8(dtpDia.Value.Date);
            }
            else if (cmbReportes.SelectedIndex == 8)
            {
                dtpDia.Visible = true;
                Reporte9(dtpDia.Value.Date);
            }
        }

        private void Reporte4()
        {
            LimpiarGrafico();
            List<Reporte4E> reporte = new List<Reporte4E>();

            foreach (Reporte4E s in pedido.CargarCantidadPCOVendedor())
            {
                reporte.Add(s);
            }

            chart.Titles[0].Text = "Ventas de cada vendedor";
            chart.Series["Series"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart.Series["Series"].IsValueShownAsLabel = false;

            foreach (Reporte4E r in reporte)
            {
                chart.Series["Series"].Points.AddXY(r.CodigoVendedor, r.Cantiddad);
            }
        }
        private void Reporte5()
        {
            LimpiarGrafico();
            List<Reporte4E> reporte = new List<Reporte4E>();

            foreach (Reporte4E s in pedido.CargarCantidadPSSConstructorConductor())
            {
                reporte.Add(s);
            }

            chart.Titles[0].Text = "Servicios realizados por el constructor y conductor";
            chart.Series["Series"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart.Series["Series"].IsValueShownAsLabel = false;

            foreach (Reporte4E r in reporte)
            {
                chart.Series["Series"].Points.AddXY(r.CodigoVendedor, r.Cantiddad);
            }
        }

        private void Reporte6()
        {
            LimpiarGrafico();
            int cantidad = 0;

            foreach (int s in pedido.CargarCantidadPCOCliente())
            {
                cantidad += s;
            }
            foreach (int s in pedido.CargarCantidadPSSCliente())
            {
                cantidad += s;
            }
            foreach (int s in pedido.CargarCantidadPCLCliente())
            {
                cantidad += s;
            }

            chart.Titles[0].Text = "Servicios realizados por el constructor y conductor";
            chart.Series["Series"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart.Series["Series"].IsValueShownAsLabel = false;
            chart.Series["Series"].Points.AddXY("Clientes", cantidad);
            
        }

        private void Reporte7()
        {
            LimpiarGrafico();
            List<Reporte7E> reporte = new List<Reporte7E>();

            foreach (Reporte7E s in pedido.CargarCantidadSPCOCostos())
            { 
            
                reporte.Add(new Reporte7E (s.Total,s.IVA) );
            }
            foreach (Reporte7E s in pedido.CargarCantidadSPSOCostos())
            {

                reporte[0].Total+=s.Total;
                reporte[0].IVA += s.IVA;
            }
            foreach (Reporte7E s in pedido.CargarCantidadSPCLCostos())
            {

                reporte[0].Total += s.Total;
                reporte[0].IVA += s.IVA;
            }

            chart.Titles[0].Text = "Servicios realizados por el constructor y conductor";
            chart.Series["Series"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart.Series["Series"].IsValueShownAsLabel = false;
            chart.Series["Series"].Points.AddXY("Total", reporte[0].Total);
            chart.Series["Series"].Points.AddXY("IVA", reporte[0].IVA);

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}
