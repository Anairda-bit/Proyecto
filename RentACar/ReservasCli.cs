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
    public partial class ReservasCli : Mantenimiento
    {
        public ReservasCli()
        {
            InitializeComponent();
        }

        private void ReservasCli_Load(object sender, EventArgs e)
        {
            try
            {
                String CSM = "SELECT * FROM DatosClientes WHERE user_cli LIKE ('" + AreaCliente.Cuenta + "')";

                DataSet AGH = Miscel.Execcute(CSM);

                buscarcli.Text = AGH.Tables[0].Rows[0]["Id_Cliente"].ToString().Trim();
                nomcli.Text = AGH.Tables[0].Rows[0]["nom_cli"].ToString().Trim();
            }
            catch(Exception error)
            {
                MessageBox.Show("Ha ocurrido un error " + error);
            }
        }



        private void Consultar_Click(object sender, EventArgs e)
        {
            ConsultarAutosCli ConACli = new ConsultarAutosCli();
            ConACli.ShowDialog();

            if (ConACli.DialogResult == DialogResult.OK)
            {
                buscarmarca.Text = ConACli.DTW.Rows[ConACli.DTW.CurrentRow.Index].Cells[1].Value.ToString();
                lblmatricula.Text = ConACli.DTW.Rows[ConACli.DTW.CurrentRow.Index].Cells[0].Value.ToString();
                capaci.Text = ConACli.DTW.Rows[ConACli.DTW.CurrentRow.Index].Cells[4].Value.ToString();
                tipc.Text = ConACli.DTW.Rows[ConACli.DTW.CurrentRow.Index].Cells[2].Value.ToString();
                transm.Text = ConACli.DTW.Rows[ConACli.DTW.CurrentRow.Index].Cells[3].Value.ToString();
                lblprecio.Text = ConACli.DTW.Rows[ConACli.DTW.CurrentRow.Index].Cells[5].Value.ToString();
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            decimal importe = Convert.ToDecimal(lbldias.Text) * Convert.ToDecimal(lblprecio.Text);
            lbLTOTAL.Text = Convert.ToString(importe);
        }

        public override bool Salvare()
        {
            if (!Miscel.Convalidare(this, errorP))
            {

                try
                {
                    var ticks = DateTime.Now.Ticks;
                    var guid = Guid.NewGuid().ToString();
                    var uniqueSessionId = ticks.ToString() + '-' + guid;
                    string idreserva = uniqueSessionId.ToString();

                    string CSM = string.Format("EXEC Reservar '{0}','{1}','{2}','{3}','{4}','{5}'",
                       idreserva,
                       buscarcli.Text.Trim(),
                       lblmatricula.Text.Trim(),
                       fechain.Text.Trim(),
                       fechafin.Text.Trim(),
                       lbLTOTAL.Text.Trim())
                       ;

                    Miscel.Execcute(CSM);
                    MessageBox.Show("Se ha guardado correctamente");
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

        private void Btnvolver_Click(object sender, EventArgs e)
        {
            AreaCliente ArCli = new AreaCliente();
            this.Hide();
            ArCli.Show();
        }

       
    }
}
