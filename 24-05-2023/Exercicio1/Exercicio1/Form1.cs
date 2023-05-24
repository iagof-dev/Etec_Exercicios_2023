using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double RendaFam = Convert.ToInt32(txt_renda.Text);
            double Energia_eletrica = Convert.ToInt32(txt_energia.Text);
            double agua = Convert.ToInt32(txt_agua.Text);
            double tvfone = Convert.ToInt32(txtTV.Text);
            double alimentacao = Convert.ToInt32(txtAlimentacao.Text);
            double outros_Gastos = Convert.ToInt32(txtOutros.Text);

            double total_gastos = (Energia_eletrica+agua+tvfone+alimentacao+outros_Gastos);

            lbl_gastos.Text = total_gastos.ToString("C");
            double saldo_novo = (RendaFam - total_gastos);

            lblSAldo.Text = saldo_novo.ToString("C");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt_renda.Clear();
            txt_energia.Clear();
            txt_agua.Clear();
            txtTV.Clear();
            txtAlimentacao.Clear();
            txtOutros.Clear();
            txtAlimentacao.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

       
    }
}
