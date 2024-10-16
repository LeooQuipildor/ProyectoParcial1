using EmpresaBenjaAvance.CDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace EmpresaBenjaAvance.CLogica
{
    internal class LoginL
    {
        LoginD datos = new LoginD();

        public int dni { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public DateTime fechaNac { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }

        public void agregarEmpleadoL(LoginL login)
        {
            datos.agregarEmpleadoD(login);
        }

        public bool ingresarLoginL(LoginL login)
        {
            return datos.ingresarLoginD(login);
        }
    }
}
