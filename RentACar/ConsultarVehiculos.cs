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
    public partial class ConsultarVehiculos : Consultas
    {
        public ConsultarVehiculos()
        {
            InitializeComponent();
        }

        private void ConsultarVehiculos_Load(object sender, EventArgs e)
        {

            //DTW.DataSource = LlenarDTWV("Autos").Tables[0];

        }

        private void bilatu_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txtbuscar.Text.Trim()))
            {
                try
                {
                    DataSet ARG;
                    string CSM = "SELECT * FROM Autos WHERE Marca LIKE ('%" + txtbuscar.Text.Trim() + "%')";
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
