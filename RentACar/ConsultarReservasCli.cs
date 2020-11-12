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
    public partial class ConsultarReservasCli : FormBase
    {
        public ConsultarReservasCli()
        {
            InitializeComponent();
        }

        private void ConsultarReservasCli_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentACarDataSet.Reservas' Puede moverla o quitarla según sea necesario.
            //this.reservasTableAdapter.Fill(this.rentACarDataSet.Reservas);

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            AreaCliente AreCli = new AreaCliente();
            this.Close();
            AreCli.Show();
        }

        private void bilatu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbuscar.Text.Trim()))
            {
                try
                {
                    DataSet ARG;
                    string CSM = "SELECT * FROM Reservas WHERE Id_cliente LIKE ('%" + txtbuscar.Text.Trim() + "%')";
                    ARG = Miscel.Execcute(CSM);

                    DTW.DataSource = ARG.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Se ha producido un error " + error);
                }
            }
        }
    }
}
