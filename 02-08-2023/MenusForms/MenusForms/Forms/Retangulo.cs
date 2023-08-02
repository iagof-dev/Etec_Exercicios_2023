using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenusForms.Calculos
{
    public partial class Retangulo : Form
    {
        public Retangulo()
        {
            InitializeComponent();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = "Resultado: 0";
            txt_base.Clear();
            txt_altura.Clear();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double c_base = Convert.ToDouble(txt_base.Text);
            double c_altura = Convert.ToDouble(txt_altura.Text);

            double calculado = c_base * c_altura;

            lbl_resultado.Text = "Resultado: " + calculado;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f1 = new Form1();
            f1.Show();
        }
    }
}
