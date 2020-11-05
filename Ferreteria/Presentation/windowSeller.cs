using Entities;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class windowSeller : Form
    {
        private PedidoCompletoE pc;
        private PedidoCompletoProductoE pcp;
        private PedidoCompletoServicioE pcs;
        private PedidoL pl;
        private LinkedList<PedidoCompletoProductoE> productos;
        private LinkedList<PedidoCompletoServicioE> servicios;

        private UsuarioE u;
        private UtilitiesL utilities;
        private DateTime horaAtencion;
        private DateTime horaVenta;
        private double subtotal;
        private double iva;
        private double total;

        public windowSeller(UsuarioE u)
        {
            InitializeComponent();
            this.u = u;
            utilities = new UtilitiesL();
            iva = 13;
            Limpiar();
            Activar(false);
            lblCodigoVendedorT.Text = u.Codigo;
            lblNombreVendedorT.Text = u.Nombre.Substring(0, 22);
        }

        private void Limpiar()
        {
            txtBuscarProducto.Clear();
            cboCategoriaProducto.SelectedIndex = 0;
            txtBuscarServicio.Clear();
            cboCategoriaServicio.SelectedIndex = 0;
            txtCedulaCliente.Clear();
            lblSubtotalT.Text = "0.00";
            lblIVAT.Text = iva + "%";
            lblTotalT.Text = "0.00";
            txtCodigoProducto.Clear();
            lblNombreProductoT.Text = "";
            txtCantidadProducto.Clear();
            txtCodigoServicio.Clear();
            lblNombreServicioT.Text = "";
            txtCantidadServicio.Clear();
            dgvCarritoCompras.Rows.Clear();
        }

        private void Activar(bool activo)
        {
            txtCedulaCliente.Enabled = activo;
            btnRealizarCompra.Enabled = activo;
            txtCodigoProducto.Enabled = activo;
            btnBuscarProducto.Enabled = activo;
            txtCantidadProducto.Enabled = activo;
            btnAgregarCarritoProducto.Enabled = activo;
            btnBuscarServicio.Enabled = activo;
            txtCodigoServicio.Enabled = activo;
            btnAgregarCarritoServicio.Enabled = activo;
            txtCantidadServicio.Enabled = activo;
            btnEliminar.Enabled = activo;
        }

        private void CargarCarrito()
        {
            dgvCarritoCompras.Rows.Clear();
            foreach (PedidoCompletoProductoE p in productos)
            {

            }
        }

        private void CargarCostos()
        {

        }

        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            horaAtencion = DateTime.Now;
            Activar(true);
        }

        private void btoAgregarCarritoProducto_Click(object sender, EventArgs e)
        {
            pcp = new PedidoCompletoProductoE();
            
        }

        private void btoAgregarCarritoServicio_Click(object sender, EventArgs e)
        {

        }

        private void btoRealizarCompra_Click(object sender, EventArgs e)
        {
            horaVenta = DateTime.Now;
            pc = new PedidoCompletoE();
            pc.CodigoVendedor = u.Codigo;
            pc.CedulaCliente = txtCedulaCliente.Text;
            pc.HoraAtencion = horaAtencion;
            pc.HoraVenta = horaVenta;
            pc.SubTotal = subtotal;
            pc.IVA = iva;
            pc.Total = total;
            pl.GuardarPedidoCompletoVendedor(pc);
            Limpiar();
            Activar(false);
        }

        private void btoLogOut_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarProducto_Enter(object sender, EventArgs e)
        {
            txtBuscarProducto.SelectionStart = 0;
        }

        private void txtBuscarProducto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarProducto.Text))
            {
                txtBuscarProducto.Text = "Nombre Producto";
                txtBuscarProducto.ForeColor = Color.Gray;
            }
        }

        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBuscarProducto.ForeColor = Color.Black;
            utilities.SoloLetras(e);
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboCategoriaProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void txtBuscarServicio_Enter(object sender, EventArgs e)
        {
            txtBuscarServicio.SelectionStart = 0;
        }

        private void txtBuscarServicio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarServicio.Text))
            {
                txtBuscarServicio.Text = "Nombre Servicio";
                txtBuscarServicio.ForeColor = Color.Gray;
            }
        }

        private void txtBuscarServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBuscarServicio.ForeColor = Color.Black;
            utilities.SoloLetras(e);
        }

        private void txtBuscarServicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboCategoriaServicio_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void txtCedulaCliente_Enter(object sender, EventArgs e)
        {
            txtCedulaCliente.SelectionStart = 0;
        }

        private void txtCedulaCliente_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCedulaCliente.Text))
            {
                txtCedulaCliente.Text = "102340567";
                txtCedulaCliente.ForeColor = Color.Gray;
            }
        }

        private void txtCedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCedulaCliente.ForeColor = Color.Black;
            utilities.SoloNumeros(e);
        }

        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilities.SoloNumeros(e);
        }

        private void txtCantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilities.SoloNumeros(e);
        }

        private void txtCodigoServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilities.SoloNumeros(e);
        }

        private void txtCantidadServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilities.SoloNumeros(e);
        }
    }
}
