using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.presentación
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void nuevaRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Alta frm = new Frm_Alta();
            frm.ShowDialog();
        }

        private void consultarEditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Consulta frm = new Frm_Consulta();
            frm.ShowDialog();
        }
    }
}
