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
    public partial class Registrarse : Mantenimiento
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        public static string namme = "";
        public static string acount = "";
        public static string idacc = "";

        public override Boolean Salvare()
        {
            /*Revisa si no hay campos vacios con el validar campos*/
            
                if (!Miscel.Convalidare(this, errorP))
                {
                /*Reecribrir el metodo del formulario base con polimorfismo para adecuarlo a la ventana mantenimiento vehiculo*/

             
                  try
                    {
                       //nombre del cliente
                        namme = txtnombre.Text.Trim();
                        //nombre de usuario
                        acount = txtusuario.Text.Trim();
                       //id de usuario
                        idacc = txtacc.Text.Trim();


                        string CSM = string.Format("EXEC ActualizarUsuarios '{0}','{1}','{2}','{3}'",
                            txtacc.Text.Trim(),
                            txtnombre.Text.Trim(),
                            txtusuario.Text.Trim(),
                            txtpass.Text.Trim()            
                            );          
                                              
                        Miscel.Execcute(CSM);

                        MessageBox.Show("Se ha Registrado correctamente");

                    
                        AgregarDatosCli ADC = new AgregarDatosCli();
                        this.Hide();
                        ADC.Show();

                        return true;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("se ha producido un error al registrarse" + error);

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
