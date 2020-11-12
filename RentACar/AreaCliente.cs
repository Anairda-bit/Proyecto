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
    public partial class AreaCliente : FormBase
    {

        public AreaCliente()
        {
            InitializeComponent();
        }

        public static string Cuenta = "";
        
        private void AreaReservasCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatosCli DatCli = new DatosCli();
            this.Hide();
            DatCli.Show();
        }

        private void AreaReservasCliente_Load(object sender, EventArgs e)
        {


            NAME.Text = Login.Cuenta;
            Cuenta = NAME.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarReservasCli ConRe = new ConsultarReservasCli();
            this.Hide();
            ConRe.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReservasCli ReCli = new ReservasCli();
            this.Hide();
            ReCli.Show();
        }
    }
}
