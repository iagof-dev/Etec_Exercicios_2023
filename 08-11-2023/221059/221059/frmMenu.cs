﻿using _221059.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221059
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Banco.CriarBanco();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cd = new Views.frmCidades();
            cd.ShowDialog();
        }

        private void fafaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cm = new Views.frmMarcas();
            cm.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cc = new Views.frmCategorias();
            cc.ShowDialog();
        }
    }
}
