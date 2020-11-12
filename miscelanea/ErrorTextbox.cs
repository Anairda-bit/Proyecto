using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miscelanea
{
    public partial class ErrorTextbox : TextBox
    {
        public ErrorTextbox()
        {
            InitializeComponent();
        }

        public Boolean Validar
        {
            set;
            get;
        }

        public Boolean OnlyNumeric
        {
            set;
            get;
        }
    }
}
