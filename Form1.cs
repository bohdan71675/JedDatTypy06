using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JedDatTypy06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v = 1;
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            v = a * b * c;
            double x = (double)a / 10000;
            double y = (double)b / 1000;
            double z = (double)c / 100;

            label1.Text = "Kvádr má objem " + v + "cm^3" + " = " + x + "m^3 " + y + "dm^3 " + z + "cm^3";

        }
    }
}
