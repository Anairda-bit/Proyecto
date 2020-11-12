using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using miscelanea;

namespace RentACar
{
    public partial class AreaEmpleados : FormBase
    {
        public AreaEmpleados()
        {
            InitializeComponent();
        }

        private void AreaEmpleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        } 

        private void AreaEmpleados_Load(object sender, EventArgs e)
        {
            NAME.Text = LoginEmpl.Cuenta;
        }

        private void ContenPri_Click(object sender, EventArgs e)
        {
            ContPrincipal ContenedorP = new ContPrincipal();
            this.Hide();
            ContenedorP.Show(); 
        }

        private void btnpresentacion_Click(object sender, EventArgs e)
        {
            Presentacion pre = new Presentacion();
            this.Hide();
            pre.Show();
        }
    }
}
