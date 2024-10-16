using EmpresaBenjaAvance.CLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaBenjaAvance.CPresentacion
{
    public partial class Registrarse : Form
    {
        LoginL loginL = new LoginL();

        public Registrarse()
        {
            InitializeComponent();
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
            loginL.usuario = txtUsuario.Text;
            loginL.clave = txtClave.Text;

            loginL.agregarEmpleadoL(loginL);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
