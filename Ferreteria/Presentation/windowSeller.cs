using Entities;
using Logic;
using Microsoft.SqlServer.Server;
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
        private LProducto prl;
        private LServicio sel;
        private UtilitiesL utilities;
        private DateTime horaAtencion;
        private decimal subtotal;
        private decimal iva;
        private decimal total;

        public WindowSeller(UsuarioE u)
        {
            InitializeComponent();
            pl = new PedidoL();
            productos = new LinkedList<PedidoCompletoProductoE>();
            servicios = new LinkedList<PedidoCompletoServicioE>();
            this.u = u;
            prl = new LProducto();
            sel = new LServicio();
            utilities = new UtilitiesL();
            iva = 13;
            lblCodigoVendedorT.Text = u.Codigo;
            lblNombreVendedorT.Text = u.Nombre;
            CargarProductos();
            CargarServicios();
            CargarCategoriaProducto();
            CargarCategoriaServicio();
            Limpiar();
            Activar(false);
            dgvCarritoComprasProductos.Columns[0].ValueType = typeof(ProductoE);
            dgvCarritoComprasServicios.Columns[0].ValueType = typeof(ServicioE);
        }

        private void Limpiar()
        {
            txtBuscarProducto.Text = "";
            cboCategoriaProducto.SelectedItem = "PRODUCTOS";
            txtBuscarServicio.Text = "";
            cboCategoriaServicio.SelectedItem = "SERVICIOS";
            txtCedulaCliente.Text = "";
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
            dgvCarritoComprasServicios.Rows.Clear();
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
            btnEliminarServicio.Enabled = activo;
        }

        private void CargarProductos()
        {
            if (cboCategoriaProducto.SelectedItem == "PRODUCTOS")
            {
                List<ProductoE> lstpro = prl.CargarProducto(txtBuscarProducto.Text, "");
                dgvConsultaProducto.DataSource = lstpro;
            }
            else
            {
                List<ProductoE> lstpro = prl.CargarProducto(txtBuscarProducto.Text, cboCategoriaProducto.Text);
                dgvConsultaProducto.DataSource = lstpro;
            }
        }

        private void CargarServicios()
        {
            if (cboCategoriaServicio.SelectedItem == "SERVICIOS")
            {
                List<ServicioE> lstser = sel.CargarServicio(txtBuscarServicio.Text, "");
                dgvConsultaServicio.DataSource = lstser;
            }
            else
            {
                List<ServicioE> lstser = sel.CargarServicio(txtBuscarServicio.Text, cboCategoriaServicio.Text);
                dgvConsultaServicio.DataSource = lstser;
            }
        }

        private void CargarCategoriaProducto()
        {
            cboCategoriaProducto.Items.Clear();
            cboCategoriaProducto.Items.Add("PRODUCTOS");
            foreach (string i in prl.CargarCategoriaProducto())
            {
                cboCategoriaProducto.Items.Add(i);
            }
        }

        private void CargarCategoriaServicio()
        {
            cboCategoriaServicio.Items.Clear();
            cboCategoriaServicio.Items.Add("SERVICIOS");
            foreach (string i in sel.CargarCategoriaServicio())
            {
                cboCategoriaServicio.Items.Add(i);
            }
        }

        private void CargarCarritoProductos()
        {
            dgvCarritoComprasProductos.Rows.Clear();
            foreach (PedidoCompletoProductoE p in productos)
            {
                foreach (ProductoE i in prl.CargarProducto("", ""))
                {
                    if (p.IdVenta == i.Id)
                    {
                        dgvCarritoComprasProductos.Rows.Add(p, i.Id, i.Nombre, i.Categoria, i.Descripcion,
                            i.Precio, p.Cantidad, p.PrecioTotal);
                        break;
                    }
                }
            }
        }

        private void CargarCarritoServicios()
        {
            dgvCarritoComprasServicios.Rows.Clear();
            foreach (PedidoCompletoServicioE s in servicios)
            {
                foreach (ServicioE i in sel.CargarServicio("",""))
                {
                    if (s.IdVenta == i.Id)
                    {
                        dgvCarritoComprasServicios.Rows.Add(s, i.Id, i.Nombre, i.Categoria, i.Descripcion,
                            i.Precio, s.Cantidad, s.PrecioTotal);
                        break;
                    }
                }
            }
        }

        public string BuscarProducto(int id)
        {
            foreach (ProductoE i in prl.CargarProducto("", ""))
            {
                if (i.Id == id)
                {
                    return i.Nombre;
                }
            }
            return "";
        }

        public string BuscarServicio(int id)
        {
            foreach (ServicioE i in sel.CargarServicio("", ""))
            {
                if (i.Id == id)
                {
                    return i.Nombre;
                }
            }
            return "";
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
            total = subtotal * (1 + iva / 100);
            lblSubtotalT.Text = subtotal.ToString("0.00");
            lblTotalT.Text = total.ToString("0.00");
        }

        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            horaAtencion = DateTime.Now;
            Activar(true);
        }

        private void btoAgregarCarritoProducto_Click(object sender, EventArgs e)
        {
            foreach (ProductoE i in prl.CargarProducto("", ""))
            {
                if (i.Id == int.Parse(txtCodigoProducto.Text))
                {
                    if (i.Cantidad >= int.Parse(txtCantidadProducto.Text))
                    {
                        pcp = new PedidoCompletoProductoE();
                        pcp.IdPedido = 0;
                        pcp.IdVenta = int.Parse(txtCodigoProducto.Text);
                        pcp.Cantidad = decimal.Parse(txtCantidadProducto.Text);
                        pcp.PrecioTotal = i.Precio * pcp.Cantidad;

                        productos.AddLast(pcp);

                        txtCodigoProducto.Clear();
                        lblNombreProductoT.Text = "";
                        txtCantidadProducto.Clear();

                        CargarCostos();
                        CargarCarritoProductos();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("La cantidad solicitada es mayor que\nla cantidad disponible ("
                            + i.Cantidad + ").", "Agregando Producto",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btoAgregarCarritoServicio_Click(object sender, EventArgs e)
        {
            foreach (ServicioE i in sel.CargarServicio("",""))
            {
                if (i.Id == int.Parse(txtCodigoServicio.Text))
                {
                    pcs = new PedidoCompletoServicioE();
                    pcs.IdPedido = pc.Id;
                    pcs.IdVenta = int.Parse(txtCodigoServicio.Text);
                    pcs.Cantidad = decimal.Parse(txtCantidadServicio.Text);
                    pcs.PrecioTotal = i.Precio * pcs.Cantidad;

                    servicios.AddLast(pcs);

                    txtCodigoServicio.Clear();
                    lblNombreServicioT.Text = "";
                    txtCantidadServicio.Clear();

                    CargarCostos();
                    CargarCarritoServicios();
                }
            }
        }

        private void btoRealizarCompra_Click(object sender, EventArgs e)
        {
            pc = new PedidoCompletoE();
            pc.CodigoVendedor = u.Codigo;
            pc.CedulaCliente = txtCedulaCliente.Text;
            pc.HoraAtencion = horaAtencion;
            pc.HoraVenta = DateTime.Now;
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
            CargarProductos();
        }

        private void cboCategoriaProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarProductos();
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
            CargarServicios();
        }

        private void cboCategoriaServicio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarServicios();
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
            CargarCostos();
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
            CargarCostos();
            CargarCarritoServicios();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodigoProducto.Text))
            {
                lblNombreProductoT.Text = BuscarProducto(int.Parse(txtCodigoProducto.Text));
            }
        }

        private void btnBuscarServicio_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodigoServicio.Text))
            {
                lblNombreServicioT.Text = BuscarServicio(int.Parse(txtCodigoServicio.Text)); 
            }
        }
    }
}
