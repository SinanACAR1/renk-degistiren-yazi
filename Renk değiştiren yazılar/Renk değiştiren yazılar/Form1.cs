using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yanıp_sonen_yazılar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int a = rand.Next(0, 255);
            int b = rand.Next(0, 255);
            int c = rand.Next(0, 255);
            label1.ForeColor = Color.FromArgb(c,b,a); //yazı rengi
            label1.BackColor = Color.FromArgb(a, b, c); //yazı arka plan rengi
        }
    }
}
