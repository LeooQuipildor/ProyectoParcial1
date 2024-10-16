using EmpresaBenjaAvance.CLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaBenjaAvance.CPresentacion
{
    public partial class Login : Form
    {
        LoginL loginL = new LoginL();

        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            loginL.usuario = txtUsuario.Text;
            loginL.clave = txtClave.Text;

            if (loginL.ingresarLoginL(loginL))
            {
                Principal principal = new Principal();
                principal.FormClosed += (s, args) => this.Show();
                this.Hide();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Error en clave o usuario");
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registrarse registrarse = new Registrarse();

            registrarse.ShowDialog();
        }
    }
}
