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
            label1.Visible = false;
            txtClave.Visible = false;
            label2.Visible = false;


            // Ocultar también los botones de inicio de sesión y salir si es necesario
            btnIniciarSesion.Visible = false;

            //mostrar el formulario de registro oculto
            label10.Visible = true;
            textBox7.Visible = true;
            label9.Visible = true;
            textBox6.Visible = true;
            label8.Visible = true;
            textBox5.Visible = true;
            label7.Visible = true;
            textBox4.Visible = true;
            label6.Visible = true;
            textBox3.Visible = true;
            label5.Visible = true;
            textBox2.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            checkBox1.Visible = true;
            button3.Visible = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Ocultar los TextBox de login (usuario y clave)
            txtUsuario.Visible = true;
            label1.Visible = true;
            txtClave.Visible = true;
            label2.Visible = true;

            // Ocultar también los botones de inicio de sesión y salir si es necesario
            btnIniciarSesion.Visible = true;


            //oculto el formulario de registro
            label10.Visible = false;
            textBox7.Visible = false;
            label9.Visible = false;
            textBox6.Visible = false;
            label8.Visible = false;
            textBox5.Visible = false;
            label7.Visible = false;
            textBox4.Visible = false;
            label6.Visible = false;
            textBox3.Visible = false;
            label5.Visible = false;
            textBox2.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            checkBox1.Visible = false;
            button3.Visible = false;
        }
    }
}
