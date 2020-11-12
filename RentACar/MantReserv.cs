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
    public partial class MantReserv : Mantenimiento
    {
        public MantReserv()
        {
            InitializeComponent();
        }

        private void MantReserv_Load(object sender, EventArgs e)
        {

        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            ConsultarReservas ConRe = new ConsultarReservas();
            ConRe.ShowDialog();

            if(ConRe.DialogResult == DialogResult.OK)
            {
                lblidreserv.Text = ConRe.DTW.Rows[ConRe.DTW.CurrentRow.Index].Cells[0].Value.ToString();
                buscarcli.Text = ConRe.DTW.Rows[ConRe.DTW.CurrentRow.Index].Cells[1].Value.ToString();
                lblmatricula.Text = ConRe.DTW.Rows[ConRe.DTW.CurrentRow.Index].Cells[2].Value.ToString();
                fechain.Text = ConRe.DTW.Rows[ConRe.DTW.CurrentRow.Index].Cells[3].Value.ToString();
                fechafin.Text = ConRe.DTW.Rows[ConRe.DTW.CurrentRow.Index].Cells[4].Value.ToString();
                lbLTOTAL.Text = ConRe.DTW.Rows[ConRe.DTW.CurrentRow.Index].Cells[5].Value.ToString();
            }
        }

        public override void Rimuovere()
        {
            try
            {
                string CSM = string.Format("EXEC ELiminarReserva '{0}'", lblidreserv.Text.Trim());
                Miscel.Execcute(CSM);
                MessageBox.Show("Se ha eliminado correctamente");


            }

            catch (Exception error)
            {
                MessageBox.Show("Se ha producido un error" + error);
            }
        }
    }
}
