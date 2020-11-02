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
    public partial class WindowRegister : Form
    {
        public WindowRegister()
        {
            InitializeComponent();
        }
        LUsuario usuario = new LUsuario();


        private string generarCodigo()
        {

            string cedula = txtCedulaReg.Text;
            string tipo = cbxTipoUsuReg.Text;
            string codigo = "";
            if (tipo.Equals("Conductor") && cedula.Length == 9)
            {

                codigo += "CON" + Convert.ToString(cedula[6]) + Convert.ToString(cedula[7]) + Convert.ToString(cedula[8]);

            }
            else if (tipo.Equals("Constructor") && cedula.Length == 9)
            {

                codigo += "COS" + Convert.ToString(cedula[6]) + Convert.ToString(cedula[7]) + Convert.ToString(cedula[8]);

            }
            else if (tipo.Equals("Vendedor") && cedula.Length == 9)
            {

                codigo += "VEN" + Convert.ToString(cedula[6]) + Convert.ToString(cedula[7]) + Convert.ToString(cedula[8]);

            }
            else if (tipo.Equals("Cajero") && cedula.Length == 9)
            {

                codigo += "CAJ" + Convert.ToString(cedula[6]) + Convert.ToString(cedula[7]) + Convert.ToString(cedula[8]);

            }
            else
            {
                prueba.Text = "La cédula debe tener los 9 dígitos";
                return null;
            }

            return codigo;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            WindowLogin wlogin = new WindowLogin();
            wlogin.Show(this);
            this.Hide();
        }


        private void btnRegistrarReg_Click(object sender, EventArgs e)
        {
            if (generarCodigo() != null &&) {
                usuario.registrarUsuarios(generarCodigo(), txtNombreReg.Text, TxtContraReg.Text, txtCedulaReg.Text, cbxTipoUsuReg.Text);
                prueba.Text = "Registro exitoso";
            }






            
        }
    }
}
