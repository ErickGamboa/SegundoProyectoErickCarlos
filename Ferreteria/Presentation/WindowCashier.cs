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

        /// <summary>
        /// Loads the orders to the cashier
        /// </summary>
        private void CargarPedidos()
        {
            try
            {
                dgvPedidos.Rows.Clear();
                foreach (PedidoCompletoE p in pl.CargarPedidoCompleto())
                {
                    if (p.FechaFactura == null)
                    {
                        dgvPedidos.Rows.Add(p, "COMPLETO", p.Id, p.CedulaCliente, p.Total);
                    }
                }
                foreach (PedidoSoloServicioE p in pl.CargarPedidoSoloServicio())
                {
                    if (p.FechaFactura == null)
                    {
                        dgvPedidos.Rows.Add(p, "SOLO SERVICIO", p.Id, p.CedulaCliente, p.Total);
                    }
                }
                foreach (PedidoClienteE p in pl.CargarPedidoCliente())
                {
                    if (p.FechaFactura == null)
                    {
                        dgvPedidos.Rows.Add(p, "CLIENTE", p.Id, p.CedulaCliente, p.Total);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cargando pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Generates a bill for the products and services sold
        /// </summary>
        /// <param name="tipoFactura">
        /// string bill type: only the products or everything
        /// </param>
        private void Factura(string tipoFactura)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea realizar el pago seleccionado?",
                        "Realizando Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    decimal subtotal = 0;
                    decimal iva = 0;
                    decimal total = 0;

                    if (tipoFactura.Equals("Productos"))
                    {
                        if (dgvPedidos.CurrentRow.Cells[1].Value.Equals("COMPLETO"))
                        {
                            PedidoCompletoE p = (PedidoCompletoE)dgvPedidos.CurrentRow.Cells[0].Value;
                            p.CodigoCajero = u.Codigo;
                            p.FechaFactura = dtpFecha.Value;
                            p.PagaSoloProducto = true;
                            pl.GuardarPedidoCompletoFactura(p);

                            WindowReceipt factura = new WindowReceipt();
                            factura.lblNumeroFacturaT.Text = p.Id.ToString();
                            factura.lblFechaT.Text = p.FechaFactura.ToString();
                            factura.lblCedulaClienteT.Text = p.CedulaCliente;

                            foreach (UsuarioE i in ul.CargarUsuario())
                            {
                                if (i.Codigo == p.CodigoCajero)
                                {
                                    factura.lblCajeroT.Text = i.Nombre;
                                }
                            }

                            foreach (PedidoCompletoProductoE i in pl.CargarPedidoCompletoProducto())
                            {
                                if (i.IdPedido == p.Id)
                                {
                                    foreach (ProductoE pr in prl.CargarProducto("", ""))
                                    {
                                        if (pr.Id == i.IdPedido)
                                        {
                                            subtotal += (pr.Precio * i.Cantidad);
                                            factura.txtVentas.Text += "\n" + pr.Nombre + "\n" + i.Cantidad
                                                + "\t" + pr.Precio.ToString("0.00") + "\t" + i.PrecioTotal.ToString("0.00") + "\n";
                                            break;
                                        }
                                    }
                                }
                            }

                            iva = subtotal * (decimal)0.13;
                            total = subtotal + iva;

                            factura.lblSubtotalT.Text = subtotal.ToString();
                            factura.lblIVAT.Text = iva.ToString();
                            factura.lblTotalT.Text = total.ToString();

                            factura.ShowDialog();
                        }
                        else if (dgvPedidos.CurrentRow.Cells[1].Value.Equals("CLIENTE"))
                        {
                            PedidoClienteE p = (PedidoClienteE)dgvPedidos.CurrentRow.Cells[0].Value;
                            p.CodigoCajero = u.Codigo;
                            p.FechaFactura = dtpFecha.Value;
                            p.PagaSoloProducto = true;
                            pl.GuardarPedidoClienteFactura(p);

                            WindowReceipt factura = new WindowReceipt();
                            factura.lblNumeroFacturaT.Text = p.Id.ToString();
                            factura.lblFechaT.Text = p.FechaFactura.ToString();
                            factura.lblCedulaClienteT.Text = p.CedulaCliente;

                            foreach (UsuarioE i in ul.CargarUsuario())
                            {
                                if (i.Codigo == p.CodigoCajero)
                                {
                                    factura.lblCajeroT.Text = i.Nombre;
                                }
                            }

                            foreach (PedidoClienteProductoE i in pl.CargarPedidoClienteProducto())
                            {
                                if (i.IdPedido == p.Id)
                                {
                                    foreach (ProductoE pr in prl.CargarProducto("", ""))
                                    {
                                        if (pr.Id == i.IdPedido)
                                        {
                                            subtotal += (pr.Precio * i.Cantidad);
                                            factura.txtVentas.Text += "\n" + pr.Nombre + "\n" + i.Cantidad
                                                + "\t" + pr.Precio.ToString("0.00") + "\t" + i.PrecioTotal.ToString("0.00") + "\n";
                                            break;
                                        }
                                    }
                                }
                            }

                            iva = subtotal * (decimal)0.13;
                            total = subtotal + iva;

                            factura.lblSubtotalT.Text = subtotal.ToString();
                            factura.lblIVAT.Text = iva.ToString();
                            factura.lblTotalT.Text = total.ToString();

                            factura.ShowDialog();
                        }
                    }
                    else
                    {
                        if (dgvPedidos.CurrentRow.Cells[1].Value.Equals("COMPLETO"))
                        {
                            PedidoCompletoE p = (PedidoCompletoE)dgvPedidos.CurrentRow.Cells[0].Value;
                            p.CodigoCajero = u.Codigo;
                            p.FechaFactura = dtpFecha.Value;


                            WindowReceipt factura = new WindowReceipt();
                            factura.lblNumeroFacturaT.Text = p.Id.ToString();
                            factura.lblFechaT.Text = p.FechaFactura.ToString();
                            factura.lblCedulaClienteT.Text = p.CedulaCliente;

                            foreach (UsuarioE i in ul.CargarUsuario())
                            {
                                if (i.Codigo == p.CodigoCajero)
                                {
                                    factura.lblCajeroT.Text = i.Nombre;
                                }
                            }

                            if (p.PagaSoloProducto != true)
                            {
                                foreach (PedidoCompletoProductoE i in pl.CargarPedidoCompletoProducto())
                                {
                                    if (i.IdPedido == p.Id)
                                    {
                                        foreach (ProductoE pr in prl.CargarProducto("", ""))
                                        {
                                            if (pr.Id == i.IdPedido)
                                            {
                                                subtotal += (pr.Precio * i.Cantidad);
                                                factura.txtVentas.Text += "\n" + pr.Nombre + "\n" + i.Cantidad
                                                    + "\t" + pr.Precio.ToString("0.00") + "\t" + i.PrecioTotal.ToString("0.00") + "\n";
                                                break;
                                            }
                                        }
                                    }
                                }
                            }

                            foreach (PedidoCompletoServicioE i in pl.CargarPedidoCompletoServicio())
                            {
                                if (i.IdPedido == p.Id)
                                {
                                    foreach (ServicioE se in sel.CargarServicio("", ""))
                                    {
                                        if (se.Id == i.IdPedido)
                                        {
                                            subtotal += (se.Precio * i.Cantidad);
                                            factura.txtVentas.Text += "\n" + se.Nombre + "\n" + i.Cantidad
                                                + "\t" + se.Precio.ToString("0.00") + "\t" + i.PrecioTotal.ToString("0.00") + "\n";
                                            break;
                                        }
                                    }
                                }
                            }

                            iva = subtotal * (decimal)0.13;
                            total = subtotal + iva;

                            p.PagaSoloProducto = false;
                            pl.GuardarPedidoCompletoFactura(p);

                            factura.lblSubtotalT.Text = subtotal.ToString();
                            factura.lblIVAT.Text = iva.ToString();
                            factura.lblTotalT.Text = total.ToString();

                            factura.ShowDialog();
                        }
                        else if (dgvPedidos.CurrentRow.Cells[1].Value.Equals("SOLO SERVICIO"))
                        {
                            PedidoSoloServicioE p = (PedidoSoloServicioE)dgvPedidos.CurrentRow.Cells[0].Value;
                            p.CodigoCajero = u.Codigo;
                            p.FechaFactura = dtpFecha.Value;
                            pl.GuardarPedidoSoloServicioFactura(p);

                            WindowReceipt factura = new WindowReceipt();
                            factura.lblNumeroFacturaT.Text = p.Id.ToString();
                            factura.lblFechaT.Text = p.FechaFactura.ToString();
                            factura.lblCedulaClienteT.Text = p.CedulaCliente;

                            foreach (UsuarioE i in ul.CargarUsuario())
                            {
                                if (i.Codigo == p.CodigoCajero)
                                {
                                    factura.lblCajeroT.Text = i.Nombre;
                                }
                            }

                            foreach (PedidoSoloServicioServicioE i in pl.CargarPedidoSoloServicioServicio())
                            {
                                if (i.IdPedido == p.Id)
                                {
                                    foreach (ServicioE se in sel.CargarServicio("", ""))
                                    {
                                        if (se.Id == i.IdPedido)
                                        {
                                            factura.txtVentas.Text += "\n" + se.Nombre + "\n" + i.Cantidad
                                                + "\t" + se.Precio.ToString("0.00") + "\t" + i.PrecioTotal.ToString("0.00") + "\n";
                                            break;
                                        }
                                    }
                                }
                            }

                            factura.lblSubtotalT.Text = p.SubTotal.ToString();
                            factura.lblIVAT.Text = p.IVA.ToString();
                            factura.lblTotalT.Text = p.Total.ToString();

                            factura.ShowDialog();
                        }
                        else if (dgvPedidos.CurrentRow.Cells[1].Value.Equals("CLIENTE"))
                        {
                            PedidoClienteE p = (PedidoClienteE)dgvPedidos.CurrentRow.Cells[0].Value;
                            p.CodigoCajero = u.Codigo;
                            p.FechaFactura = dtpFecha.Value;

                            WindowReceipt factura = new WindowReceipt();
                            factura.lblNumeroFacturaT.Text = p.Id.ToString();
                            factura.lblFechaT.Text = p.FechaFactura.ToString();
                            factura.lblCedulaClienteT.Text = p.CedulaCliente;

                            foreach (UsuarioE i in ul.CargarUsuario())
                            {
                                if (i.Codigo == p.CodigoCajero)
                                {
                                    factura.lblCajeroT.Text = i.Nombre;
                                }
                            }

                            if (p.PagaSoloProducto != true)
                            {
                                foreach (PedidoClienteProductoE i in pl.CargarPedidoClienteProducto())
                                {
                                    if (i.IdPedido == p.Id)
                                    {
                                        foreach (ProductoE pr in prl.CargarProducto("", ""))
                                        {
                                            if (pr.Id == i.IdPedido)
                                            {
                                                subtotal += (pr.Precio * i.Cantidad);
                                                factura.txtVentas.Text += "\n" + pr.Nombre + "\n" + i.Cantidad
                                                    + "\t" + pr.Precio.ToString("0.00") + "\t" + i.PrecioTotal.ToString("0.00") + "\n";
                                                break;
                                            }
                                        }
                                    }
                                }
                            }

                            foreach (PedidoClienteServicioE i in pl.CargarPedidoClienteServicio())
                            {
                                if (i.IdPedido == p.Id)
                                {
                                    foreach (ServicioE se in sel.CargarServicio("", ""))
                                    {
                                        if (se.Id == i.IdPedido)
                                        {
                                            subtotal += (se.Precio * i.Cantidad);
                                            factura.txtVentas.Text += "\n" + se.Nombre + "\n" + i.Cantidad
                                                + "\t" + se.Precio.ToString("0.00") + "\t" + i.PrecioTotal.ToString("0.00") + "\n";
                                            break;
                                        }
                                    }
                                }
                            }

                            iva = subtotal * (decimal)0.13;
                            total = subtotal + iva;

                            p.PagaSoloProducto = false;
                            pl.GuardarPedidoClienteFactura(p);

                            factura.lblSubtotalT.Text = subtotal.ToString();
                            factura.lblIVAT.Text = iva.ToString();
                            factura.lblTotalT.Text = total.ToString();

                            factura.ShowDialog();
                        }
                    }
                    CargarPedidos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Generando Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnGenerarFacturaCompleta_Click(object sender, EventArgs e)
        {
            Factura("Completa");
        }

        private void btnGenerarFacturaProductos_Click(object sender, EventArgs e)
        {
            Factura("Productos");
        }
    }
}
