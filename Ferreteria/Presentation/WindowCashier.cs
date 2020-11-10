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
    public partial class WindowCashier : Form
    {
        private PedidoL pl;
        private UsuarioE u;
        private LUsuario ul;
        private LProducto prl;
        private LServicio sel;

        public WindowCashier(UsuarioE u)
        {
            InitializeComponent();
            pl = new PedidoL();
            this.u = u;
            ul = new LUsuario();
            prl = new LProducto();
            sel = new LServicio();
            dgvPedidos.Columns[0].ValueType = typeof(object);
            CargarPedidos();
        }

        private void CargarPedidos()
        {
            dgvPedidos.Rows.Clear();
            foreach (PedidoCompletoE p in pl.CargarPedidoCompleto())
            {
                if (p.FechaFactura != null)
                {
                    dgvPedidos.Rows.Add(p, "COMPLETO", p.Id, p.CedulaCliente, p.Total);
                }
            }
            foreach (PedidoSoloServicioE p in pl.CargarPedidoSoloServicio())
            {
                if (p.FechaFactura != null)
                {
                    dgvPedidos.Rows.Add(p, "SOLO SERVICIO", p.Id, p.CedulaCliente, p.Total);
                }
            }
            foreach (PedidoClienteE p in pl.CargarPedidoCliente())
            {
                if (p.FechaFactura != null)
                {
                    dgvPedidos.Rows.Add(p, "CLIENTE", p.Id, p.CedulaCliente, p.Total);
                }
            }
        }

        private void Factura()
        {
            if (dgvPedidos.SelectedRows[1].Equals("COMPLETO"))
            {
                PedidoCompletoE p = (PedidoCompletoE)dgvPedidos.CurrentRow.Cells[0].Value;
                p.CodigoCajero = u.Codigo;
                p.FechaFactura = dtpFecha.Value;
                pl.GuardarPedidoCompletoFactura(p);
                WindowReceipt factura = new WindowReceipt();
                factura.lblNumeroFacturaT.Text = p.Id.ToString();
                factura.lblFechaT.Text = p.FechaFactura.ToShortDateString();
                factura.lblCedulaClienteT.Text = p.CedulaCliente;
                
                foreach (UsuarioE i in ul.CargarUsuario())
                {
                    if (i.Codigo == p.CodigoCajero)
                    {
                        factura.lblCajeroT.Text = i.Nombre;
                    }
                }
                factura.lblColumnas.Text = "CANT\tPRECIO\tTOTAL";

                foreach (PedidoCompletoProductoE i in pl.CargarPedidoCompletoProducto())
                {
                    foreach (ProductoE pr in prl.CargarProducto("", ""))
                    {
                        if (pr.Id == i.IdPedido)
                        {
                            factura.txtVentas.Text += pr.Nombre + "\n" + i.Cantidad
                                + "\t" + pr.Precio.ToString("0.00") + "\t" + i.PrecioTotal.ToString("0.00");
                            break;
                        }
                    }
                }

                foreach (PedidoCompletoServicioE i in pl.CargarPedidoCompletoServicio())
                {
                    foreach (ServicioE se in sel.CargarServicio("", ""))
                    {
                        if (se.Id == i.IdPedido)
                        {
                            factura.txtVentas.Text += se.Nombre + "\n" + i.Cantidad
                                + "\t" + se.Precio.ToString("0.00") + "\t" + i.PrecioTotal.ToString("0.00");
                            break;
                        }
                    }
                }

                factura.lblSubtotalT.Text = p.SubTotal.ToString("0.00");
                factura.lblIVAT.Text = p.IVA.ToString("0.00");
                factura.lblTotalT.Text = p.Total.ToString("0.00");
            }
            else if (dgvPedidos.SelectedRows[1].Equals("SOLO SERVICIO"))
            {
                PedidoSoloServicioE p = (PedidoSoloServicioE)dgvPedidos.CurrentRow.Cells[0].Value;
                p.CodigoCajero = u.Codigo;
                p.FechaFactura = dtpFecha.Value;
                pl.GuardarPedidoSoloServicioFactura(p);
                WindowReceipt factura = new WindowReceipt();
                factura.lblNumeroFacturaT.Text = p.Id.ToString();
                factura.lblFechaT.Text = p.FechaFactura.ToShortDateString();
                factura.lblCedulaClienteT.Text = p.CedulaCliente;

                foreach (UsuarioE i in ul.CargarUsuario())
                {
                    if (i.Codigo == p.CodigoCajero)
                    {
                        factura.lblCajeroT.Text = i.Nombre;
                    }
                }
                factura.lblColumnas.Text = "CANT\tPRECIO\tTOTAL";

                foreach (PedidoSoloServicioServicioE i in pl.CargarPedidoSoloServicioServicio())
                {
                    foreach (ServicioE se in sel.CargarServicio("", ""))
                    {
                        if (se.Id == i.IdPedido)
                        {
                            factura.txtVentas.Text += se.Nombre + "\n" + i.Cantidad
                                + "\t" + se.Precio.ToString("0.00") + "\t" + i.PrecioTotal.ToString("0.00");
                            break;
                        }
                    }
                }

                factura.lblSubtotalT.Text = p.SubTotal.ToString("0.00");
                factura.lblIVAT.Text = p.IVA.ToString("0.00");
                factura.lblTotalT.Text = p.Total.ToString("0.00");
            }
            else if (dgvPedidos.SelectedRows[1].Equals("CLIENTE"))
            {
                PedidoClienteE p = (PedidoClienteE)dgvPedidos.CurrentRow.Cells[0].Value;
                p.CodigoCajero = u.Codigo;
                p.FechaFactura = dtpFecha.Value;
                pl.GuardarPedidoClienteFactura(p);
                WindowReceipt factura = new WindowReceipt();
                factura.lblNumeroFacturaT.Text = p.Id.ToString();
                factura.lblFechaT.Text = p.FechaFactura.ToShortDateString();
                factura.lblCedulaClienteT.Text = p.CedulaCliente;

                foreach (UsuarioE i in ul.CargarUsuario())
                {
                    if (i.Codigo == p.CodigoCajero)
                    {
                        factura.lblCajeroT.Text = i.Nombre;
                    }
                }
                factura.lblColumnas.Text = "CANT\tPRECIO\tTOTAL";

                foreach (PedidoClienteProductoE i in pl.CargarPedidoClienteProducto())
                {
                    foreach (ProductoE pr in prl.CargarProducto("", ""))
                    {
                        if (pr.Id == i.IdPedido)
                        {
                            factura.txtVentas.Text += pr.Nombre + "\n" + i.Cantidad
                                + "\t" + pr.Precio.ToString("0.00") + "\t" + i.PrecioTotal.ToString("0.00");
                            break;
                        }
                    }
                }

                foreach (PedidoClienteServicioE i in pl.CargarPedidoClienteServicio())
                {
                    foreach (ServicioE se in sel.CargarServicio("", ""))
                    {
                        if (se.Id == i.IdPedido)
                        {
                            factura.txtVentas.Text += se.Nombre + "\n" + i.Cantidad
                                + "\t" + se.Precio.ToString("0.00") + "\t" + i.PrecioTotal.ToString("0.00");
                            break;
                        }
                    }
                }

                factura.lblSubtotalT.Text = p.SubTotal.ToString("0.00");
                factura.lblIVAT.Text = p.IVA.ToString("0.00");
                factura.lblTotalT.Text = p.Total.ToString("0.00");
            }
            CargarPedidos();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            Factura();
        }
    }
}
