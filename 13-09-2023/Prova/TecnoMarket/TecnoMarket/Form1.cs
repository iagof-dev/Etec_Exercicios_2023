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
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja remover o item selecionado?", "Remoção de item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes)
                return;

            dgv_Lista.Rows.RemoveAt(dgv_Lista.CurrentRow.Index);
            txt_total.Text = dgv_Lista.Rows.Count.ToString();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

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

        }
    }
}
