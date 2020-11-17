using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Logic;

namespace Presentation
{
    public partial class WindowLogin : Form
    {
        private UsuarioE u;
        public WindowLogin()
        {
            InitializeComponent();
            u = new UsuarioE();
        }
        LLogin login = new LLogin();
        private void label3_Click(object sender, EventArgs e)
        {
            WindowRegister.InstanciaAgregar.MdiParent = this;
            splitContainer.Panel1.Controls.Add(WindowRegister.InstanciaAgregar);
            WindowRegister.InstanciaAgregar.Show();
        }

        private void Limpiar()
        {
            txtUsuarioLogin.Clear();
            txtContraLogin.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowClient frm = new WindowClient();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (login.Login(txtUsuarioLogin.Text, txtContraLogin.Text).Tipo.Equals("Administrador"))
                {
                    WindowManager frm = new WindowManager();
                    frm.ShowDialog();
                    Limpiar();
                }
                else if (login.Login(txtUsuarioLogin.Text, txtContraLogin.Text).Tipo.Equals("Cajero"))
                {
                    u = login.Login(txtUsuarioLogin.Text, txtContraLogin.Text);
                    WindowCashier frm = new WindowCashier(u);
                    frm.ShowDialog();
                    Limpiar();
                }
                else if (login.Login(txtUsuarioLogin.Text, txtContraLogin.Text).Tipo.Equals("Constructor"))
                {
                    u = login.Login(txtUsuarioLogin.Text, txtContraLogin.Text);
                    WindowBuilder frm = new WindowBuilder(u);
                    frm.ShowDialog();
                    Limpiar();
                }
                else if (login.Login(txtUsuarioLogin.Text, txtContraLogin.Text).Tipo.Equals("Conductor"))
                {
                    u = login.Login(txtUsuarioLogin.Text, txtContraLogin.Text);
                    WindowCarrier frm = new WindowCarrier(u);
                    frm.ShowDialog();
                    Limpiar();
                }
                else if (login.Login(txtUsuarioLogin.Text, txtContraLogin.Text).Tipo.Equals("Vendedor"))
                {
                    u = login.Login(txtUsuarioLogin.Text, txtContraLogin.Text);
                    WindowSeller frm = new WindowSeller(u);
                    frm.ShowDialog();
                    Limpiar();
                }
            }
            catch (Exception ex) {
                prueba.Text = ex.Message;
            }
        }

        private void WindowLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
