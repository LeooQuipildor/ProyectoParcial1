using EmpresaBenjaAvance.CLogica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Windows.Forms;

namespace EmpresaBenjaAvance.CDatos
{
    internal class LoginD
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-E7A0TP3\\SQLEXPRESS; database=EMPRESA2; integrated security=true");

        SqlCommand comando;
        SqlDataReader leer;

        // AGREGAR EMPLEADO
        public void agregarEmpleadoD(LoginL login)
        {
            string consulta = "SELECT COUNT(*) FROM Empleados WHERE usuario = @usuario";
            string añadirEmpleado = "INSERT INTO Empleados (dni, apellido, nombre, telefono, fechaNac, usuario, clave)" +
                "VALUES (@dni, @apellido, @nombre, @telefono, @fechaNac, @usuario, @clave)";

            conexion.Open();

            comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@usuario", login.usuario);

            int count = (int)comando.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Nombre de usuario existente, por favor ingrese otro");
            }
            else
            {
                comando = new SqlCommand(añadirEmpleado, conexion);
                comando.Parameters.AddWithValue("@dni", login.dni);
                comando.Parameters.AddWithValue("@apellido", login.apellido);
                comando.Parameters.AddWithValue("@nombre", login.nombre);
                comando.Parameters.AddWithValue("@telefono", login.telefono);
                comando.Parameters.AddWithValue("@fechaNac", login.fechaNac);
                comando.Parameters.AddWithValue("@usuario", login.usuario);
                comando.Parameters.AddWithValue("@clave", login.clave);
                comando.ExecuteNonQuery();
                MessageBox.Show("Empleado añadido");
            }

            conexion.Close();
        }

        // INGREASAR LOGIN
        public bool ingresarLoginD(LoginL login)
        {
            string consulta = "SELECT usuario, clave FROM Empleados WHERE usuario = @usuario AND clave = @clave";

            conexion.Open();

            comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@usuario", login.usuario);
            comando.Parameters.AddWithValue("@clave", login.clave);

            leer = comando.ExecuteReader();

            if (leer.Read())
            {
                conexion.Close();
                return true;
            }
            else
            {
                conexion.Close();
                return false;
            }
        }
    }
}
