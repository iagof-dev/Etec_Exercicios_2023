using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rm221059
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string pizza = "";
            double pizza_valor = 0;

            string borda = "Sem";
            double borda_valor = 0;

            string refri = "";
            double refri_valor = 0;

            string sucos = "";
            double sucos_valor = 0;

            if (pz_mdcasa.Checked)
            {
                pizza = "A Moda da Casa";
                pizza_valor = 17.5;
            }
            if (pz_atum.Checked)
            {
                pizza = "Atum";
                pizza_valor = 17.85;
            }
            if (pz_baiana.Checked)
            {
                pizza = "Baiana";
                pizza_valor = 16.1;
            }
            if (pz_brocolis.Checked)
            {
                pizza = "Brocolis";
                pizza_valor = 12;
            }
            if (pz_calabresa.Checked)
            {
                pizza = "Calabresa";
                pizza_valor = 20.5;
            }
            if (pz_mussarela.Checked)
            {
                pizza = "Mussarela";
                pizza_valor = 16.7;
            }
            if (pz_4quejos.Checked)
            {
                pizza = "4 Queijos";
                pizza_valor = 15.5;
            }
            if (pz_strognoff.Checked)
            {
                pizza = "Strognoff";
                pizza_valor = 22.75;
            }
            //BORDA

            if (bd_sem.Checked)
                borda_valor = 0;
            if (bd_catupiry.Checked)
            {
                borda = "Catupiry";
                borda_valor = 3.45;
            }
            if (bd_cheddar.Checked)
            {
                borda = "Cheddar";
                borda_valor = 4.65;
            }

            //Refrigerantes
            if (rf_cervejag.Checked)
            {
                refri = "Cerveja Garrafa";
                refri_valor += 5.50;
            }
            if (rf_cervejal.Checked)
            {
                refri = "Cerveja Lata";
                refri_valor += 4;
            }
            if (cj_cocalata.Checked)
            {
                refri = "Coca-Cola Lata";
                refri_valor += 3.50;
            }
            if (cj_cocalitro.Checked)
            {
                refri = "Coca-Cola Litro";
                refri_valor += 5.10;
            }
            if (cj_guaranalata.Checked)
            {
                refri = "Guaraná Lata";
                refri_valor += 2.85;
            }
            if (cj_guaranalitro.Checked)
            {
                refri = "Guaraná litro";
                refri_valor += 3.5;
            }

            //Sucos
            if (sc_abacaxic.Checked)
            {
                sucos = "Suco abacaxi Copo";
                sucos_valor += 4.2;
            }
            if (sc_abacaxij.Checked)
            {
                sucos = "Suco abacaxi Jarra";
                sucos_valor += 6.05;
            }
            if (sc_larancopo.Checked)
            {
                sucos = "Suco laranja Copo";
                sucos_valor += 4.25;
            }
            if (sc_laranjajarra.Checked)
            {
                sucos = "Suco laranja Jarra";
                sucos_valor += 6.3;
            }
            if (sc_maracujacopo.Checked)
            {
                sucos = "Suco Maracuja Copo";
                sucos_valor += 4.1;
            }
            if (sc_maracujajarra.Checked)
            {
                sucos = "Suco Maracuja Jarra";
                sucos_valor += 6.5;
            }

            double soma = (borda_valor + pizza_valor + refri_valor + sucos_valor);
            MessageBox.Show("Bom dia " + textBox1.Text + "\n\nPizza: " + pizza + " = " + pizza_valor.ToString("c") + "\n\nBorda: " + borda + " = " + borda_valor.ToString("c") + "\n\nBebida: " + refri + " = " + refri_valor.ToString("c") + "\n\nSuco: " + sucos + " = "+ sucos_valor.ToString("c") + "\n\nTotal da Fatura: R$ "+ soma.ToString("c"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
