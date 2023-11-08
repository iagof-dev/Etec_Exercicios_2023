using _221059.Models;
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
    public partial class frmCategorias : Form
    {
        Categorias c;

        public frmCategorias()
        {
            InitializeComponent();
            LimparControles();
            carregarGrid("");
        }
        void LimparControles()
        {
            txtID.Clear();
            txtNome.Clear();
            txtPesquisa.Clear();
        }
        void carregarGrid(string pesquisa)
        {
            c = new Categorias()
            {
                Categoria = pesquisa
            };
            dgvCategoria.DataSource = c.Consultar();
        }
    

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty)
                return;

            c = new Categorias()
            {
                Categoria = txtNome.Text,
            };

            c.Incluir();

            LimparControles();
            carregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty) return;

            c = new Categorias()
            {
                id = int.Parse(txtID.Text),
                Categoria = txtNome.Text,
            };
            c.Alterar();
            LimparControles();
            carregarGrid("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparControles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;

            if (MessageBox.Show("Deseja excluir a categoria?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            c = new Categorias()
            {
                id = int.Parse(txtID.Text)
            };

            c.Excluir();
            LimparControles();
            carregarGrid("");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);

        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategoria.RowCount > 0)
            {
                txtID.Text = dgvCategoria.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvCategoria.CurrentRow.Cells["categoria"].Value.ToString();
            }
        }
    }
}
