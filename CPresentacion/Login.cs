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
            txtClaveR.Visible = true;
            label9.Visible = true;
            txtUsuarioR.Visible = true;
            label8.Visible = true;
            txtFecha.Visible = true;
            label7.Visible = true;
            txtTelefono.Visible = true;
            label6.Visible = true;
            txtdni.Visible = true;
            label5.Visible = true;
            txtApellido.Visible = true;
            label4.Visible = true;
            txtNombre.Visible = true;
            checkBox1.Visible = true;
            btnCrearUsuario.Visible = true;
            txtFecha.Visible = true;
            txtMes.Visible = true;
            txtAño.Visible = true;

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
            txtClaveR.Visible = false;
            label9.Visible = false;
            txtUsuarioR.Visible = false;
            label8.Visible = false;
            txtFecha.Visible = false;
            label7.Visible = false;
            txtTelefono.Visible = false;
            label6.Visible = false;
            txtdni.Visible = false;
            label5.Visible = false;
            txtApellido.Visible = false;
            label4.Visible = false;
            txtNombre.Visible = false;
            checkBox1.Visible = false;
            btnCrearUsuario.Visible = false;
            txtFecha.Visible = false;
            txtMes.Visible = false;
            txtAño.Visible = false;
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            // "22/02/2005"
            string fecha = txtFecha.Text + "/" + txtMes.Text + "/" + txtAño.Text;

            loginL.dni = Convert.ToInt32(txtdni.Text);
            loginL.apellido = txtApellido.Text;
            loginL.nombre = txtNombre.Text;
            loginL.telefono = txtTelefono.Text;
            loginL.fechaNac = DateTime.Parse(fecha);
            loginL.usuario = txtUsuarioR.Text;
            loginL.clave = txtClaveR.Text;

            loginL.agregarEmpleadoL(loginL);
        }
    }
}
