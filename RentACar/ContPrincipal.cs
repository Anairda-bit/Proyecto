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
    public partial class ContPrincipal : Form
    {
        private int childFormNumber = 0;

        public ContPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                /*string FileName = openFileDialog.FileName;*/
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
               /* string FileName = saveFileDialog.FileName;*/
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantVehiculo MVeh = new MantVehiculo();
            MVeh.MdiParent = this;
            MVeh.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantCliente MCli = new MantCliente();
            MCli.MdiParent = this;
            MCli.Show();
        }

        private void ContPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarVehiculos ConV = new ConsultarVehiculos();
            ConV.MdiParent = this;
            ConV.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarClientes ConCli = new ConsultarClientes();
            ConCli.MdiParent = this;
            ConCli.Show();
        }

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservas rese = new Reservas();
            rese.MdiParent = this;
            rese.Show();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarReservas ConRe = new ConsultarReservas();
            ConRe.MdiParent = this;
            ConRe.Show();
        }

        private void reservasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MantReserv mantre = new MantReserv();
            mantre.MdiParent = this;
            mantre.Show();
        }
    }
}
