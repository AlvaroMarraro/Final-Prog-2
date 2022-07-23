﻿using ABMTelefonos.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMTelefonos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelefonoForm form = new TelefonoForm();
            form.ShowDialog();
        }

        private void consultaEditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelefonoForm form = new TelefonoForm();
            form.ShowDialog();
        }
    }
}
