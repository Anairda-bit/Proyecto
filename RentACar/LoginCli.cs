using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using miscelanea;
using System.Windows.Forms;


namespace RentACar
{
    public partial class Login : FormBase
    {
        public Login()
        {
            InitializeComponent();
        }

        
        public static string Cod ="";
        public static string Cuenta = "";

        private void Registro_Click(object sender, EventArgs e)
        {
            Registrarse Regis = new Registrarse();
            this.Hide();
            Regis.Show();
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string CSM = string.Format("Select * FROM DatosAcc WHERE cuenta= '{0}' AND  passw= '{1}' ", txtuser.Text.Trim(), txtpass.Text.Trim());

                DataSet ARG = Miscel.Execcute(CSM);

                Cod = ARG.Tables[0].Rows[0]["id_acceso"].ToString().Trim();
                Cuenta = ARG.Tables[0].Rows[0]["cuenta"].ToString().Trim();
                string pass = ARG.Tables[0].Rows[0]["passw"].ToString().Trim();
                
               if ( Cuenta == txtuser.Text.Trim() && pass == txtpass.Text.Trim())
               {
                    AreaCliente AreaClient = new AreaCliente();
                        this.Hide();
                        AreaClient.Show();

               }
                else
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectos");

                    txtuser.Text = "";
                    txtpass.Text = "";
                    txtuser.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos, intente de nuevo");

                txtuser.Text = "";
                txtpass.Text = "";
                txtuser.Focus();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
