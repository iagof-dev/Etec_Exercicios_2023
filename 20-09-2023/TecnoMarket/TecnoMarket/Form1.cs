using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnoMarket
{
    public partial class Form1 : Form
    {

        int venda = 1;

        double valor = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public static bool IsNumeric(object Expression)
        {
            double retNum;
            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (!IsNumeric(txt_valorunit.Text))
                return;
            if (!IsNumeric(txt_quant.Text))
                return;

            dgv_Lista.Rows.Add(txt_desc.Text, txt_quant.Text, txt_valorunit.Text);
            txt_total.Text = dgv_Lista.Rows.Count.ToString();

            double valor_total = (Convert.ToDouble(txt_valorunit.Text) * Convert.ToDouble(txt_quant.Text));

            valor += valor_total;
            txt_total.Text = valor.ToString("c");

            txt_desc.Clear();
            txt_quant.Clear();
            txt_valorunit.Clear();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja remover o item selecionado?", "Remoção de item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes)
                return;

            //Console.WriteLine(dgv_Lista.CurrentRow.Cells[2].Value);

            double valor_a_retirar = Convert.ToDouble(dgv_Lista.CurrentRow.Cells[2].Value);

            valor -= valor_a_retirar;


            txt_total.Text = valor.ToString("c");

            dgv_Lista.Rows.RemoveAt(dgv_Lista.CurrentRow.Index);
            txt_total.Text = dgv_Lista.Rows.Count.ToString();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja alterar?", "Alteração de Item de item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr != DialogResult.Yes)
                return;

            double valor_unit = Convert.ToDouble(dgv_Lista.CurrentRow.Cells[2].Value);

            dgv_Lista.CurrentRow.Cells[1].Value = txt_qntitemselected.Text;

            double novo_valor = valor_unit * Convert.ToDouble(txt_qntitemselected.Text);

            dgv_Lista.CurrentRow.Cells[2].Value = novo_valor;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem certeza que deseja cancelar a venda?", "Cancelamento da venda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes)
                return;

            dgv_Lista.Rows.Clear();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (dgv_Lista.Rows.Count < 1)
            {
                MessageBox.Show("Nenhum produto foi adicionado", "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgv_Lista.Rows.Clear();
            MessageBox.Show("Venda gravada com sucesso!", "Gravação de venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            venda++;
            txt_id.Text = venda.ToString();
            txt_desc.Clear();
            txt_quant.Clear();
            txt_valorunit.Clear();
            txt_qntitemselected.Clear();
        }

        private void dgv_Lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_qntitemselected.Text = dgv_Lista.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
