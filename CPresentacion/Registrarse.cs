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

       

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
