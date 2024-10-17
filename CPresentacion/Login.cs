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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ocultar los TextBox de login (usuario y clave)
            txtUsuario.Visible = false;
            txtClave.Visible = false;

            // Ocultar también los botones de inicio de sesión y salir si es necesario
            btnIniciarSesion.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Ocultar los TextBox de login (usuario y clave)
            txtUsuario.Visible = true;
            txtClave.Visible = true;

            // Ocultar también los botones de inicio de sesión y salir si es necesario
            btnIniciarSesion.Visible = true;
        }
    }
}
