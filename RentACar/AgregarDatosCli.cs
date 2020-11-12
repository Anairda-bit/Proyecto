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
    public partial class AgregarDatosCli : Mantenimiento
    {
        public AgregarDatosCli()
        {
            InitializeComponent();
        }


       // private void INICIAR_Click(object sender, EventArgs e)
        

        private void AgregarDatosCli_Load(object sender, EventArgs e)
        {
            // nombre de la cuenta
            lbluser.Text = Registrarse.acount;
            //datos del id user
            lblduser.Text = Registrarse.idacc;
            //nombre del cliente
            lblnom.Text = Registrarse.namme;

        }

        public override bool Salvare()
        {
            /*Revisa si no hay campos vacios con el validar campos*/
            if (!Miscel.Convalidare(this, errorP))
            {
                /*Reecribrir el metodo del formulario base con polimorfismo para adecuarlo a la ventana mantenimiento vehiculo*/
                try
                {
                    string CSM = string.Format("EXEC ActualizarCliente '{0}','{1}','{2}','{3}','{4}','{5}','{6}'",
                        lblduser.Text.Trim(),
                        lblnom.Text.Trim(),
                        textap.Text.Trim(),
                        lbluser.Text.Trim(),
                        textnif.Text.Trim(),
                        textemail.Text.Trim(),
                        texttele.Text.Trim());

                    Miscel.Execcute(CSM);
                    MessageBox.Show("Se ha guardado correctamente");

                    Login Log = new Login();
                    this.Hide();
                    Log.Show();

                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("se ha producido un error al guardar" + error);

                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
