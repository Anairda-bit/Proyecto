using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class Mantenimiento : FormBase
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            Consultare();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Salvare();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Rimuovere();
        }
    }
}
