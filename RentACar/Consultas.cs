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
    public partial class Consultas : FormBase
    {
        public Consultas()
        {
            InitializeComponent();
        }

        public DataSet LlenarDTWV (string tabla)
        {
            DataSet AGH;
            string CSM = string.Format("SELECT * FROM" + tabla);
            AGH = Miscel.Execcute(CSM);
            return AGH;
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            if (DTW.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
