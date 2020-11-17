using Data;
using Entities;
using Entities.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class PedidoL
    {
        /// <summary>
        /// Loads the list of orders made by the sellers from the database
        /// </summary>
        /// <returns>
        /// List of orders made by the sellers
        /// </returns>
        public List<PedidoCompletoE> CargarPedidoCompleto()
        {
            try
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
                                  Total = pc.total,
                                  PagaSoloProducto = pc.paga_solo_producto
                              };

                    foreach (PedidoCompletoE i in lst)
                    {
                        pedidos.Add(new PedidoCompletoE(i.Id, i.CodigoVendedor, i.CedulaCliente,
                            i.HoraAtencion, i.HoraVenta, i.HoraRecibidoBodega, i.HoraSalidaBodega,
                            i.CodigoConductor, i.HoraIniciaTransporte, i.HoraFinalizaTransporte,
                            i.FechaFactura, i.CodigoCajero, i.SubTotal, i.IVA, i.Total, i.PagaSoloProducto));
                    }
                }
                return pedidos;
            }
            catch (Exception)
            {
                throw new Exception("Error al cargar la lista de pedidos");
            }
        }

        /// <summary>
        /// Saves a new order made by the seller on to the database
        /// </summary>
        /// <param name="pc">
        /// Instance of the class PedidoCompleto
        /// </param>
        /// <returns>
        /// True if the order is saved
        /// </returns>
        public bool GuardarPedidoCompletoVendedor(PedidoCompletoE pc)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_ipedido_completo_vendedor @p0, @p1, @p2, @p3, @p4, @p5, @p6",
                    pc.CodigoVendedor, pc.CedulaCliente, pc.HoraAtencion, pc.HoraVenta,
                    pc.SubTotal, pc.IVA, pc.Total) > 0;
            }
        }

        /// <summary>
        /// Updates an order selected by the builder or the carrier on to the database
        /// </summary>
        /// <param name="pc">
        /// Instance of the class PedidoCompleto
        /// </param>
        /// <returns>
        /// True if the order is updated
        /// </returns>
        public bool GuardarPedidoCompletoBodega(PedidoCompletoE pc)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_upedido_completo_bodega @p0, @p1, @p2",
                    pc.Id, pc.HoraRecibidoBodega, pc.HoraSalidaBodega) > 0;
            }
        }

        /// <summary>
        /// Updates an order selected by the carrier on to the database
        /// </summary>
        /// <param name="pc">
        /// Instance of the class PedidoCompleto
        /// </param>
        /// <returns>
        /// True if the order is updated
        /// </returns>
        public bool GuardarPedidoCompletoTransporte(PedidoCompletoE pc)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_upedido_completo_transporte @p0, @p1, @p2, @p3",
                    pc.Id, pc.CodigoConductor, pc.HoraIniciaTransporte, pc.HoraFinalizaTransporte) > 0;
            }
        }

        /// <summary>
        /// Updates an order selected by the cashier on to the database
        /// </summary>
        /// <param name="pc">
        /// Instance of the class PedidoCompleto
        /// </param>
        /// <returns>
        /// True if the order is updated
        /// </returns>
        public bool GuardarPedidoCompletoFactura(PedidoCompletoE pc)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_upedido_completo_factura @p0, @p1, @p2, @p3",
                    pc.Id, pc.FechaFactura, pc.CodigoCajero, pc.PagaSoloProducto) > 0;
            }
        }

        /// <summary>
        /// Loads the list of products sold by the sellers from the database
        /// </summary>
        /// <returns>
        /// List of productos sold by the sellers
        /// </returns>
        public List<PedidoCompletoProductoE> CargarPedidoCompletoProducto()
        {
            try
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
            catch (Exception)
            {
                throw new Exception("Error al cargar la lista de productos");
            }
        }

        /// <summary>
        /// Saves the products sold by the seller on to the database
        /// </summary>
        /// <param name="pc">
        /// Instance of the class PedidoCompletoProducto
        /// </param>
        /// <returns>
        /// True if the products sold are saved
        /// </returns>
        public bool GuardarPedidoCompletoProducto(PedidoCompletoProductoE pcp)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_ipedido_completo_producto @p0, @p1, @p2, @p3",
                    pcp.IdPedido, pcp.IdVenta, pcp.Cantidad, pcp.PrecioTotal) > 0;
            }
        }

        /// <summary>
        /// Loads the list of services sold by the sellers from the database
        /// </summary>
        /// <returns>
        /// List of services sold by the sellers
        /// </returns>
        public List<PedidoCompletoServicioE> CargarPedidoCompletoServicio()
        {
            try
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
            catch (Exception)
            {
                throw new Exception("Error al cargar la lista de servicios");
            }
        }

        /// <summary>
        /// Saves the services sold by the seller on to the database
        /// </summary>
        /// <param name="pc">
        /// Instance of the class PedidoCompletoServicio
        /// </param>
        /// <returns>
        /// True if the services sold are saved
        /// </returns>
        public bool GuardarPedidoCompletoServicio(PedidoCompletoServicioE pcs)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_ipedido_completo_servicio @p0, @p1, @p2, @p3",
                    pcs.IdPedido, pcs.IdVenta, pcs.Cantidad, pcs.PrecioTotal) > 0;
            }
        }

        /// <summary>
        /// Loads the list of orders made by the builders or the carriers from the database
        /// </summary>
        /// <returns>
        /// List of orders made by the builders or the carriers
        /// </returns>>
        public List<PedidoSoloServicioE> CargarPedidoSoloServicio()
        {
            try
            {
                List<PedidoSoloServicioE> pedidos = new List<PedidoSoloServicioE>();
                using (FerreteriaEntities db = new FerreteriaEntities())
                {
                    var lst = from pss in db.v_spedido_solo_servicio.ToList()
                              select new PedidoSoloServicioE
                              {
                                  Id = pss.id,
                                  CedulaCliente = pss.cedula_cliente,
                                  CodigoUsuario = pss.codigo_usuario,
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
                        pedidos.Add(new PedidoSoloServicioE(i.Id, i.CedulaCliente, i.CodigoUsuario,
                            i.Observaciones, i.HoraRecibidoBodega, i.HoraSalidaBodega,
                            i.CodigoConductor, i.HoraIniciaTransporte, i.HoraFinalizaTransporte,
                            i.FechaFactura, i.CodigoCajero, i.SubTotal, i.IVA, i.Total));
                    }
                }
                return pedidos;
            }
            catch (Exception)
            {
                throw new Exception("Error al cargar la lista de pedidos");
            }
        }

        /// <summary>
        /// Saves a new order made by the builder or the carrier on to the database
        /// </summary>
        /// <param name="pc">
        /// Instance of the class PedidoSoloServicio
        /// </param>
        /// <returns>
        /// True if the order is saved
        /// </returns>
        public bool GuardarPedidoSoloServicioConstructor(PedidoSoloServicioE pss)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_ipedido_solo_servicio_constructor @p0, @p1, @p2, @p3, @p4, @p5",
                    pss.CedulaCliente, pss.CodigoUsuario, pss.Observaciones,
                    pss.SubTotal, pss.IVA, pss.Total) > 0;
            }
        }

        /// <summary>
        /// Updates an order selected by the builder or the carrier on to the database
        /// </summary>
        /// <param name="pc">
        /// Instance of the class PedidoSoloServicio
        /// </param>
        /// <returns>
        /// True if the order is updated
        /// </returns>
        public bool GuardarPedidoSoloServicioBodega(PedidoSoloServicioE pss)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_upedido_solo_servicio_bodega @p0, @p1, @p2",
                    pss.Id, pss.HoraRecibidoBodega, pss.HoraSalidaBodega) > 0;
            }
        }

        /// <summary>
        /// Updates an order selected by the carrier on to the database
        /// </summary>
        /// <param name="pc">
        /// Instance of the class PedidoSoloServicio
        /// </param>
        /// <returns>
        /// True if the order is updated
        /// </returns>
        public bool GuardarPedidoSoloServicioTransporte(PedidoSoloServicioE pss)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_upedido_solo_servicio_transporte @p0, @p1, @p2, @p3",
                    pss.Id, pss.CodigoConductor, pss.HoraIniciaTransporte, pss.HoraFinalizaTransporte) > 0;
            }
        }

        /// <summary>
        /// Updates an order selected by the cashier on to the database
        /// </summary>
        /// <param name="pc">
        /// Instance of the class PedidoSoloServicio
        /// </param>
        /// <returns>
        /// True if the order is updated
        /// </returns>
        public bool GuardarPedidoSoloServicioFactura(PedidoSoloServicioE pss)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_upedido_solo_servicio_factura @p0, @p1, @p2",
                    pss.Id, pss.FechaFactura, pss.CodigoCajero) > 0;
            }
        }

        /// <summary>
        /// Loads the list of services sold by the builders or the carriers from the database
        /// </summary>
        /// <returns>
        /// List of services sold by the builders or carriers
        /// </returns>
        public List<PedidoSoloServicioServicioE> CargarPedidoSoloServicioServicio()
        {
            try
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
            catch (Exception)
            {
                throw new Exception("Error al cargar la lista de servicios");
            }
        }

        /// <summary>
        /// Saves the services sold by the builder or the carrier on to the database
        /// </summary>
        /// <param name="pc">
        /// Instance of the class PedidoSoloServicioServicio
        /// </param>
        /// <returns>
        /// True if the services sold are saved
        /// </returns>
        public bool GuardarPedidoSoloServicioServicio(PedidoSoloServicioServicioE psss)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_ipedido_solo_servicio_servicio @p0, @p1, @p2, @p3",
                    psss.IdPedido, psss.IdVenta, psss.Cantidad, psss.PrecioTotal) > 0;
            }
        }

        /// <summary>
        /// Loads the list of orders made by the clients from the database
        /// </summary>
        /// <returns>
        /// List of orders made by the clientes
        /// </returns>
        public List<PedidoClienteE> CargarPedidoCliente()
        {
            try
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
                                  Estado = pc.estado,
                                  PagaSoloProducto = pc.paga_solo_producto
                              };

                    foreach (PedidoClienteE i in lst)
                    {
                        pedidos.Add(new PedidoClienteE(i.Id, i.CedulaCliente, i.NombreCliente, i.Fecha,
                            i.HoraRecibidoBodega, i.HoraSalidaBodega, i.CodigoConductor,
                            i.HoraIniciaTransporte, i.HoraFinalizaTransporte, i.FechaFactura,
                            i.CodigoCajero, i.SubTotal, i.IVA, i.Total, i.Estado, i.PagaSoloProducto));
                    }
                }
                return pedidos;
            }
            catch (Exception)
            {
                throw new Exception("Error al cargar la lista de pedidos");
            }
        }

        /// <summary>
        /// Saves a new order made by the client on to the database
        /// </summary>
        /// <param name="pc">
        /// Instance of the class PedidoCliente
        /// </param>
        /// <returns>
        /// True if the order is saved
        /// </returns>
        public bool GuardarPedidoClienteCliente(PedidoClienteE pc)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_ipedido_cliente_cliente @p0, @p1, @p2, @p3, @p4, @p5",
                    pc.CedulaCliente, pc.NombreCliente, pc.Fecha,
                    pc.SubTotal, pc.IVA, pc.Total) > 0;
            }
        }

        /// <summary>
        /// Updates an order selected by the builder or the carrier on to the database
        /// </summary>
        /// <param name="pc">
        /// Instance of the class PedidoCliente
        /// </param>
        /// <returns>
        /// True if the order is updated
        /// </returns>
        public bool GuardarPedidoClienteBodega(PedidoClienteE pc)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_upedido_cliente_bodega @p0, @p1, @p2",
                    pc.Id, pc.HoraRecibidoBodega, pc.HoraSalidaBodega) > 0;
            }
        }

        /// <summary>
        /// Updates an order selected by the carrier on to the database
        /// </summary>
        /// <param name="pc">
        /// Instance of the class PedidoCliente
        /// </param>
        /// <returns>
        /// True if the order is updated
        /// </returns>
        public bool GuardarPedidoClienteTransporte(PedidoClienteE pc)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_upedido_cliente_transporte @p0, @p1, @p2, @p3",
                    pc.Id, pc.CodigoConductor, pc.HoraIniciaTransporte, pc.HoraFinalizaTransporte) > 0;
            }
        }

        /// <summary>
        /// Updates an order selected by the cashier on to the database
        /// </summary>
        /// <param name="pc">
        /// Instance of the class PedidoCliente
        /// </param>
        /// <returns>
        /// True if the order is updated
        /// </returns>
        public bool GuardarPedidoClienteFactura(PedidoClienteE pc)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_upedido_cliente_factura @p0, @p1, @p2, @p3",
                    pc.Id, pc.FechaFactura, pc.CodigoCajero, pc.PagaSoloProducto) > 0;
            }
        }

        /// <summary>
        /// Loads the list of products bought by the clientes from the database
        /// </summary>
        /// <returns>
        /// List of products bought by the clientes
        /// </returns>
        public List<PedidoClienteProductoE> CargarPedidoClienteProducto()
        {
            try
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
            catch (Exception)
            {
                throw new Exception("Error al cargar la lista de productos");
            }
        }

        /// <summary>
        /// Saves the products bought by the clients on to the database
        /// </summary>
        /// <param name="pc">
        /// Instance of the class PedidoClienteProducto
        /// </param>
        /// <returns>
        /// True if the products bought are saved
        /// </returns>
        public bool GuardarPedidoClienteProducto(PedidoClienteProductoE pcp)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_ipedido_cliente_producto @p0, @p1, @p2, @p3",
                    pcp.IdPedido, pcp.IdVenta, pcp.Cantidad, pcp.PrecioTotal) > 0;
            }
        }

        /// <summary>
        /// Loads the list of services bought by the clients from the database
        /// </summary>
        /// <returns>
        /// List of services bought by the clients
        /// </returns>
        public List<PedidoClienteServicioE> CargarPedidoClienteServicio()
        {
            try
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
            catch (Exception)
            {
                throw new Exception("Error al cargar la lista de servicios");
            }
        }

        /// <summary>
        /// Saves the services bought by the clients on to the database
        /// </summary>
        /// <param name="pc">
        /// Instance of the class PedidoClienteServicio
        /// </param>
        /// <returns>
        /// True if the services bought are saved
        /// </returns>
        public bool GuardarPedidoClienteServicio(PedidoClienteServicioE pcs)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.ExecuteSqlCommand("sp_ipedido_cliente_servicio @p0, @p1, @p2, @p3",
                    pcs.IdPedido, pcs.IdVenta, pcs.Cantidad, pcs.PrecioTotal) > 0;
            }
        }

        /// <summary>
        /// Loads the number of products sold by the sellers grouped by their category from the database
        /// </summary>
        /// <returns>
        /// List of products sold by the sellers grouped by their category
        /// </returns>
        public List<Reporte2E> CargarCantidadPCoPCategoria()
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.SqlQuery<Reporte2E>("SELECT * FROM v_scantidad_pcop_categoria").ToList();
            }
        }

        /// <summary>
        /// Loads the number of products bought by the clients grouped by their category from the database
        /// </summary>
        /// <returns>
        /// List of products bought by the clients grouped by their category
        /// </returns>
        public List<Reporte2E> CargarCantidadPClPCategoria()
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.SqlQuery<Reporte2E>("SELECT * FROM v_scantidad_pclp_categoria").ToList();
            }
        }

        /// <summary>
        /// Loads the services sold by the sellers on a specific day from the database
        /// </summary>
        /// <param name="dia">
        /// DateTime, a specific day to search in the database
        /// </param>
        /// <returns>
        /// List of services sold by the sellers on a specific day
        /// </returns>
        public List<string> CargarPCOServiciosDia(DateTime dia)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.SqlQuery<string>("sp_spco_servicio_dia @p0", dia).ToList();
            }
        }

        /// <summary>
        /// Loads the services sold by the builders or carriers on a specific day from the database
        /// </summary>
        /// <param name="dia">
        /// DateTime, a specific day to search in the database
        /// </param>
        /// <returns>
        /// List of services sold by the builders or carriers on a specific day
        /// </returns>
        public List<string> CargarPSServiciosDia(DateTime dia)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.SqlQuery<string>("sp_sps_servicio_dia @p0", dia).ToList();
            }
        }

        /// <summary>
        /// Loads the services bought by the clients on a specific day from the database
        /// </summary>
        /// <param name="dia">
        /// DateTime, a specific day to search in the database
        /// </param>
        /// <returns>
        /// List of services bought by the clients on a specific day
        /// </returns>
        public List<string> CargarPCLServiciosDia(DateTime dia)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.SqlQuery<string>("sp_spcl_servicio_dia @p0", dia).ToList();
            }
        }

        /// <summary>
        /// Loads the sellers that made sells on a specific day from the database
        /// </summary>
        /// <param name="dia">
        /// DateTime, a specific day to search in the database
        /// </param>
        /// <returns>
        /// List of sellers that made sells on a specific day
        /// </returns>
        public List<string> CargarPCOEmpleadosDia(DateTime dia)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.SqlQuery<string>("sp_spco_dia @p0", dia).ToList();
            }
        }

        /// <summary>
        /// Loads the builders or carriers that made sells on a specific day from the database
        /// </summary>
        /// <param name="dia">
        /// DateTime, a specific day to search in the database
        /// </param>
        /// <returns>
        /// List of builders or carriers that made sells on a specific day
        /// </returns>
        public List<string> CargarPSEmpleadosDia(DateTime dia)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.SqlQuery<string>("sp_sps_dia @p0", dia).ToList();
            }
        }

        /// <summary>
        /// Loads the number of services sold by the sellers grouped by their category from the database
        /// </summary>
        /// <returns>
        /// List of services sold by the sellers grouped by their category
        /// </returns>
        public List<Reporte2E> CargarCantidadPCoSCategoria()
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.SqlQuery<Reporte2E>("SELECT * FROM v_scantidad_pcos_categoria").ToList();
            }
        }

        /// <summary>
        /// Loads the number of services sold by the builders or carriers grouped by their category from the database
        /// </summary>
        /// <returns>
        /// List of services sold by the builders or carriers grouped by their category
        /// </returns>
        public List<Reporte2E> CargarCantidadPSSCategoria()
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.SqlQuery<Reporte2E>("SELECT * FROM v_scantidad_pss_categoria").ToList();
            }
        }

        /// <summary>
        /// Loads the number of services bought by the clients grouped by their category from the database
        /// </summary>
        /// <returns>
        /// List of services bought by the clients grouped by their category
        /// </returns>
        public List<Reporte2E> CargarCantidadPClSCategoria()
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.SqlQuery<Reporte2E>("SELECT * FROM v_scantidad_pcls_categoria").ToList();
            }
        }

        /// <summary>
        /// Loads the number of sells made by the sellers from the database
        /// </summary>
        /// <returns>
        /// List of sells made by the sellers
        /// </returns>
        public List<Reporte4E> CargarCantidadPCOVendedor()
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.SqlQuery<Reporte4E>("SELECT * FROM v_scantidad_pco_vendedor").ToList();
            }
        }

        /// <summary>
        /// Loads the number of sells made by the builders or carriers from the database
        /// </summary>
        /// <returns>
        /// List of sells made by the builders or carriers
        /// </returns>
        public List<Reporte4E> CargarCantidadPSSConstructorConductor()
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.SqlQuery<Reporte4E>("SELECT * FROM v_scantidad_pss_constructor_conductor").ToList();
            }
        }

        /// <summary>
        /// Loads the clientes that bought something from the database
        /// </summary>
        /// <returns>
        /// List of clientes that bought something
        /// </returns>
        public List<int> CargarCantidadPCOCliente()
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.SqlQuery<int>("SELECT * FROM v_scantidad_pco_cliente").ToList();
            }
        }

        /// <summary>
        /// Loads the clientes that bought something from the database
        /// </summary>
        /// <returns>
        /// List of clientes that bought something
        /// </returns>
        public List<int> CargarCantidadPSSCliente()
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.SqlQuery<int>("SELECT * FROM v_scantidad_pss_cliente").ToList();
            }
        }

        /// <summary>
        /// Loads the clientes that bought something from the database
        /// </summary>
        /// <returns>
        /// List of clientes that bought something
        /// </returns>
        public List<int> CargarCantidadPCLCliente()
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.SqlQuery<int>("SELECT * FROM v_scantidad_pcl_cliente").ToList();
            }
        }

        /// <summary>
        /// Loads the money obtained from the sells and the taxes that have to be paid from the database
        /// </summary>
        /// <returns>
        /// List of money obtained from the sells and the taxes that have to be paid
        /// </returns>
        public List<Reporte7E> CargarCantidadSPCOCostos()
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.SqlQuery<Reporte7E>("SELECT * FROM v_spco_costos").ToList();
            }
        }

        /// <summary>
        /// Loads the money obtained from the sells and the taxes that have to be paid from the database
        /// </summary>
        /// <returns>
        /// List of money obtained from the sells and the taxes that have to be paid
        /// </returns>
        public List<Reporte7E> CargarCantidadSPSOCostos()
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.SqlQuery<Reporte7E>("SELECT * FROM v_sps_costos").ToList();
            }
        }

        /// <summary>
        /// Loads the money obtained from the sells and the taxes that have to be paid from the database
        /// </summary>
        /// <returns>
        /// List of money obtained from the sells and the taxes that have to be paid
        /// </returns>
        public List<Reporte7E> CargarCantidadSPCLCostos()
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                return db.Database.SqlQuery<Reporte7E>("SELECT * FROM v_spcl_costos").ToList();
            }
        }
    }
}
