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
    public partial class frmMarcas : Form
    {
        Marcas m;
        public frmMarcas()
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
            m = new Marcas()
            {
                marca = pesquisa
            };
            dgvMarcas.DataSource = m.Consultar();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty)
                return;

            m = new Marcas()
            {
                marca = txtNome.Text,
            };

            m.Incluir();

            LimparControles();
            carregarGrid("");
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty) return;

            m = new Marcas()
            {
                id = int.Parse(txtID.Text),
                marca = txtNome.Text,
            };
            m.Alterar();
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

            if (MessageBox.Show("Deseja excluir a marca?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            m = new Marcas()
            {
                id = int.Parse(txtID.Text)
            };

            m.Excluir();
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

        private void dgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMarcas.RowCount > 0)
            {
                txtID.Text = dgvMarcas.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvMarcas.CurrentRow.Cells["marca"].Value.ToString();
            }
        }
    }
}
