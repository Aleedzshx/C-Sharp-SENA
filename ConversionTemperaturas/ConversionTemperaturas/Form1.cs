using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionTemperaturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double C = Convert.ToDouble(textBox1.Text);
            double F = (C * 9/5) + 32;
            lblFah.Text = F.ToString("F2")+" °F";
            double K = C + 273.15;
            lblKel.Text = K.ToString("F2")+ "°K";

        }
    }
}
