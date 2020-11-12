using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace miscelanea
{
    public class Miscel
    {
        public static DataSet Execcute(string CSM)
        {
            /*conexion a la base de datos*/
            SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-95J8SB8\\SQLEXPRESS;Initial Catalog=RentACar;Integrated Security=True");
            Conexion.Open();

            DataSet AGH = new DataSet();
            SqlDataAdapter SIGH = new SqlDataAdapter(CSM, Conexion);
            /*Rellenar el sqldataadapter con los datos del dataset*/
            SIGH.Fill(AGH);

            /*Cerrar la conexion para evitar problemas*/
            Conexion.Close();

            return AGH;
        }

        public static Boolean Convalidare(Control objeto, ErrorProvider errore)
        {
            Boolean Errorea = false;

            foreach(Control oggetto in objeto.Controls) 
            {
                if(oggetto is ErrorTextbox)
                {
                    ErrorTextbox objecte = (ErrorTextbox)oggetto;

                    if(objecte.Validar == true )
                    {
                        if(string.IsNullOrEmpty(objecte.Text.Trim()))
                        {
                            errore.SetError(objecte, "El campo no puede estar vacío");
                            Errorea = true;
                        }
                    }
                    if(objecte.OnlyNumeric == true)
                    {
                        int conteo = 0;
                        int Letras = 0;

                        foreach ( char lletra in objecte.Text.Trim())
                        {
                            if(char.IsLetter(objecte.Text.Trim(), conteo))
                            {
                                Letras++;
                            }
                            conteo++;
                           
                        }
                        if (Letras != 0)
                        {                    
                            errore.SetError(objecte, "Sólo se aceptan números");
                            Errorea = true;
                        }

                    }
                }
            }
            return Errorea;
        }
    }
}
