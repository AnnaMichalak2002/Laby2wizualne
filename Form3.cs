﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Action<double> SaveMonitorPrice { get; internal set; }
        private void button1_Click(object sender, EventArgs e)
        {
            this.SaveMonitorPrice(cena);
            this.Close();
        }
        private double cena = 0;
        
        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            var info = listView1.HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                var row = info.Item.Index;
                string priceText = listView1.Items[row].SubItems[2].Text;
                label2.Text = priceText;
                if (Int32.TryParse(priceText, out int newPrice))
                    cena = newPrice;
            }

        } 
    }
}
