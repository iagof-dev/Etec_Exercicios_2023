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
    public partial class Form1 : Form
    {

        double id_pedido = 0;
        double valor_total_produtos = 0;
        double valor_total_despesa = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_InserirPedido_Click(object sender, EventArgs e)
        {
            string cliente = txt_p_cliente.Text;
            string pedido = txt_p_pedido.Text;
            double valor = Convert.ToInt32(txt_p_valor.Text);

            valor_total_produtos += valor;
            lbl_totalpedidos.Text = valor_total_produtos.ToString("C");

            string listbox_add = ($"{pedido} / {cliente} / {valor.ToString("C")}");

            lstbox_pedidos.Items.Add(listbox_add);

            double saldo = valor_total_produtos - valor_total_despesa;
            lbl_saldo.Text = saldo.ToString("C");

            if (lbl_saldo.Text.Contains("-"))
            {
                lbl_saldo.ForeColor = Color.Red;
            }
            else
            {
                lbl_saldo.ForeColor = Color.Blue;
            }


            txt_p_cliente.Clear();
            txt_p_pedido.Clear();
            txt_p_valor.Clear();


        }

        private void btn_InserirDespesa_Click(object sender, EventArgs e)
        {
            string despesa = txt_d_despesa.Text;
            double valor = Convert.ToInt32(txt_d_valor.Text);
            valor_total_despesa += valor;
            lbl_totaldespesa.Text = valor_total_despesa.ToString("C");

            string listbox_add = ($"{despesa} / {valor.ToString("C")}");
            lstbox_despesa.Items.Add(listbox_add);

            double saldo = valor_total_produtos - valor_total_despesa;
            lbl_saldo.Text = saldo.ToString("C");
            if (lbl_saldo.Text.Contains("-"))
            {
                lbl_saldo.ForeColor = Color.Red;
            }
            else
            {
                lbl_saldo.ForeColor = Color.Blue;
            }

            txt_d_despesa.Clear();
            txt_d_valor.Clear();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 0;
            valor_total_produtos = a;
            valor_total_despesa = a;
            txt_d_despesa.Clear();
            txt_d_valor.Clear();
            txt_p_cliente.Clear();
            txt_p_pedido.Clear();
            txt_p_valor.Clear();
            lstbox_despesa.Items.Clear();
            lstbox_pedidos.Items.Clear();
            lbl_saldo.Text = a.ToString("C");
            lbl_totaldespesa.Text = a.ToString("C");
            lbl_totalpedidos.Text = a.ToString("C");
            lbl_saldo.ForeColor = Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
