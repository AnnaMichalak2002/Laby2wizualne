using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laby2wizualne
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        double cena;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                cena += 200;
                label1.Text = $"{cena.ToString()}";
            }
            else
            {
                cena -= 200;
                label1.Text = $"{cena.ToString()}";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cena += 400;
                label1.Text = $"{cena.ToString()}";
            }
            else
            {
                cena -= 400;
                label1.Text = $"{cena.ToString()}";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                cena += 600;
                label1.Text = $"{cena.ToString()}";
            }
            else
            {
                cena -= 600;
                label1.Text = $"{cena.ToString()}";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                cena += 300;
                label1.Text = $"{cena.ToString()}";
            }
            else
            {
                cena -= 300;
                label1.Text = $"{cena.ToString()}";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                cena += 100;
                label1.Text = $"{cena.ToString()}";
            }
            else
            {
                cena -= 100;
                label1.Text = $"{cena.ToString()}";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked)
            {
                cena += 50;
                label1.Text = $"{cena.ToString()}";
            }
            else{
                cena -= 50;
                label1.Text = $"{cena.ToString()}";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                cena += 100;
                label1.Text = $"{cena.ToString()}";
            }
            else
            {
                cena -= 100;
                label1.Text = $"{cena.ToString()}";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
