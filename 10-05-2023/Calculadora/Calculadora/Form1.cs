using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_n1.Text = string.Empty;
            txt_n2.Text = string.Empty;
        }

        private void btn_somar_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txt_n1.Text);
            int n2 = Convert.ToInt32(txt_n2.Text);
            int somar = (n1+n2);
            lbl_resultado.Text = ""+somar;
        }
    }
}
