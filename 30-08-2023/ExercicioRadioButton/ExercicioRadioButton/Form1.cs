using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Mas.Checked)
            {
                MessageBox.Show("Masculino");
            }
            if (Fem.Checked)
            {
                MessageBox.Show("Feminino");
            }
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String final;
            if (Mas.Checked)
                final = "o";
            else
                final = "a";

            if (rbSolteiro.Checked)
                MessageBox.Show("Solteir" + final);
            if (rbCasado.Checked)
                MessageBox.Show("Casad" + final);
            if (rbDivorc.Checked)
                MessageBox.Show("Divorciad" + final);
            if (rbCasado.Checked)
                MessageBox.Show("Casad" + final);
            if (rbViuvo.Checked)
                MessageBox.Show("Viuv" + final);

            groupBox1.Enabled = false;
            groupBox3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (chkAdmin.Checked)
                MessageBox.Show("Você cursou Administração");
            else
                MessageBox.Show("Você não cursou Administração");

            if (chbds.Checked)
                MessageBox.Show("Você cursou Desenvolvimento de Sistemas");
            else
                MessageBox.Show("Você não cursou Desenvolvimento de Sistemas");
            if (chbnutri.Checked)
                MessageBox.Show("Você cursou Nutrição");
            else
                MessageBox.Show("Você não cursou Nutrição");
            if (chblogi.Checked)
                MessageBox.Show("Você cursou Logistica");
            else
                MessageBox.Show("Você não cursou Logistica");
            if (chbedf.Checked)
                MessageBox.Show("Você cursou Edificações");
            else
                MessageBox.Show("Você não cursou Edificações");
            

            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = false;
        }
    }
}
