using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_MEDIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResultado.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(lblN1.Text);
            int n2 = Convert.ToInt32(lblN2.Text);
            int n3 = Convert.ToInt32(lblN3.Text);
            int media = (n1+n2+n3)/3;
            lblResultado.Text = $"A media do {lblNome.Text} é: {media}";
            lblResultado.Visible=true;
        }
    }
}
