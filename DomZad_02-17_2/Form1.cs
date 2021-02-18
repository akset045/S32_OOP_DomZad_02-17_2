using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace DomZad_02_17_2
{
    public partial class Form1 : Form
    {
        double A, B;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(textBox1.Text);
            B = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (A + B).ToString();
            textBox4.Text = Math.Round(A - B, 3).ToString();
        }
    }
}
