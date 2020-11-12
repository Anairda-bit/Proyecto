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
    public partial class Reservas : Mantenimiento
    {
        public Reservas()
        {
            InitializeComponent();
        }

        private void errorTextbox1_TextChanged(object sender, EventArgs e)
        {

        }
        // private void MisDatosCli_Click(object sender, EventArgs e)
        //private void Buscare_Click(object sender, EventArgs e)      
        //private void Consultar_Click(object sender, EventArgs e)
        // private void serchi_Click(object sender, EventArgs e)




        private void button2_Click(object sender, EventArgs e)
        {
           
            
                ConsultarClientes Concli = new ConsultarClientes();
                Concli.ShowDialog();

                if (Concli.DialogResult == DialogResult.OK)
                {
                    buscarcli.Text = Concli.DTW.Rows[Concli.DTW.CurrentRow.Index].Cells[0].Value.ToString();
                    nomcli.Text = Concli.DTW.Rows[Concli.DTW.CurrentRow.Index].Cells[1].Value.ToString();
                }
           
        }

        private void ConsuAut_Click(object sender, EventArgs e)
        {
            ConsultarVehiculos CoAut = new ConsultarVehiculos();
            CoAut.ShowDialog();

            if(CoAut.DialogResult == DialogResult.OK)
            {
                buscarmarca.Text = CoAut.DTW.Rows[CoAut.DTW.CurrentRow.Index].Cells[1].Value.ToString();
                lblmatricula.Text = CoAut.DTW.Rows[CoAut.DTW.CurrentRow.Index].Cells[0].Value.ToString();
                capaci.Text = CoAut.DTW.Rows[CoAut.DTW.CurrentRow.Index].Cells[4].Value.ToString();
                tipc.Text = CoAut.DTW.Rows[CoAut.DTW.CurrentRow.Index].Cells[2].Value.ToString();
                transm.Text = CoAut.DTW.Rows[CoAut.DTW.CurrentRow.Index].Cells[3].Value.ToString();
                lblprecio.Text = CoAut.DTW.Rows[CoAut.DTW.CurrentRow.Index].Cells[5].Value.ToString();
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

      
        
            
  
        

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuovo();
        }

        

        public override void Nuovo()
        {
            buscarcli.Text = "";
            nomcli.Text = "Cliente";
            buscarmarca.Text = "";
            lblmatricula.Text = "Matricula";
            capaci.Text = "";
            tipc.Text = "";
            transm.Text = "";
            lblprecio.Text = "";
            lbLTOTAL.Text = "";
        }

        
        

        
    }
}
