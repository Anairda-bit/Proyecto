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
    public partial class MantVehiculo : Mantenimiento
    {
        public MantVehiculo()
        {
            InitializeComponent();
        }

        public override bool Salvare()
             /*Revisa si no hay campos vacios con el validar campos*/       {
            if (!Miscel.Convalidare(this,errorP))
            {
                /*Reecribrir el metodo del formulario base con polimorfismo para adecuarlo a la ventana mantenimiento vehiculo*/
                try
                {
                    Decimal total = Convert.ToDecimal(txtprecio.Text);
                    

                    string CSM = string.Format("EXEC ActualizarVehiculos '{0}','{1}','{2}','{3}','{4}','{5}'",
                        txtmatricula.Text.Trim(),
                        txtmarca.Text.Trim(),
                        txttipo.Text.Trim(),
                        txttrans.Text.Trim(),
                        txtpasajer.Text.Trim(),
                        total);
                    Miscel.Execcute(CSM);
                    MessageBox.Show("Se ha guardado correctamente");
                    txtmatricula.Text = "";
                    txtmarca.Text = "";
                    txttipo.Text = "";
                    txttrans.Text = "";
                    txtpasajer.Text = "";
                    txtprecio.Text = "";
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
                    string CSM = string.Format("EXEC EliminarVehiculos '{0}'", txtmatricula.Text.Trim());
                    Miscel.Execcute(CSM);
                    MessageBox.Show("Se ha eliminado correctamente");

                    txtmatricula.Text = "";

                }
                
                 catch(Exception error)
                {
                     MessageBox.Show("Se ha producido un error" + error);
                }
            
            }
    }
    
}
