﻿using System;
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
            WindowRegister wregister = new WindowRegister();
            wregister.Show(this);
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login.Login(txtUsuarioLogin.Text, txtContraLogin.Text).Tipo.Equals("Administrador"))
            {
                WindowManager wmanager = new WindowManager();
                wmanager.Show(this);
                this.Hide();
            }
            else if (login.Login(txtUsuarioLogin.Text, txtContraLogin.Text).Tipo.Equals("Cajero"))
            {
                WindowCashier frm = new WindowCashier();
                frm.ShowDialog();
            }
            else if (login.Login(txtUsuarioLogin.Text, txtContraLogin.Text).Tipo.Equals("Constructor"))
            {
                WindowBuilder frm = new WindowBuilder();
                frm.ShowDialog();
            }
            else if (login.Login(txtUsuarioLogin.Text, txtContraLogin.Text).Tipo.Equals("Conductor"))
            {
                WindowCarrier frm = new WindowCarrier();
                frm.ShowDialog();
            }
            else if (login.Login(txtUsuarioLogin.Text, txtContraLogin.Text).Tipo.Equals("Vendedor"))
            {
                u = login.Login(txtUsuarioLogin.Text, txtContraLogin.Text);
                WindowSeller frm = new WindowSeller(u);
                frm.ShowDialog();
            }
            else {
                prueba.Text = login.Login(txtUsuarioLogin.Text, txtContraLogin.Text).Tipo;
            }
        }

        private void WindowLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
