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

        public WindowCarrier(UsuarioE u)
        {
            InitializeComponent();
            pl = new PedidoL();
            this.u = u;
            dgvTransportes.Columns[0].ValueType = typeof(object);
            CargarPedidos();
        }

        private void CargarPedidos()
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

        private void btnAgregarInicio_Click(object sender, EventArgs e)
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
            CargarPedidos();
        }

        private void btnAgregarFin_Click(object sender, EventArgs e)
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
            CargarPedidos();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
