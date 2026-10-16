using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(firstgrade.Text);
            double nota2 = Convert.ToDouble(secondgrade.Text);
            double nota3 = Convert.ToDouble(thirdgrade.Text);
            double nota4 = Convert.ToDouble(fourthgrade.Text);
            double nota5 = Convert.ToDouble(fifthgrade.Text);

            double promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

            lblprom .Text = promedio.ToString();
        }
    }
}
