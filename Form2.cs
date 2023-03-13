using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laby2wizualne
{
    public partial class Form2 : Form
    {
     
        public Form2()
        {
            InitializeComponent();
        }


        public Action<double> SaveComputerPrice { get; internal set; }
        private void button2_Click(object sender, EventArgs e)
        {
            this.SaveComputerPrice(cena);
            this.Close();
        }

        private double cena = 0;

        

        private void calculatePrice()
        {
            cena = 0;
            if (radioButton1.Checked)
            {
                cena += 200;
            }
            if (radioButton2.Checked)
            {
                cena += 400;
            }
            if (radioButton3.Checked)
            {
                cena += 600;
            }
            if (checkBox1.Checked)
            {
                cena += 300;
            }
            if (checkBox2.Checked)
            {
                cena += 100;
            }
            if (checkBox3.Checked)
            {
                cena += 50;
            }
            if (checkBox4.Checked)
            {
                cena += 100;
            }

            if ((comboBox1.SelectedItem as dynamic) != null)
            {
                int val = (comboBox1.SelectedItem as dynamic).Value;
                if (val > 0)
                {
                    cena += val;
                }
            }

            label1.Text = $"{cena.ToString()}";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            calculatePrice();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            calculatePrice();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            calculatePrice();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            calculatePrice();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            calculatePrice();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            calculatePrice();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            calculatePrice();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculatePrice();
        }
    }
}
