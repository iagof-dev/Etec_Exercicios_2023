using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermercado_do_toto
{
    public partial class Form1 : Form
    {

        double total_compra = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string produto = txtProduto.Text;
            int Quantidade = Convert.ToInt32(txtQnt.Text);
            double valor_unitario = Convert.ToDouble(txtValorUnit.Text);

            total_compra += (Quantidade * valor_unitario);

            string adicionar = ($"{produto}/ {Quantidade} / {valor_unitario.ToString("C")}");
            lstProdutos.Items.Add(adicionar);

            lbl_total.Text = total_compra.ToString("C");

            txtProduto.Clear();
            txtQnt.Clear();
            txtValorUnit.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_total.Text = "";
            lstProdutos.Items.Clear();
            txtProduto.Clear();
            txtQnt.Clear();
            total_compra = 0;

            txtValorUnit.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
