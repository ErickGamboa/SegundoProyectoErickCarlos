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
    public partial class WindowCarrier : Form
    {
        private PedidoL pl;
        private UsuarioE u;
        private LProducto prl;
        private LServicio sel;
        private LTransporte tl;

        public WindowCarrier(UsuarioE u)
        {
            InitializeComponent();
            pl = new PedidoL();
            this.u = u;
            prl = new LProducto();
            sel = new LServicio();
            tl = new LTransporte();
            dgvTransportes.Columns[0].ValueType = typeof(object);
            CargarPedidosTransporte();
        }

        /// <summary>
        /// Loads the orders to the carrier
        /// </summary>
        private void CargarPedidosTransporte()
        {
            try
            {
                dgvTransportes.Rows.Clear();
                foreach (PedidoCompletoE p in pl.CargarPedidoCompleto())
                {
                    if (p.HoraFinalizaTransporte == null)
                    {
                        dgvTransportes.Rows.Add(p, "COMPLETO", p.Id, p.HoraIniciaTransporte, p.HoraFinalizaTransporte);
                    }
                }
                foreach (PedidoSoloServicioE p in pl.CargarPedidoSoloServicio())
                {
                    if (p.HoraFinalizaTransporte == null)
                    {
                        dgvTransportes.Rows.Add(p, "SOLO SERVICIO", p.Id, p.HoraIniciaTransporte, p.HoraFinalizaTransporte);
                    }
                }
                foreach (PedidoClienteE p in pl.CargarPedidoCliente())
                {
                    if (p.HoraFinalizaTransporte == null)
                    {
                        dgvTransportes.Rows.Add(p, "CLIENTE", p.Id, p.HoraIniciaTransporte, p.HoraFinalizaTransporte);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cargando Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Loads the orders to the store room section
        /// </summary>
        private void CargarPedidosBodega()
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

        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTransportes.CurrentRow.Cells[1].Value.Equals("COMPLETO"))
                {
                    PedidoCompletoE p = (PedidoCompletoE)dgvTransportes.CurrentRow.Cells[0].Value;
                    p.CodigoConductor = u.Codigo;
                    p.HoraIniciaTransporte = dtpInicia.Value;
                    pl.GuardarPedidoCompletoTransporte(p);
                }
                else if (dgvTransportes.CurrentRow.Cells[1].Value.Equals("SOLO SERVICIO"))
                {
                    PedidoSoloServicioE p = (PedidoSoloServicioE)dgvTransportes.CurrentRow.Cells[0].Value;
                    p.CodigoConductor = u.Codigo;
                    p.HoraIniciaTransporte = dtpInicia.Value;
                    pl.GuardarPedidoSoloServicioTransporte(p);
                }
                else if (dgvTransportes.CurrentRow.Cells[1].Value.Equals("CLIENTE"))
                {
                    PedidoClienteE p = (PedidoClienteE)dgvTransportes.CurrentRow.Cells[0].Value;
                    p.CodigoConductor = u.Codigo;
                    p.HoraIniciaTransporte = dtpInicia.Value;
                    pl.GuardarPedidoClienteTransporte(p);
                }
                CargarPedidosTransporte();

                foreach (TransporteE t in tl.CargarTransportes())
                {
                    if (t.CodigoConductor == u.Codigo)
                    {
                        t.Disponible = false;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Hora Inicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnAgregarFin_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTransportes.CurrentRow.Cells[1].Value.Equals("COMPLETO"))
                {
                    PedidoCompletoE p = (PedidoCompletoE)dgvTransportes.CurrentRow.Cells[0].Value;
                    p.HoraFinalizaTransporte = dtpFinaliza.Value;
                    pl.GuardarPedidoCompletoTransporte(p);
                }
                else if (dgvTransportes.CurrentRow.Cells[1].Value.Equals("SOLO SERVICIO"))
                {
                    PedidoSoloServicioE p = (PedidoSoloServicioE)dgvTransportes.CurrentRow.Cells[0].Value;
                    p.HoraFinalizaTransporte = dtpFinaliza.Value;
                    pl.GuardarPedidoSoloServicioTransporte(p);
                }
                else if (dgvTransportes.CurrentRow.Cells[1].Value.Equals("CLIENTE"))
                {
                    PedidoClienteE p = (PedidoClienteE)dgvTransportes.CurrentRow.Cells[0].Value;
                    p.HoraFinalizaTransporte = dtpFinaliza.Value;
                    pl.GuardarPedidoClienteTransporte(p);
                }
                CargarPedidosTransporte();

                foreach (TransporteE t in tl.CargarTransportes())
                {
                    if (t.CodigoConductor == u.Codigo)
                    {
                        t.Disponible = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Hora Fin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Dispose();
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
                CargarPedidosBodega();
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
                CargarPedidosBodega();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Hora Salida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
