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
    public partial class ConsultarAutosCli : FormBase
    {
        public ConsultarAutosCli()
        {
            InitializeComponent();
        }

        private void bilatu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttipo.Text.Trim()))
            {
                try
                {
                    DataSet ARG;
                    string CSM = "SELECT * FROM Autos WHERE Tipo LIKE ('%" + txttipo.Text.Trim() + "%')";
                    ARG = Miscel.Execcute(CSM);

                    DTW.DataSource = ARG.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Se ha producido un error " + error);
                }
            }
        }

        private void btnconsultare_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttrans.Text.Trim()))
            {
                try
                {
                    DataSet ARG;
                    string CSM = "SELECT * FROM Autos WHERE Trasmision LIKE ('%" + txttrans.Text.Trim() + "%')";
                    ARG = Miscel.Execcute(CSM);

                    DTW.DataSource = ARG.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Se ha producido un error " + error);
                }
            }
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            if (DTW.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
