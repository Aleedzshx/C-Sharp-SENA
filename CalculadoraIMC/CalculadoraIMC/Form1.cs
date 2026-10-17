using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(weight.Text);
            double altura = double.Parse(height.Text);
            double imc = peso / (altura * altura);
            lblIMC.Text = "Su IMC es: " + imc.ToString("F2");

            if (imc < 18.5)
            {
                lblCategoria.Text = "Nuestro Diagnostico Es > Bajo peso";
            }
            else if (imc < 25)
            {
                lblCategoria.Text = "Nuestro Diagnostico Es > Peso normal";
            }
            else if (imc < 30)
            {
                lblCategoria.Text = "Nuestro Diagnostico Es > Sobrepeso";
            }
            else
            {
                lblCategoria.Text = "Nuestro Diagnostico Es > Obesidad";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            weight.Text = "";
            lblIMC.Text = "";
            height.Text = "";
            lblCategoria.Text = "";
        }
    }   
}
