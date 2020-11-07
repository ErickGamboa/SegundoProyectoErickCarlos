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
    public partial class WindowSeller : Form
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

        public WindowSeller(UsuarioE u)
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
            dgvCarritoComprasProductos.Rows.Clear();
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
            btnEliminarProducto.Enabled = activo;
        }

        private void CargarCarritoProductos()
        {
            dgvCarritoComprasProductos.Rows.Clear();
            foreach (PedidoCompletoProductoE p in productos)
            {
                dgvCarritoComprasProductos.Rows.Add(p, p.Cantidad, p.PrecioTotal);
            }
            dgvCarritoComprasProductos.Columns[0].Visible = false;
        }

        private void CargarCostos()
        {
            subtotal = 0;
            foreach (PedidoCompletoProductoE p in productos)
            {
                subtotal += p.PrecioTotal;
            }
            foreach (PedidoCompletoServicioE s in servicios)
            {
                subtotal += s.PrecioTotal;
            }
            total = subtotal * (iva / 100);
            lblSubtotalT.Text = subtotal.ToString();
            lblTotalT.Text = total.ToString();
        }

        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            horaAtencion = DateTime.Now;
            Activar(true);
        }

        private void btoAgregarCarritoProducto_Click(object sender, EventArgs e)
        {
            pcp = new PedidoCompletoProductoE();
            pcp.IdPedido = pc.Id;
            pcp.IdVenta = int.Parse(txtCodigoProducto.Text);
            pcp.Cantidad = int.Parse(txtCantidadProducto.Text);

        }

        private void btoAgregarCarritoServicio_Click(object sender, EventArgs e)
        {
            pcs = new PedidoCompletoServicioE();
            pcs.IdPedido = pc.Id;
            pcs.IdVenta = int.Parse(txtCodigoServicio.Text);
            pcs.Cantidad = int.Parse(txtCantidadServicio.Text);
            
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

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el producto seleccionado?",
                "Eliminando Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (productos.Remove((PedidoCompletoProductoE)dgvCarritoComprasProductos.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Producto eliminado.", "Eliminando Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto seleccionado.\nInténtelo nuevamente.",
                        "Eliminando Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            CargarCarritoProductos();
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el servicio seleccionado?",
                "Eliminando Servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (servicios.Remove((PedidoCompletoServicioE)dgvCarritoComprasServicios.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Servicio eliminado.", "Eliminando Servicio",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el servicio seleccionado.\nInténtelo nuevamente.",
                        "Eliminando Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            CargarCarritoProductos();
        }
    }
}
