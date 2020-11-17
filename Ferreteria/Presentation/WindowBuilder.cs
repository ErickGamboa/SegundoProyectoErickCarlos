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
    public partial class WindowBuilder : Form
    {
        private PedidoSoloServicioE ps;
        private PedidoSoloServicioServicioE pss;
        private PedidoL pl;
        private LinkedList<PedidoSoloServicioServicioE> servicios;

        private UsuarioE u;
        private LProducto prl;
        private LServicio sel;
        private LTransporte tl;
        private UtilitiesL utilities;
        private decimal subtotal;
        private decimal iva;
        private decimal total;

        public WindowBuilder(UsuarioE u)
        {
            InitializeComponent();
            pl = new PedidoL();
            servicios = new LinkedList<PedidoSoloServicioServicioE>();
            this.u = u;
            prl = new LProducto();
            sel = new LServicio();
            tl = new LTransporte();
            utilities = new UtilitiesL();
            lblCodigoConstructorT.Text = u.Codigo;
            lblNombreConstructorT.Text = u.Nombre;
            CargarCategoria();
            CargarServicios();
            Limpiar();
            Activar(false);
            dgvCarritoCompras.Columns[0].ValueType = typeof(ServicioE);
            dgvPedidos.Columns[0].ValueType = typeof(object);
            CargarPedidos();
        }

        /// <summary>
        /// Clears all of the tools that we used during a sell
        /// </summary>
        private void Limpiar()
        {
            txtBuscarServicio.Text = "";
            cboCategoria.SelectedItem = "SERVICIOS";
            txtCedulaCliente.Text = "";
            lblSubtotalT.Text = "0.00";
            lblIVAT.Text = "0.00";
            lblTotalT.Text = "0.00";
            txtCodigoServicio.Clear();
            lblNombreServicioT.Text = "";
            txtCantidadServicio.Clear();
            dgvCarritoCompras.Rows.Clear();
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
            btoRealizarCompra.Enabled = activo;
            txtCodigoServicio.Enabled = activo;
            btoAgregarCarritoServicio.Enabled = activo;
            txtCantidadServicio.Enabled = activo;
            btoEliminar.Enabled = activo;
        }

        /// <summary>
        /// Loads the services from the database
        /// </summary>
        private void CargarServicios()
        {
            try
            {
                if (cboCategoria.Text.Equals("SERVICIOS"))
                {
                    List<ServicioE> lstser = sel.CargarServicio(txtBuscarServicio.Text, "");
                    dgvConsultaServicio.DataSource = lstser;
                }
                else
                {
                    List<ServicioE> lstser = sel.CargarServicio(txtBuscarServicio.Text, cboCategoria.Text);
                    dgvConsultaServicio.DataSource = lstser;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cargando servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Loads the services categories
        /// </summary>
        private void CargarCategoria()
        {
            try
            {
                cboCategoria.Items.Clear();
                cboCategoria.Items.Add("SERVICIOS");
                foreach (string i in sel.CargarCategoriaServicio())
                {
                    cboCategoria.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cargando categorías servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Loads the services bought to the shopping cart
        /// </summary>
        private void CargarCarritoServicios()
        {
            try
            {
                dgvCarritoCompras.Rows.Clear();
                foreach (PedidoSoloServicioServicioE s in servicios)
                {
                    foreach (ServicioE i in sel.CargarServicio("", ""))
                    {
                        if (i.Id == s.IdVenta)
                        {
                            dgvCarritoCompras.Rows.Add(s, i.Nombre, i.Categoria, i.Descripcion,
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
                foreach (PedidoSoloServicioServicioE s in servicios)
                {
                    subtotal += s.PrecioTotal;
                }
                iva = subtotal * (decimal)0.13;
                total = subtotal + iva;
                total = subtotal * (1 + iva / 100);
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

        /// <summary>
        /// Loads the orders to the store room section
        /// </summary>
        private void CargarPedidos()
        {
            try
            {
                dgvPedidos.Rows.Clear();
                foreach (PedidoCompletoE p in pl.CargarPedidoCompleto())
                {
                    if (p.HoraSalidaBodega == null)
                    {
                        dgvPedidos.Rows.Add(p, "COMPLETO", p.Id, p.HoraRecibidoBodega, p.HoraSalidaBodega);
                    }
                }
                foreach (PedidoSoloServicioE p in pl.CargarPedidoSoloServicio())
                {
                    if (p.HoraSalidaBodega == null)
                    {
                        dgvPedidos.Rows.Add(p, "SOLO SERVICIO", p.Id, p.HoraRecibidoBodega, p.HoraSalidaBodega);
                    }
                }
                foreach (PedidoClienteE p in pl.CargarPedidoCliente())
                {
                    if (p.HoraSalidaBodega == null)
                    {
                        dgvPedidos.Rows.Add(p, "CLIENTE", p.Id, p.HoraRecibidoBodega, p.HoraSalidaBodega);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cargando pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Loads the sells to the store room section
        /// </summary>
        private void CargarVentas()
        {
            try
            {
                dgvVentas.Rows.Clear();
                if (dgvPedidos.SelectedRows.Count > 0 && dgvPedidos.CurrentRow != null)
                {
                    if (dgvPedidos.CurrentRow.Cells[1].Value.Equals("COMPLETO"))
                    {
                        foreach (PedidoCompletoProductoE p in pl.CargarPedidoCompletoProducto())
                        {
                            if (p.IdPedido == (int)dgvPedidos.CurrentRow.Cells[2].Value)
                            {
                                foreach (ProductoE i in prl.CargarProducto("", ""))
                                {
                                    if (i.Id == p.IdVenta)
                                    {
                                        dgvVentas.Rows.Add("PRODUCTO", i.Id, i.Nombre, i.Categoria, i.Descripcion, p.Cantidad);
                                        break;
                                    }
                                }
                            }
                        }
                        foreach (PedidoCompletoServicioE s in pl.CargarPedidoCompletoServicio())
                        {
                            if (s.IdPedido == (int)dgvPedidos.CurrentRow.Cells[2].Value)
                            {
                                foreach (ServicioE i in sel.CargarServicio("", ""))
                                {
                                    if (i.Id == s.IdVenta)
                                    {
                                        dgvVentas.Rows.Add("SERVICIO", i.Id, i.Nombre, i.Categoria, i.Descripcion, s.Cantidad);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    else if (dgvPedidos.CurrentRow.Cells[1].Value.Equals("SOLO SERVICIO"))
                    {
                        foreach (PedidoSoloServicioServicioE s in pl.CargarPedidoSoloServicioServicio())
                        {
                            if (s.IdPedido == (int)dgvPedidos.CurrentRow.Cells[2].Value)
                            {
                                foreach (ServicioE i in sel.CargarServicio("", ""))
                                {
                                    if (i.Id == s.IdVenta)
                                    {
                                        dgvVentas.Rows.Add("SERVICIO", i.Id, i.Nombre, i.Categoria, i.Descripcion, s.Cantidad);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    else if (dgvPedidos.CurrentRow.Cells[1].Value.Equals("CLIENTE"))
                    {
                        foreach (PedidoClienteProductoE p in pl.CargarPedidoClienteProducto())
                        {
                            if (p.IdPedido == (int)dgvPedidos.CurrentRow.Cells[2].Value)
                            {
                                foreach (ProductoE i in prl.CargarProducto("", ""))
                                {
                                    if (i.Id == p.IdVenta)
                                    {
                                        dgvVentas.Rows.Add("PRODUCTO", i.Id, i.Nombre, i.Categoria, i.Descripcion, p.Cantidad);
                                        break;
                                    }
                                }
                            }
                        }
                        foreach (PedidoClienteServicioE s in pl.CargarPedidoClienteServicio())
                        {
                            if (s.IdPedido == (int)dgvPedidos.CurrentRow.Cells[2].Value)
                            {
                                foreach (ServicioE i in sel.CargarServicio("", ""))
                                {
                                    if (i.Id == s.IdVenta)
                                    {
                                        dgvVentas.Rows.Add("SERVICIO", i.Id, i.Nombre, i.Categoria, i.Descripcion, s.Cantidad);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cargando pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void cboCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarServicios();
        }

        private void btoLogOut_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btoNuevaOrden_Click(object sender, EventArgs e)
        {
            Activar(true);
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
                        pss = new PedidoSoloServicioServicioE();
                        foreach (ServicioE j in sel.CargarServicio("", ""))
                        {
                            if (j.Id == int.Parse(txtCodigoServicio.Text))
                            {
                                pss.IdVenta = int.Parse(txtCodigoServicio.Text);
                                pss.Cantidad = decimal.Parse(txtCantidadServicio.Text);
                                pss.PrecioTotal = j.Precio * pss.Cantidad;

                                servicios.AddLast(pss);

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
                if (string.IsNullOrWhiteSpace(txtCedulaCliente.Text))
                {
                    throw new ArgumentNullException("Debe ingresar las observaciones");
                }
                ps = new PedidoSoloServicioE();
                ps.CedulaCliente = txtCedulaCliente.Text.Trim();
                ps.CodigoUsuario = u.Codigo;
                ps.Observaciones = txtObservaciones.Text.Trim().ToUpper();
                ps.SubTotal = subtotal;
                ps.IVA = iva;
                ps.Total = total;
                pl.GuardarPedidoSoloServicioConstructor(ps);

                List<PedidoSoloServicioE> pedidos = pl.CargarPedidoSoloServicio();
                int last = pedidos.Count - 1;
                ps.Id = pedidos[last].Id;

                foreach (PedidoSoloServicioServicioE p in servicios)
                {
                    p.IdPedido = ps.Id;
                    pl.GuardarPedidoSoloServicioServicio(p);
                }

                MessageBox.Show(ps.CedulaCliente + "\n" + DateTime.Now.TimeOfDay, "Notificación",
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

        private void btoEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el servicio seleccionado?",
                        "Eliminando Servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (servicios.Remove((PedidoSoloServicioServicioE)dgvCarritoCompras.CurrentRow.Cells[0].Value))
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

        private void btoRecibido_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPedidos.CurrentRow.Cells[1].Value.Equals("COMPLETO"))
                {
                    PedidoCompletoE p = (PedidoCompletoE)dgvPedidos.CurrentRow.Cells[0].Value;
                    p.HoraRecibidoBodega = dtpRecibido.Value;
                    pl.GuardarPedidoCompletoBodega(p);
                }
                else if (dgvPedidos.CurrentRow.Cells[1].Value.Equals("SOLO SERVICIO"))
                {
                    PedidoSoloServicioE p = (PedidoSoloServicioE)dgvPedidos.CurrentRow.Cells[0].Value;
                    p.HoraRecibidoBodega = dtpRecibido.Value;
                    pl.GuardarPedidoSoloServicioBodega(p);
                }
                else if (dgvPedidos.CurrentRow.Cells[1].Value.Equals("CLIENTE"))
                {
                    PedidoClienteE p = (PedidoClienteE)dgvPedidos.CurrentRow.Cells[0].Value;
                    p.HoraRecibidoBodega = dtpRecibido.Value;
                    pl.GuardarPedidoClienteBodega(p);
                }
                CargarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Hora Recibido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btoSalida_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPedidos.CurrentRow.Cells[1].Value.Equals("COMPLETO"))
                {
                    PedidoCompletoE p = (PedidoCompletoE)dgvPedidos.CurrentRow.Cells[0].Value;
                    p.HoraSalidaBodega = dtpSalida.Value;
                    pl.GuardarPedidoCompletoBodega(p);
                }
                else if (dgvPedidos.CurrentRow.Cells[1].Value.Equals("SOLO SERVICIO"))
                {
                    PedidoSoloServicioE p = (PedidoSoloServicioE)dgvPedidos.CurrentRow.Cells[0].Value;
                    p.HoraSalidaBodega = dtpSalida.Value;
                    pl.GuardarPedidoSoloServicioBodega(p);
                }
                else if (dgvPedidos.CurrentRow.Cells[1].Value.Equals("CLIENTE"))
                {
                    PedidoClienteE p = (PedidoClienteE)dgvPedidos.CurrentRow.Cells[0].Value;
                    p.HoraSalidaBodega = dtpSalida.Value;
                    p.Estado = "ENVIADO";
                    pl.GuardarPedidoClienteBodega(p);
                }
                CargarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Hora Salida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPedidos_SelectionChanged(object sender, EventArgs e)
        {
            CargarVentas();
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
