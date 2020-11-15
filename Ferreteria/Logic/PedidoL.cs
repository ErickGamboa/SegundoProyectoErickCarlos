using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class PedidoL
    {
        public List<PedidoCompletoE> CargarPedidoCompleto()
        {
            List<PedidoCompletoE> pedidos = new List<PedidoCompletoE>();
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                var lst = from pc in db.v_spedido_completo.ToList()
                          select new PedidoCompletoE
                          {
                              Id = pc.id,
                              CodigoVendedor = pc.codigo_vendedor,
                              CedulaCliente = pc.cedula_cliente,
                              HoraAtencion = pc.hora_atencion,
                              HoraVenta = pc.hora_venta,
                              HoraRecibidoBodega = pc.hora_recibido_bodega,
                              HoraSalidaBodega = pc.hora_salida_bodega,
                              CodigoConductor = pc.codigo_conductor,
                              HoraIniciaTransporte = pc.hora_inicia_transporte,
                              HoraFinalizaTransporte = pc.hora_finaliza_transporte,
                              FechaFactura = pc.fecha_factura,
                              CodigoCajero = pc.codigo_cajero,
                              SubTotal = pc.subtotal,
                              IVA = pc.iva,
                              Total = pc.total
                          };

                foreach (PedidoCompletoE i in lst)
                {
                    pedidos.Add(new PedidoCompletoE(i.Id, i.CodigoVendedor, i.CedulaCliente,
                        i.HoraAtencion, i.HoraVenta, i.HoraRecibidoBodega, i.HoraSalidaBodega,
                        i.CodigoConductor, i.HoraIniciaTransporte, i.HoraFinalizaTransporte,
                        i.FechaFactura, i.CodigoCajero, i.SubTotal, i.IVA, i.Total));
                }
            }
            return pedidos;
        }

        public bool GuardarPedidoCompletoVendedor(PedidoCompletoE pc)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_ipedido_completo_vendedor @p0, @p1, @p2, @p3, @p4, @p5, @p6",
                    pc.CodigoVendedor, pc.CedulaCliente, pc.HoraAtencion, pc.HoraVenta,
                    pc.SubTotal, pc.IVA, pc.Total) > 0;
            }
        }

        public bool GuardarPedidoCompletoBodega(PedidoCompletoE pc)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_upedido_completo_bodega @p0, @p1, @p2",
                    pc.Id, pc.HoraRecibidoBodega, pc.HoraSalidaBodega) > 0;
            }
        }

        public bool GuardarPedidoCompletoTransporte(PedidoCompletoE pc)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_upedido_completo_transporte @p0, @p1, @p2, @p3",
                    pc.Id, pc.CodigoConductor, pc.HoraIniciaTransporte, pc.HoraFinalizaTransporte) > 0;
            }
        }

        public bool GuardarPedidoCompletoFactura(PedidoCompletoE pc)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_upedido_completo_factura @p0, @p1, @p2",
                    pc.Id, pc.FechaFactura, pc.CodigoCajero) > 0;
            }
        }

        public List<PedidoCompletoProductoE> CargarPedidoCompletoProducto()
        {
            List<PedidoCompletoProductoE> pedidos = new List<PedidoCompletoProductoE>();
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                var lst = from pcp in db.v_spedido_completo_producto.ToList()
                          select new PedidoCompletoProductoE
                          {
                              Id = pcp.id,
                              IdPedido = pcp.id_pedido_completo,
                              IdVenta = pcp.id_producto,
                              Cantidad = pcp.cantidad,
                              PrecioTotal = pcp.precio_total
                          };

                foreach (PedidoCompletoProductoE i in lst)
                {
                    pedidos.Add(new PedidoCompletoProductoE(i.Id, i.IdPedido, i.IdVenta,
                        i.Cantidad, i.PrecioTotal));
                }
            }
            return pedidos;
        }

        public bool GuardarPedidoCompletoProducto(PedidoCompletoProductoE pcp)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_ipedido_completo_producto @p0, @p1, @p2, @p3",
                    pcp.IdPedido, pcp.IdVenta, pcp.Cantidad, pcp.PrecioTotal) > 0;
            }
        }

        public List<PedidoCompletoServicioE> CargarPedidoCompletoServicio()
        {
            List<PedidoCompletoServicioE> pedidos = new List<PedidoCompletoServicioE>();
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                var lst = from pcs in db.v_spedido_completo_servicio.ToList()
                          select new PedidoCompletoServicioE
                          {
                              Id = pcs.id,
                              IdPedido = pcs.id_pedido_completo,
                              IdVenta = pcs.id_servicio,
                              Cantidad = pcs.cantidad,
                              PrecioTotal = pcs.precio_total
                          };

                foreach (PedidoCompletoServicioE i in lst)
                {
                    pedidos.Add(new PedidoCompletoServicioE(i.Id, i.IdPedido, i.IdVenta,
                        i.Cantidad, i.PrecioTotal));
                }
            }
            return pedidos;
        }

        public bool GuardarPedidoCompletoServicio(PedidoCompletoServicioE pcs)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_ipedido_completo_servicio @p0, @p1, @p2, @p3",
                    pcs.IdPedido, pcs.IdVenta, pcs.Cantidad, pcs.PrecioTotal) > 0;
            }
        }

        public List<PedidoSoloServicioE> CargarPedidoSoloServicio()
        {
            List<PedidoSoloServicioE> pedidos = new List<PedidoSoloServicioE>();
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                var lst = from pss in db.v_spedido_solo_servicio.ToList()
                          select new PedidoSoloServicioE
                          {
                              Id = pss.id,
                              CedulaCliente = pss.cedula_cliente,
                              CodigoConstructor = pss.codigo_constructor,
                              Observaciones = pss.observaciones,
                              HoraRecibidoBodega = pss.hora_recibido_bodega,
                              HoraSalidaBodega = pss.hora_salida_bodega,
                              CodigoConductor = pss.codigo_conductor,
                              HoraIniciaTransporte = pss.hora_inicia_transporte,
                              HoraFinalizaTransporte = pss.hora_finaliza_transporte,
                              FechaFactura = pss.fecha_factura,
                              CodigoCajero = pss.codigo_cajero,
                              SubTotal = pss.subtotal,
                              IVA = pss.iva,
                              Total = pss.total
                          };

                foreach (PedidoSoloServicioE i in lst)
                {
                    pedidos.Add(new PedidoSoloServicioE(i.Id, i.CedulaCliente, i.CodigoConstructor,
                        i.Observaciones, i.HoraRecibidoBodega, i.HoraSalidaBodega,
                        i.CodigoConductor, i.HoraIniciaTransporte, i.HoraFinalizaTransporte,
                        i.FechaFactura, i.CodigoCajero, i.SubTotal, i.IVA, i.Total));
                }
            }
            return pedidos;
        }

        public bool GuardarPedidoSoloServicioConstructor(PedidoSoloServicioE pss)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_ipedido_solo_servicio_constructor @p0, @p1, @p2, @p3, @p4, @p5",
                    pss.CedulaCliente, pss.CodigoConstructor, pss.Observaciones,
                    pss.SubTotal, pss.IVA, pss.Total) > 0;
            }
        }

        public bool GuardarPedidoSoloServicioBodega(PedidoSoloServicioE pss)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_upedido_solo_servicio_bodega @p0, @p1, @p2",
                    pss.Id, pss.HoraRecibidoBodega, pss.HoraSalidaBodega) > 0;
            }
        }

        public bool GuardarPedidoSoloServicioTransporte(PedidoSoloServicioE pss)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_upedido_solo_servicio_transporte @p0, @p1, @p2, @p3",
                    pss.Id, pss.CodigoConductor, pss.HoraIniciaTransporte, pss.HoraFinalizaTransporte) > 0;
            }
        }

        public bool GuardarPedidoSoloServicioFactura(PedidoSoloServicioE pss)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_upedido_solo_servicio_factura @p0, @p1, @p2",
                    pss.Id, pss.FechaFactura, pss.CodigoCajero) > 0;
            }
        }

        public List<PedidoSoloServicioServicioE> CargarPedidoSoloServicioServicio()
        {
            List<PedidoSoloServicioServicioE> pedidos = new List<PedidoSoloServicioServicioE>();
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                var lst = from pss in db.v_spedido_solo_servicio_servicio.ToList()
                          select new PedidoSoloServicioServicioE
                          {
                              Id = pss.id,
                              IdPedido = pss.id_pedido_solo_servicio,
                              IdVenta = pss.id_servicio,
                              Cantidad = pss.cantidad,
                              PrecioTotal = pss.precio_total
                          };

                foreach (PedidoSoloServicioServicioE i in lst)
                {
                    pedidos.Add(new PedidoSoloServicioServicioE(i.Id, i.IdPedido, i.IdVenta,
                        i.Cantidad, i.PrecioTotal));
                }
            }
            return pedidos;
        }

        public bool GuardarPedidoSoloServicioServicio(PedidoSoloServicioServicioE psss)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_ipedido_solo_servicio_servicio @p0, @p1, @p2, @p3",
                    psss.IdPedido, psss.IdVenta, psss.Cantidad, psss.PrecioTotal) > 0;
            }
        }

        public List<PedidoClienteE> CargarPedidoCliente()
        {
            List<PedidoClienteE> pedidos = new List<PedidoClienteE>();
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                var lst = from pc in db.v_spedido_cliente.ToList()
                          select new PedidoClienteE
                          {
                              Id = pc.id,
                              CedulaCliente = pc.cedula_cliente,
                              NombreCliente = pc.nombre_cliente,
                              Fecha = pc.fecha,
                              HoraRecibidoBodega = pc.hora_recibido_bodega,
                              HoraSalidaBodega = pc.hora_salida_bodega,
                              CodigoConductor = pc.codigo_conductor,
                              HoraIniciaTransporte = pc.hora_inicia_transporte,
                              HoraFinalizaTransporte = pc.hora_finaliza_transporte,
                              FechaFactura = pc.fecha_factura,
                              CodigoCajero = pc.codigo_cajero,
                              SubTotal = pc.subtotal,
                              IVA = pc.iva,
                              Total = pc.total,
                              Estado = pc.estado
                          };

                foreach (PedidoClienteE i in lst)
                {
                    pedidos.Add(new PedidoClienteE(i.Id, i.CedulaCliente, i.NombreCliente, i.Fecha,
                        i.HoraRecibidoBodega, i.HoraSalidaBodega, i.CodigoConductor,
                        i.HoraIniciaTransporte, i.HoraFinalizaTransporte, i.FechaFactura,
                        i.CodigoCajero, i.SubTotal, i.IVA, i.Total, i.Estado));
                }
            }
            return pedidos;
        }

        public bool GuardarPedidoClienteCliente(PedidoClienteE pc)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_ipedido_cliente_cliente @p0, @p1, @p2, @p3, @p4, @p5",
                    pc.CedulaCliente, pc.NombreCliente, pc.Fecha,
                    pc.SubTotal, pc.IVA, pc.Total) > 0;
            }
        }

        public bool GuardarPedidoClienteBodega(PedidoClienteE pc)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_upedido_cliente_bodega @p0, @p1, @p2",
                    pc.Id, pc.HoraRecibidoBodega, pc.HoraSalidaBodega) > 0;
            }
        }

        public bool GuardarPedidoClienteTransporte(PedidoClienteE pc)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_upedido_cliente_transporte @p0, @p1, @p2, @p3",
                    pc.Id, pc.CodigoConductor, pc.HoraIniciaTransporte, pc.HoraFinalizaTransporte) > 0;
            }
        }

        public bool GuardarPedidoClienteFactura(PedidoClienteE pc)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_upedido_cliente_factura @p0, @p1, @p2",
                    pc.Id, pc.FechaFactura, pc.CodigoCajero) > 0;
            }
        }

        public List<PedidoClienteProductoE> CargarPedidoClienteProducto()
        {
            List<PedidoClienteProductoE> pedidos = new List<PedidoClienteProductoE>();
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                var lst = from pcp in db.v_spedido_cliente_producto.ToList()
                          select new PedidoClienteProductoE
                          {
                              Id = pcp.id,
                              IdPedido = pcp.id_pedido_cliente,
                              IdVenta = pcp.id_producto,
                              Cantidad = pcp.cantidad,
                              PrecioTotal = pcp.precio_total
                          };

                foreach (PedidoClienteProductoE i in lst)
                {
                    pedidos.Add(new PedidoClienteProductoE(i.Id, i.IdPedido, i.IdVenta,
                        i.Cantidad, i.PrecioTotal));
                }
            }
            return pedidos;
        }

        public bool GuardarPedidoClienteProducto(PedidoClienteProductoE pcp)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_ipedido_cliente_producto @p0, @p1, @p2, @p3",
                    pcp.IdPedido, pcp.IdVenta, pcp.Cantidad, pcp.PrecioTotal) > 0;
            }
        }

        public List<PedidoClienteServicioE> CargarPedidoClienteServicio()
        {
            List<PedidoClienteServicioE> pedidos = new List<PedidoClienteServicioE>();
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                var lst = from pcs in db.v_spedido_cliente_servicio.ToList()
                          select new PedidoClienteServicioE
                          {
                              Id = pcs.id,
                              IdPedido = pcs.id_pedido_cliente,
                              IdVenta = pcs.id_servicio,
                              Cantidad = pcs.cantidad,
                              PrecioTotal = pcs.precio_total
                          };

                foreach (PedidoClienteServicioE i in lst)
                {
                    pedidos.Add(new PedidoClienteServicioE(i.Id, i.IdPedido, i.IdVenta,
                        i.Cantidad, i.PrecioTotal));
                }
            }
            return pedidos;
        } 

        public bool GuardarPedidoClienteServicio(PedidoClienteServicioE pcs)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_ipedido_cliente_servicio @p0, @p1, @p2, @p3",
                    pcs.IdPedido, pcs.IdVenta, pcs.Cantidad, pcs.PrecioTotal) > 0;
            }
        }
    }
}
