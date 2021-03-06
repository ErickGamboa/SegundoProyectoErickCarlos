﻿using Entities;
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
        private LTransporte tl;
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
            tl = new LTransporte();
            utilities = new UtilitiesL();
            lblCodigoVendedorT.Text = u.Codigo;
            lblNombreVendedorT.Text = u.Nombre;
            CargarCategoriaProducto();
            CargarCategoriaServicio();
            CargarProductos();
            CargarServicios();
            Limpiar();
            Activar(false);
            dgvCarritoComprasProductos.Columns[0].ValueType = typeof(ProductoE);
            dgvCarritoComprasServicios.Columns[0].ValueType = typeof(ServicioE);
        }

        /// <summary>
        /// Clears all of the tools that we used during a sell
        /// </summary>
        private void Limpiar()
        {
            txtBuscarProducto.Text = "";
            cboCategoriaProducto.SelectedItem = "PRODUCTOS";
            txtBuscarServicio.Text = "";
            cboCategoriaServicio.SelectedItem = "SERVICIOS";
            txtCedulaCliente.Text = "";
            lblSubtotalT.Text = "0.00";
            lblIVAT.Text = "0.00";
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

        /// <summary>
        /// Activates or deactivates the tools needed to make a sell at the moment they are needed
        /// </summary>
        /// <param name="activo">
        /// If true activates the tools from the Form
        /// </param>
        private void Activar(bool activo)
        {
            txtCedulaCliente.Enabled = activo;
            btnRealizarCompra.Enabled = activo;
            txtCodigoProducto.Enabled = activo;
            txtCantidadProducto.Enabled = activo;
            btnAgregarCarritoProducto.Enabled = activo;
            txtCodigoServicio.Enabled = activo;
            btnAgregarCarritoServicio.Enabled = activo;
            txtCantidadServicio.Enabled = activo;
            btnEliminarProducto.Enabled = activo;
            btnEliminarServicio.Enabled = activo;
        }

        /// <summary>
        /// Loads the products from the database
        /// </summary>
        private void CargarProductos()
        {
            try
            {
                if (cboCategoriaProducto.Text.Equals("PRODUCTOS"))
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cargando productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Loads the services from the database
        /// </summary>
        private void CargarServicios()
        {
            try
            {
                if (cboCategoriaServicio.Text.Equals("SERVICIOS"))
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cargando servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Loads the products categories
        /// </summary>
        private void CargarCategoriaProducto()
        {
            try
            {
                cboCategoriaProducto.Items.Clear();
                cboCategoriaProducto.Items.Add("PRODUCTOS");
                foreach (string i in prl.CargarCategoriaProducto())
                {
                    cboCategoriaProducto.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cargando categorías productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Loads the services categories
        /// </summary>
        private void CargarCategoriaServicio()
        {
            try
            {
                cboCategoriaServicio.Items.Clear();
                cboCategoriaServicio.Items.Add("SERVICIOS");
                foreach (string i in sel.CargarCategoriaServicio())
                {
                    cboCategoriaServicio.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cargando categorías servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Loads the products bought to the shopping cart
        /// </summary>
        private void CargarCarritoProductos()
        {
            try
            {
                dgvCarritoComprasProductos.Rows.Clear();
                foreach (PedidoCompletoProductoE p in productos)
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
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los productos al carrito de compras",
                    "Cargando carrito compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Loads the services bought to the shopping cart
        /// </summary>
        private void CargarCarritoServicios()
        {
            try
            {
                dgvCarritoComprasServicios.Rows.Clear();
                foreach (PedidoCompletoServicioE s in servicios)
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
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los servicios al carrito de compras",
                    "Cargando carrito compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Searches for an specific product
        /// </summary>
        /// <param name="id">
        /// int Id from the product that its being looked for
        /// </param>
        /// <returns>
        /// string with the name of the producto found
        /// </returns>
        public string BuscarProducto(int id)
        {
            try
            {
                foreach (ProductoE i in prl.CargarProducto("", ""))
                {
                    if (i.Id == id && i.Activo)
                    {
                        return i.Nombre;
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Buscando producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        /// <summary>
        /// Searches for an specific service
        /// </summary>
        /// <param name="id">
        /// int Id from the service that its being looked for
        /// </param>
        /// <returns>
        /// string with the name of the service found
        /// </returns>
        public string BuscarServicio(int id)
        {
            try
            {
                foreach (ServicioE i in sel.CargarServicio("", ""))
                {
                    if (i.Id == id && i.Activo)
                    {
                        return i.Nombre;
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Buscando servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        /// <summary>
        /// Loads the costs of the products and services bougth
        /// </summary>
        private void CargarCostos()
        {
            try
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
                iva = subtotal * (decimal)0.13;
                total = subtotal + iva;
                lblSubtotalT.Text = subtotal.ToString("0.00");
                lblIVAT.Text = iva.ToString("0.00");
                lblTotalT.Text = total.ToString("0.00");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los costos de los productos y servicios comprados",
                    "Cargando costos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            horaAtencion = DateTime.Now;
            Activar(true);
        }

        private void btoAgregarCarritoProducto_Click(object sender, EventArgs e)
        {
            try
            {
                pcp = new PedidoCompletoProductoE();
                foreach (ProductoE i in prl.CargarProducto("", ""))
                {
                    if (i.Id == int.Parse(txtCodigoProducto.Text))
                    {
                        if (i.Cantidad >= decimal.Parse(txtCantidadProducto.Text))
                        {
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btoAgregarCarritoServicio_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < tl.CargarTransportes().Count; i++)
                {
                    if (i == tl.CargarTransportes().Count - 1)
                    {
                        MessageBox.Show("No hay transportes disponibles", "Agregando Servicio",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    if (tl.CargarTransportes()[i].Activo == true)
                    {
                        pcs = new PedidoCompletoServicioE();
                        foreach (ServicioE j in sel.CargarServicio("", ""))
                        {
                            if (j.Id == int.Parse(txtCodigoServicio.Text))
                            {
                                pcs.IdVenta = int.Parse(txtCodigoServicio.Text);
                                pcs.Cantidad = decimal.Parse(txtCantidadServicio.Text);
                                pcs.PrecioTotal = j.Precio * pcs.Cantidad;

                                servicios.AddLast(pcs);

                                txtCodigoServicio.Clear();
                                lblNombreServicioT.Text = "";
                                txtCantidadServicio.Clear();

                                CargarCostos();
                                CargarCarritoServicios();
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btoRealizarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCedulaCliente.Text))
                {
                    throw new ArgumentNullException("Debe ingresar un número de cédula del cliente");
                }
                pc = new PedidoCompletoE();
                pc.CodigoVendedor = u.Codigo;
                pc.CedulaCliente = txtCedulaCliente.Text.Trim();
                pc.HoraAtencion = horaAtencion;
                pc.HoraVenta = DateTime.Now;
                pc.SubTotal = subtotal;
                pc.IVA = iva;
                pc.Total = total;
                pl.GuardarPedidoCompletoVendedor(pc);

                List<PedidoCompletoE> pedidos = pl.CargarPedidoCompleto();
                int last = pedidos.Count - 1;
                pc.Id = pedidos[last].Id;

                foreach (PedidoCompletoProductoE p in productos)
                {
                    foreach (ProductoE i in prl.CargarProducto("", ""))
                    {
                        if (p.IdVenta == i.Id)
                        {
                            i.Cantidad -= p.Cantidad;
                            break;
                        }
                    }
                    p.IdPedido = pc.Id;
                    pl.GuardarPedidoCompletoProducto(p);
                }

                foreach (PedidoCompletoServicioE p in servicios)
                {
                    p.IdPedido = pc.Id;
                    pl.GuardarPedidoCompletoServicio(p);
                }

                MessageBox.Show(pc.CedulaCliente + "\n" + DateTime.Now.TimeOfDay, "Notificación",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
                Activar(false);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Realizando Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Realizando Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eliminando Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eliminando Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtCodigoProducto.Text))
                {
                    lblNombreProductoT.Text = BuscarProducto(int.Parse(txtCodigoProducto.Text));
                }
                else
                {
                    lblNombreProductoT.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Código de producto incorrecto",
                        "Buscando Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoProducto.Clear();
            }
        }

        private void txtCodigoServicio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtCodigoServicio.Text))
                {
                    lblNombreServicioT.Text = BuscarServicio(int.Parse(txtCodigoServicio.Text));
                }
                else
                {
                    lblNombreServicioT.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Código de servicio incorrecto",
                        "Buscando Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoServicio.Clear();
            }
        }
    }
}
