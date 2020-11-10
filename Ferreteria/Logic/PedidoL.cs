﻿using Data;
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
            using (var i = new FerreteriaEntities())
            {
                return i.Database.SqlQuery<PedidoCompletoE>("SELECT * FROM v_spedido_completo").ToList();
            }
        }

        public bool GuardarPedidoCompletoVendedor(PedidoCompletoE pc)
        {
            using (var i = new FerreteriaEntities())
            {
                return i.Database.ExecuteSqlCommand("sp_ipedido_completo_vendedor ?, ?, ?, ?, ?, ?, ?",
                    pc.CodigoVendedor, pc.CedulaCliente, pc.HoraAtencion, pc.HoraVenta,
                    pc.SubTotal, pc.IVA, pc.Total) > 0;
            }
        }

        public bool GuardarPedidoCompletoBodega(PedidoCompletoE pc)
        {
            using (var u = new FerreteriaEntities())
            {
                return u.Database.ExecuteSqlCommand("sp_upedido_completo_bodega ?, ?, ?",
                    pc.Id, pc.HoraRecibidoBodega, pc.HoraSalidaBodega) > 0;
            }
        }

        public bool GuardarPedidoCompletoTransporte(PedidoCompletoE pc)
        {
            using (var u = new FerreteriaEntities())
            {
                return u.Database.ExecuteSqlCommand("sp_upedido_completo_transporte ?, ?, ?, ?",
                    pc.Id, pc.CodigoConductor, pc.HoraIniciaTransporte, pc.HoraFinalizaTransporte) > 0;
            }
        }

        public bool GuardarPedidoCompletoFactura(PedidoCompletoE pc)
        {
            using (var u = new FerreteriaEntities())
            {
                return u.Database.ExecuteSqlCommand("sp_upedido_completo_factura ?, ?, ?",
                    pc.Id, pc.FechaFactura, pc.CodigoCajero) > 0;
            }
        }

        public List<PedidoCompletoProductoE> CargarPedidoCompletoProducto()
        {
            using (var i = new FerreteriaEntities())
            {
                return i.Database.SqlQuery<PedidoCompletoProductoE>("SELECT * FROM v_spedido_completo_producto").ToList();
            }
        }

        public bool GuardarPedidoCompletoProducto(PedidoCompletoProductoE pcp)
        {
            using (var i = new FerreteriaEntities())
            {
                return i.Database.ExecuteSqlCommand("sp_ipedido_completo_producto ?, ?, ?, ?",
                    pcp.IdPedido, pcp.IdVenta, pcp.Cantidad, pcp.PrecioTotal) > 0;
            }
        }

        public List<PedidoCompletoServicioE> CargarPedidoCompletoServicio()
        {
            using (var i = new FerreteriaEntities())
            {
                return i.Database.SqlQuery<PedidoCompletoServicioE>("SELECT * FROM v_spedido_completo_servicio").ToList();
            }
        }

        public bool GuardarPedidoCompletoServicio(PedidoCompletoServicioE pcs)
        {
            using (var i = new FerreteriaEntities())
            {
                return i.Database.ExecuteSqlCommand("sp_ipedido_completo_servicio ?, ?, ?, ?",
                    pcs.IdPedido, pcs.IdVenta, pcs.Cantidad, pcs.PrecioTotal) > 0;
            }
        }

        public List<PedidoSoloServicioE> CargarPedidoSoloServicio()
        {
            using (var i = new FerreteriaEntities())
            {
                return i.Database.SqlQuery<PedidoSoloServicioE>("SELECT * FROM v_spedido_solo_servicio").ToList();
            }
        }

        public bool GuardarPedidoSoloServicioConstructor(PedidoSoloServicioE pss)
        {
            using (var i = new FerreteriaEntities())
            {
                return i.Database.ExecuteSqlCommand("sp_ipedido_solo_servicio_constructor ?, ?, ?, ?, ?, ?",
                    pss.CedulaCliente, pss.CodigoConstructor, pss.Observaciones,
                    pss.SubTotal, pss.IVA, pss.Total) > 0;
            }
        }

        public bool GuardarPedidoSoloServicioBodega(PedidoSoloServicioE pss)
        {
            using (var u = new FerreteriaEntities())
            {
                return u.Database.ExecuteSqlCommand("sp_upedido_solo_servicio_bodega ?, ?, ?",
                    pss.Id, pss.HoraRecibidoBodega, pss.HoraSalidaBodega) > 0;
            }
        }

        public bool GuardarPedidoSoloServicioTransporte(PedidoSoloServicioE pss)
        {
            using (var u = new FerreteriaEntities())
            {
                return u.Database.ExecuteSqlCommand("sp_upedido_solo_servicio_transporte ?, ?, ?, ?",
                    pss.Id, pss.CodigoConductor, pss.HoraIniciaTransporte, pss.HoraFinalizaTransporte) > 0;
            }
        }

        public bool GuardarPedidoSoloServicioFactura(PedidoSoloServicioE pss)
        {
            using (var u = new FerreteriaEntities())
            {
                return u.Database.ExecuteSqlCommand("sp_upedido_solo_servicio_factura ?, ?, ?",
                    pss.Id, pss.FechaFactura, pss.CodigoCajero) > 0;
            }
        }

        public List<PedidoSoloServicioServicioE> CargarPedidoSoloServicioServicio()
        {
            using (var i = new FerreteriaEntities())
            {
                return i.Database.SqlQuery<PedidoSoloServicioServicioE>("SELECT * FROM v_spedido_solo_servicio_servicio").ToList();
            }
        }

        public bool GuardarPedidoSoloServicioServicio(PedidoSoloServicioServicioE psss)
        {
            using (var i = new FerreteriaEntities())
            {
                return i.Database.ExecuteSqlCommand("sp_ipedido_solo_servicio_servicio ?, ?, ?, ?",
                    psss.IdPedido, psss.IdVenta, psss.Cantidad, psss.PrecioTotal) > 0;
            }
        }

        public List<PedidoClienteE> CargarPedidoCliente()
        {
            using (var i = new FerreteriaEntities())
            {
                return i.Database.SqlQuery<PedidoClienteE>("SELECT * FROM v_spedido_cliente").ToList();
            }
        }

        public bool GuardarPedidoClienteCliente(PedidoClienteE pc)
        {
            using (var i = new FerreteriaEntities())
            {
                return i.Database.ExecuteSqlCommand("sp_ipedido_cliente_cliente ?, ?, ?, ?, ?, ?",
                    pc.CedulaCliente, pc.NombreCliente, pc.Fecha,
                    pc.SubTotal, pc.IVA, pc.Total) > 0;
            }
        }

        public bool GuardarPedidoClienteBodega(PedidoClienteE pc)
        {
            using (var u = new FerreteriaEntities())
            {
                return u.Database.ExecuteSqlCommand("sp_upedido_cliente_bodega ?, ?, ?",
                    pc.Id, pc.HoraRecibidoBodega, pc.HoraSalidaBodega) > 0;
            }
        }

        public bool GuardarPedidoClienteTransporte(PedidoClienteE pc)
        {
            using (var u = new FerreteriaEntities())
            {
                return u.Database.ExecuteSqlCommand("sp_upedido_cliente_transporte ?, ?, ?, ?",
                    pc.Id, pc.CodigoConductor, pc.HoraIniciaTransporte, pc.HoraFinalizaTransporte) > 0;
            }
        }

        public bool GuardarPedidoClienteFactura(PedidoClienteE pc)
        {
            using (var u = new FerreteriaEntities())
            {
                return u.Database.ExecuteSqlCommand("sp_upedido_cliente_factura ?, ?, ?",
                    pc.Id, pc.FechaFactura, pc.CodigoCajero) > 0;
            }
        }

        public List<PedidoClienteProductoE> CargarPedidoClienteProducto()
        {
            using (var i = new FerreteriaEntities())
            {
                return i.Database.SqlQuery<PedidoClienteProductoE>("SELECT * FROM v_spedido_cliente_producto").ToList();
            }
        }

        public bool GuardarPedidoClienteProducto(PedidoClienteProductoE pcp)
        {
            using (var i = new FerreteriaEntities())
            {
                return i.Database.ExecuteSqlCommand("sp_ipedido_cliente_producto ?, ?, ?, ?",
                    pcp.IdPedido, pcp.IdVenta, pcp.Cantidad, pcp.PrecioTotal) > 0;
            }
        }

        public List<PedidoClienteServicioE> CargarPedidoClienteServicio()
        {
            using (var i = new FerreteriaEntities())
            {
                return i.Database.SqlQuery<PedidoClienteServicioE>("SELECT * FROM v_spedido_cliente_servicio").ToList();
            }
        }

        public bool GuardarPedidoClienteServicio(PedidoClienteServicioE pcs)
        {
            using (var i = new FerreteriaEntities())
            {
                return i.Database.ExecuteSqlCommand("sp_ipedido_cliente_servicio ?, ?, ?, ?",
                    pcs.IdPedido, pcs.IdVenta, pcs.Cantidad, pcs.PrecioTotal) > 0;
            }
        }
    }
}
