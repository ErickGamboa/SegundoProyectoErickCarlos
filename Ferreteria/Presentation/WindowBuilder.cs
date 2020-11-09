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
            utilities = new UtilitiesL();
            iva = 13;
            lblCodigoConstructorT.Text = u.Codigo;
            lblNombreConstructorT.Text = u.Nombre;
            CargarServicios();
            CargarCategoria();
            Limpiar();
            Activar(false);
            dgvPedidos.Columns[0].ValueType = typeof(object);
            CargarPedidos();
        }

        private void Limpiar()
        {
            txtBuscarServicio.Text = "";
            cboCategoria.SelectedItem = "SERVICIOS";
            txtCedulaCliente.Text = "";
            lblSubtotalT.Text = "0.00";
            lblIVAT.Text = iva + "%";
            lblTotalT.Text = "0.00";
            txtCodigoServicio.Clear();
            lblNombreServicioT.Text = "";
            txtCantidadServicio.Clear();
            dgvCarritoCompras.Rows.Clear();
        }

        private void Activar(bool activo)
        {
            txtCedulaCliente.Enabled = activo;
            btoRealizarCompra.Enabled = activo;
            btoBuscarServicio.Enabled = activo;
            txtCodigoServicio.Enabled = activo;
            btoAgregarCarritoServicio.Enabled = activo;
            txtCantidadServicio.Enabled = activo;
            btoEliminar.Enabled = activo;
        }

        private void CargarServicios()
        {
            if (cboCategoria.SelectedItem == "SERVICIOS")
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

        private void CargarCategoria()
        {
            cboCategoria.Items.Clear();
            cboCategoria.Items.Add("SERVICIOS");
            foreach (string i in sel.CargarCategoriaServicio())
            {
                cboCategoria.Items.Add(i);
            }
        }

        private void CargarCarritoServicios()
        {
            dgvCarritoCompras.Rows.Clear();
            foreach (PedidoSoloServicioServicioE s in servicios)
            {
                foreach (ServicioE i in sel.CargarServicio("", ""))
                {
                    if (s.IdVenta == i.Id)
                    {
                        dgvCarritoCompras.Rows.Add(s, i.Id, i.Nombre, i.Categoria, i.Descripcion,
                            i.Precio, s.Cantidad, s.PrecioTotal);
                        break;
                    }
                }
            }
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
            foreach (PedidoSoloServicioServicioE s in servicios)
            {
                subtotal += s.PrecioTotal;
            }
            total = subtotal * (1 + iva / 100);
            lblSubtotalT.Text = subtotal.ToString("0.00");
            lblTotalT.Text = total.ToString("0.00");
        }

        private void CargarPedidos()
        {
            dgvPedidos.Rows.Clear();
            foreach (PedidoCompletoE p in pl.CargarPedidoCompleto())
            {
                if (p.HoraSalidaBodega != null)
                {
                    dgvPedidos.Rows.Add(p, "COMPLETO", p.Id, p.HoraRecibidoBodega, p.HoraSalidaBodega);
                }
            }
            foreach (PedidoSoloServicioE p in pl.CargarPedidoSoloServicio())
            {
                if (p.HoraSalidaBodega != null)
                {
                    dgvPedidos.Rows.Add(p, "SOLO SERVICIO", p.Id, p.HoraRecibidoBodega, p.HoraSalidaBodega);
                }
            }
            foreach (PedidoClienteE p in pl.CargarPedidoCliente())
            {
                if (p.HoraSalidaBodega != null)
                {
                    dgvPedidos.Rows.Add(p, "CLIENTE", p.Id, p.HoraRecibidoBodega, p.HoraSalidaBodega);
                }
            }
        }

        private void CargarVentas()
        {
            dgvVentas.Rows.Clear();
            if (dgvPedidos.SelectedRows[1].Equals("COMPLETO"))
            {
                foreach (PedidoCompletoProductoE p in pl.CargarPedidoCompletoProducto())
                {
                    foreach (ProductoE i in prl.CargarProducto("", ""))
                    {
                        if (p.IdVenta == i.Id)
                        {
                            dgvVentas.Rows.Add("PRODUCTO", i.Id, i.Nombre, i.Categoria, i.Descripcion, p.Cantidad);
                            break;
                        }
                    }
                }
                foreach (PedidoCompletoServicioE s in pl.CargarPedidoCompletoServicio())
                {
                    foreach (ServicioE i in sel.CargarServicio("", ""))
                    {
                        if (s.IdVenta == i.Id)
                        {
                            dgvVentas.Rows.Add("SERVICIO", i.Id, i.Nombre, i.Categoria, i.Descripcion, s.Cantidad);
                            break;
                        }
                    }
                }
            }
            else if (dgvPedidos.SelectedRows[1].Equals("SOLO SERVICIO"))
            {
                foreach (PedidoSoloServicioServicioE s in pl.CargarPedidoSoloServicioServicio())
                {
                    foreach (ServicioE i in sel.CargarServicio("", ""))
                    {
                        if (s.IdVenta == i.Id)
                        {
                            dgvVentas.Rows.Add("SERVICIO", i.Id, i.Nombre, i.Categoria, i.Descripcion, s.Cantidad);
                            break;
                        }
                    }
                }
            }
            else if (dgvPedidos.SelectedRows[1].Equals("CLIENTE"))
            {
                foreach (PedidoClienteProductoE p in pl.CargarPedidoClienteProducto())
                {
                    foreach (ProductoE i in prl.CargarProducto("", ""))
                    {
                        if (p.IdVenta == i.Id)
                        {
                            dgvVentas.Rows.Add("PRODUCTO", i.Id, i.Nombre, i.Categoria, i.Descripcion, p.Cantidad);
                            break;
                        }
                    }
                }
                foreach (PedidoClienteServicioE s in pl.CargarPedidoClienteServicio())
                {
                    foreach (ServicioE i in sel.CargarServicio("", ""))
                    {
                        if (s.IdVenta == i.Id)
                        {
                            dgvVentas.Rows.Add("SERVICIO", i.Id, i.Nombre, i.Categoria, i.Descripcion, s.Cantidad);
                            break;
                        }
                    }
                }
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
            foreach (ServicioE i in sel.CargarServicio("", ""))
            {
                if (i.Id == int.Parse(txtCodigoServicio.Text))
                {
                    pss = new PedidoSoloServicioServicioE();
                    pss.IdPedido = ps.Id;
                    pss.IdVenta = int.Parse(txtCodigoServicio.Text);
                    pss.Cantidad = decimal.Parse(txtCantidadServicio.Text);
                    pss.PrecioTotal = i.Precio * pss.Cantidad;

                    servicios.AddLast(pss);

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
            ps = new PedidoSoloServicioE();
            ps.CedulaCliente = txtCedulaCliente.Text;
            ps.CodigoConductor = u.Codigo;
            ps.Observaciones = txtObservaciones.Text;
            ps.SubTotal = subtotal;
            ps.IVA = iva;
            ps.Total = total;
            pl.GuardarPedidoSoloServicioConstructor(ps);
            Limpiar();
            Activar(false);
        }

        private void btoBuscarServicio_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodigoServicio.Text))
            {
                lblNombreServicioT.Text = BuscarServicio(int.Parse(txtCodigoServicio.Text));
            }
        }

        private void btoEliminar_Click(object sender, EventArgs e)
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

        private void btoRecibido_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows[1].Equals("COMPLETO"))
            {
                PedidoCompletoE p = (PedidoCompletoE) dgvPedidos.CurrentRow.Cells[0].Value;
                p.HoraRecibidoBodega = dtpRecibido.Value;
                pl.GuardarPedidoCompletoBodega(p);
            }
            else if (dgvPedidos.SelectedRows[1].Equals("SOLO SERVICIO"))
            {
                PedidoSoloServicioE p = (PedidoSoloServicioE)dgvPedidos.CurrentRow.Cells[0].Value;
                p.HoraRecibidoBodega = dtpRecibido.Value;
                pl.GuardarPedidoSoloServicioBodega(p);
            }
            else if (dgvPedidos.SelectedRows[1].Equals("CLIENTE"))
            {
                PedidoClienteE p = (PedidoClienteE)dgvPedidos.CurrentRow.Cells[0].Value;
                p.HoraRecibidoBodega = dtpRecibido.Value;
                pl.GuardarPedidoClienteBodega(p);
            }
            CargarPedidos();
        }

        private void btoSalida_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows[1].Equals("COMPLETO"))
            {
                PedidoCompletoE p = (PedidoCompletoE)dgvPedidos.CurrentRow.Cells[0].Value;
                p.HoraSalidaBodega = dtpSalida.Value;
                pl.GuardarPedidoCompletoBodega(p);
            }
            else if (dgvPedidos.SelectedRows[1].Equals("SOLO SERVICIO"))
            {
                PedidoSoloServicioE p = (PedidoSoloServicioE)dgvPedidos.CurrentRow.Cells[0].Value;
                p.HoraSalidaBodega = dtpSalida.Value;
                pl.GuardarPedidoSoloServicioBodega(p);
            }
            else if (dgvPedidos.SelectedRows[1].Equals("CLIENTE"))
            {
                PedidoClienteE p = (PedidoClienteE)dgvPedidos.CurrentRow.Cells[0].Value;
                p.HoraSalidaBodega = dtpSalida.Value;
                pl.GuardarPedidoClienteBodega(p);
            }
            CargarPedidos();
        }

        private void dgvPedidos_SelectionChanged(object sender, EventArgs e)
        {
            CargarVentas();
        }
    }
}
