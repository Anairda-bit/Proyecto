using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using miscelanea;

namespace RentACar
{
    public partial class Presentacion : FormBase
    {
        public Presentacion()
        {
            InitializeComponent();
        }

        private void INICIAR_Click(object sender, EventArgs e)
        {
            try
            {

                /*llamar a la siguiente ventana*/
                Login Logs = new Login();
                this.Hide();
                Logs.Show();

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error" + error.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginEmpl LogEmp = new LoginEmpl();
            this.Hide();
            LogEmp.Show();
        }

        //private void UBICACIÓN_Click(object sender, EventArgs e)
        
    }
}
