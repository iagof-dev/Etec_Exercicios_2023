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

namespace _221059.Views
{
    public partial class frmCidades : Form
    {
        Cidade c;
        public frmCidades()
        {
            InitializeComponent();
        }

        void LimparControles()
        {
            txtID.Clear();
            txtNome.Clear();
            txtPesquisa.Clear();
            txtUF.Clear();
        }

        void carregarGrid(string pesquisa)
        {
            c = new Cidade()
            {
                nome = pesquisa
            };
            dgvCidades.DataSource = c.Consultar();
        }

        private void frmCidades_Load(object sender, EventArgs e)
        {
            LimparControles();
            carregarGrid("");
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty)
                return;

            c = new Cidade()
            {
                nome = txtNome.Text,
                uf = txtUF.Text
            };

            c.Incluir();

            LimparControles();
            carregarGrid("");
        }

        private void dgvCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCidades.RowCount > 0)
            {
                txtID.Text = dgvCidades.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvCidades.CurrentRow.Cells["nome"].Value.ToString();
                txtUF.Text = dgvCidades.CurrentRow.Cells["uf"].Value.ToString();
                    
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty) return;

            c = new Cidade()
            {
                id = int.Parse(txtID.Text),
                nome = txtNome.Text,
                uf = txtUF.Text
            };
            c.Alterar();
            LimparControles();
            carregarGrid("");

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;

            if (MessageBox.Show("Deseja excluir a cidade?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            c = new Cidade()
            {
                id = int.Parse(txtID.Text)
            };

            c.Excluir();
            LimparControles();
            carregarGrid("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparControles();
            carregarGrid("");

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
