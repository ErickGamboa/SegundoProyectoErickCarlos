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
    public partial class WindowClient : Form
    {
        private PedidoClienteE pc;
        private PedidoClienteProductoE pcp;
        private PedidoClienteServicioE pcs;
        private PedidoL pl;
        private LinkedList<PedidoClienteProductoE> productos;
        private LinkedList<PedidoClienteServicioE> servicios;

        private LProducto prl;
        private LServicio sel;
        private UtilitiesL utilities;
        private decimal subtotal;
        private decimal iva;
        private decimal total;

        public WindowClient()
        {
            InitializeComponent();
            pl = new PedidoL();
            productos = new LinkedList<PedidoClienteProductoE>();
            servicios = new LinkedList<PedidoClienteServicioE>();
            prl = new LProducto();
            sel = new LServicio();
            utilities = new UtilitiesL();
            iva = 13;
            CargarCategoriaProducto();
            CargarCategoriaServicio();
            CargarNombreProducto();
            CargarNombreServicio();
            Limpiar();
        }

        private void Limpiar()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            lblSubtotalT.Text = "0.00";
            lblIVAT.Text = iva + "%";
            lblTotalT.Text = "0.00";
            cboCategoriaProducto.SelectedIndex = 0;
            txtCantidadProducto.Clear();
            lblPrecioUnidadProductoT.Text = "0.00";
            lblTotalProductoT.Text = "0.00";
            cboCategoriaServicio.SelectedIndex = 0;
            txtCantidadServicio.Clear();
            lblPrecioUnidadServicioT.Text = "0.00";
            lblTotalServicioT.Text = "0.00";
            dgvCarritoComprasProductos.Rows.Clear();
            dgvCarritoComprasServicios.Rows.Clear();
        }

        private void CargarCategoriaProducto()
        {
            cboCategoriaProducto.Items.Clear();
            cboCategoriaProducto.DataSource = prl.CargarCategoriaProducto();
        }

        private void CargarCategoriaServicio()
        {
            cboCategoriaServicio.Items.Clear();
            cboCategoriaServicio.DataSource = sel.CargarCategoriaServicio();
        }

        private void CargarNombreProducto()
        {
            cboNombreProducto.Items.Clear();
            foreach (ProductoE i in prl.CargarProducto("", cboCategoriaProducto.Text))
            {
                cboNombreProducto.Items.Add(i.Nombre);
            }
        }

        private void CargarNombreServicio()
        {
            cboNombreServicio.Items.Clear();
            foreach (ServicioE i in sel.CargarServicio("", cboCategoriaServicio.Text))
            {
                cboNombreServicio.Items.Add(i.Nombre);
            }
        }

        private void CargarCarritoProductos()
        {
            dgvCarritoComprasProductos.Rows.Clear();
            foreach (PedidoClienteProductoE p in productos)
            {
                foreach (ProductoE i in prl.CargarProducto("", ""))
                {
                    if (i.Id == p.IdVenta)
                    {
                        dgvCarritoComprasProductos.Rows.Add(p, i.Nombre, i.Categoria, i.Descripcion,
                            i.Precio, p.Cantidad, p.PrecioTotal);
                        break;
                    }
                }
            }
        }

        private void CargarCarritoServicios()
        {
            dgvCarritoComprasServicios.Rows.Clear();
            foreach (PedidoClienteServicioE s in servicios)
            {
                foreach (ServicioE i in sel.CargarServicio("", ""))
                {
                    if (i.Id == s.IdVenta)
                    {
                        dgvCarritoComprasServicios.Rows.Add(s, i.Nombre, i.Categoria, i.Descripcion,
                            i.Precio, s.Cantidad, s.PrecioTotal);
                        break;
                    }
                }
            }
        }

        private void CargarCostosProducto()
        {
            decimal totalP = prl.CargarProducto(cboNombreProducto.Text, cboCategoriaProducto.Text)[0].Precio;
            lblPrecioUnidadProductoT.Text = totalP.ToString("0.00");
        }

        private void CargarCostosServicio()
        {
            decimal totalS = sel.CargarServicio(cboNombreServicio.Text, cboCategoriaServicio.Text)[0].Precio;
            lblPrecioUnidadServicioT.Text = totalS.ToString("0.00");
        }

        private void CargarCostosTotales()
        {
            subtotal = 0;
            foreach (PedidoClienteProductoE p in productos)
            {
                subtotal += p.PrecioTotal;
            }
            foreach (PedidoClienteServicioE s in servicios)
            {
                subtotal += s.PrecioTotal;
            }
            iva = subtotal * (decimal)0.13;
            total = subtotal + iva;
            lblSubtotalT.Text = subtotal.ToString("0.00");
            lblIVAT.Text = iva.ToString("0.00");
            lblTotalT.Text = total.ToString("0.00");
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            txtCedula.SelectionStart = 0;
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                txtCedula.Text = "102340567";
                txtCedula.ForeColor = Color.Gray;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCedula.ForeColor = Color.Black;
            utilities.SoloNumeros(e);
        }

        private void cboNombreProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarCostosProducto();
        }

        private void btoAgregarCarritoProducto_Click(object sender, EventArgs e)
        {
            pcp = new PedidoClienteProductoE();
            ProductoE p = prl.CargarProducto(cboNombreProducto.Text, cboCategoriaProducto.Text)[0];
            if (p.Cantidad >= decimal.Parse(txtCantidadProducto.Text))
            {
                pcp.IdVenta = p.Id;
                pcp.Cantidad = decimal.Parse(txtCantidadProducto.Text);
                pcp.PrecioTotal = p.Precio * pcp.Cantidad;

                productos.AddLast(pcp);

                cboCategoriaProducto.SelectedIndex = 0;
                txtCantidadProducto.Clear();
                lblPrecioUnidadProductoT.Text = "0.00";
                lblTotalProductoT.Text = "0.00";

                CargarCostosTotales();
                CargarCarritoProductos();
            }
            else
            {
                MessageBox.Show("La cantidad solicitada es mayor que\nla cantidad disponible ("
                    + p.Cantidad + ").", "Agregando Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cboCategoriaServicio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarNombreServicio();
        }

        private void cboNombreServicio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarCostosProducto();
        }

        private void btoAgregarCarritoServicio_Click(object sender, EventArgs e)
        {
            pcs = new PedidoClienteServicioE();
            ServicioE s = sel.CargarServicio(cboNombreServicio.Text, cboCategoriaServicio.Text)[0];
            pcs.IdVenta = s.Id;
            pcs.Cantidad = int.Parse(txtCantidadServicio.Text);
            pcs.PrecioTotal = s.Precio * pcp.Cantidad;

            servicios.AddLast(pcs);

            cboCategoriaServicio.SelectedIndex = 0;
            txtCantidadServicio.Clear();
            lblPrecioUnidadServicioT.Text = "0.00";
            lblTotalServicioT.Text = "0.00";

            CargarCostosTotales();
            CargarCarritoServicios();
        }

        private void btoLogOut_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btoEliminarProducto_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el producto seleccionado?",
                "Eliminando Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (productos.Remove((PedidoClienteProductoE)dgvCarritoComprasProductos.CurrentRow.Cells[0].Value))
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
            CargarCostosTotales();
            CargarCarritoProductos();
        }

        private void btoEliminarServicio_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el servicio seleccionado?",
                "Eliminando Servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (servicios.Remove((PedidoClienteServicioE)dgvCarritoComprasServicios.CurrentRow.Cells[0].Value))
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
            CargarCostosTotales();
            CargarCarritoServicios();
        }

        private void cboCategoriaProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarNombreProducto();
        }

        private void txtCantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilities.SoloNumeros(e);
        }

        private void txtCantidadProducto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCantidadProducto.Text))
            {
                lblTotalProductoT.Text = (prl.CargarProducto(cboNombreProducto.Text, cboCategoriaProducto.Text)[0].Precio
                        * decimal.Parse(txtCantidadProducto.Text)).ToString(); 
            }
        }

        private void txtCantidadServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilities.SoloNumeros(e);
        }

        private void txtCantidadServicio_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCantidadServicio.Text))
            {
                lblTotalServicioT.Text = (sel.CargarServicio(cboNombreServicio.Text, cboCategoriaServicio.Text)[0].Precio
                        * decimal.Parse(txtCantidadServicio.Text)).ToString(); 
            }
        }

        private void btoRealizarCompra_Click(object sender, EventArgs e)
        {
            pc = new PedidoClienteE();
            pc.CedulaCliente = txtCedula.Text.Trim();
            pc.NombreCliente = txtNombre.Text.Trim() + " " + txtApellido.Text.Trim();
            pc.Fecha = DateTime.Now;
            pc.SubTotal = subtotal;
            pc.IVA = iva;
            pc.Total = total;
            pc.Estado = "PENDIENTE";
            pl.GuardarPedidoClienteCliente(pc);

            List<PedidoClienteE> pedidos = pl.CargarPedidoCliente();
            int last = pedidos.Count - 1;
            pc.Id = pedidos[last].Id;

            foreach (PedidoClienteProductoE p in productos)
            {
                p.IdPedido = pc.Id;
                pl.GuardarPedidoClienteProducto(p);
            }

            foreach (PedidoClienteServicioE p in servicios)
            {
                p.IdPedido = pc.Id;
                pl.GuardarPedidoClienteServicio(p);
            }

            Limpiar();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilities.SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilities.SoloLetras(e);
        }
    }
}
