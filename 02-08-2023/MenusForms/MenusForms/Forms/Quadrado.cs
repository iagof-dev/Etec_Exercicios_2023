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
    public partial class Quadrado : Form
    {
        public Quadrado()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double calcular = Convert.ToDouble(txtbox_valor.Text);
            lbl_resultado.Text = "Resultado: " + calcular * calcular;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtbox_valor.Clear();
            lbl_resultado.Text = "Resultado: 0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f1 = new Form1();
            f1.Show();
        }
    }
}
