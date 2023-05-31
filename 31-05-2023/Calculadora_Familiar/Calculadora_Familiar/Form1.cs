using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Familiar
{
    public partial class Form1 : Form
    {

        double media = 0;
        public Form1()
        {
            InitializeComponent();
            lblSituacao.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                int n1 = Convert.ToInt32(textBox1.Text);
                int n2 = Convert.ToInt32(textBox2.Text);
                int n3 = Convert.ToInt32(textBox3.Text);
                media = (n1 + n2 + n3) / 3;
                lblMedia.Text = media.ToString();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSituacao_Click(object sender, EventArgs e)
        {
            if (media >= 5)
            {
                lblSituacao.ForeColor= Color.Green;
                lblSituacao.Text= "APROVADO";
            }
            if (media < 5)
            {
                lblSituacao.ForeColor = Color.Red;
                lblSituacao.Text = "REPROVADO";
            }
            lblSituacao.Visible = true;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            lblSituacao.Visible = false;
            lblMedia.Text = "0";
        }
    }
}
