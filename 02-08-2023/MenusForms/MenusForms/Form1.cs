using MenusForms.Calculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenusForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form retangulo = new Retangulo();
            retangulo.Show();
        }

        private static readonly Random rand = new Random();

        private Color GetRandomColour()
        {
            return Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.ForeColor = GetRandomColour();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Quadrado_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form quadrado = new Quadrado();
            quadrado.Show();
        }
    }
}
