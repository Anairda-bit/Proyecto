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
    public partial class ConsultarReservas : Consultas
    {
        public ConsultarReservas()
        {
            InitializeComponent();
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
