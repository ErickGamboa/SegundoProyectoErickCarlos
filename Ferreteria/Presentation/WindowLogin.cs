using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Presentation
{
    public partial class WindowLogin : Form
    {
        public WindowLogin()
        {
            InitializeComponent();
        }
        LLogin login = new LLogin();
        private void label3_Click(object sender, EventArgs e)
        {
            WindowRegister wregister = new WindowRegister();
            wregister.Show(this);
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login.Login(txtUsuarioLogin.Text, txtContraLogin.Text).Equals("Administrador"))
            {
                WindowManager wmanager = new WindowManager();
                wmanager.Show(this);
                this.Hide();
            }
            else if (login.Login(txtUsuarioLogin.Text, txtContraLogin.Text).Equals("Cajero"))
            {
                prueba.Text = "caje";
            }
            else if (login.Login(txtUsuarioLogin.Text, txtContraLogin.Text).Equals("Constructor"))
            {
                prueba.Text = "constructor";
            }
            else if (login.Login(txtUsuarioLogin.Text, txtContraLogin.Text).Equals("Conductor"))
            {
                prueba.Text = "conductor";
            }
            else if (login.Login(txtUsuarioLogin.Text, txtContraLogin.Text).Equals("Venedor"))
            {
                prueba.Text = "vendedor";
            }
            else {
                prueba.Text = login.Login(txtUsuarioLogin.Text, txtContraLogin.Text);
            }
        }
    }
}
