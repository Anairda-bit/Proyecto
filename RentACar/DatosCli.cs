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
    public partial class DatosCli : FormBase
    {
        public DatosCli()
        {
            InitializeComponent();
        }

        private void VOLVER_Click(object sender, EventArgs e)
        {
            AreaCliente ArReCli = new AreaCliente();
            this.Hide();
            ArReCli.Show();
        }

        private void datosCli_Load(object sender, EventArgs e)
        {
           try
            {
                String CSM = "SELECT * FROM DatosClientes WHERE user_cli LIKE ('" + AreaCliente.Cuenta + "')"; 

                DataSet AGH = Miscel.Execcute(CSM);

                lblnom.Text = AGH.Tables[0].Rows[0]["nom_cli"].ToString().Trim();
                lblap.Text = AGH.Tables[0].Rows[0]["ap_cli"].ToString().Trim();
                lblnif.Text = AGH.Tables[0].Rows[0]["nif_cli"].ToString().Trim();
                lbluser.Text = AGH.Tables[0].Rows[0]["user_cli"].ToString().Trim();
                lblemail.Text = AGH.Tables[0].Rows[0]["email_cli"].ToString().Trim();
                lblduser.Text = AGH.Tables[0].Rows[0]["Id_Cliente"].ToString().Trim();
                lbltel.Text = AGH.Tables[0].Rows[0]["tel_cli"].ToString().Trim();

            }
            catch(Exception error)
            {
                MessageBox.Show("Se ha producido un error" + error);
            }
        }
    }
}
