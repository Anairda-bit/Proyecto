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
    public partial class MantCliente : Mantenimiento    {
        public MantCliente()
        {
            InitializeComponent();
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
                        textidcli.Text.Trim(),
                        textnombre.Text.Trim(),
                        textap.Text.Trim(),
                        textuser.Text.Trim(),
                        textnif.Text.Trim(),
                        textemail.Text.Trim(),
                        texttele.Text.Trim());
                    Miscel.Execcute(CSM);
                    MessageBox.Show("Se ha guardado correctamente");
                    textidcli.Text = "";
                    textnombre.Text = "";
                    textap.Text = "";
                    textuser.Text = "";
                    textemail.Text = "";
                    texttele.Text = "";
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

        public override void Rimuovere()
        {
            /*reescribir el metodo eliminar*/

            try
            {
                string CSM = string.Format("EXEC EliminarCliente '{0}'", textidcli.Text.Trim());
                Miscel.Execcute(CSM);
                MessageBox.Show("Se ha eliminado correctamente");
                textidcli.Text = "";

            }

            catch (Exception error)
            {
                MessageBox.Show("Se ha producido un error" + error);
            }

        }







        private void MantCliente_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
