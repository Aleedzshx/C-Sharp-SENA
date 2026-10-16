using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Perimetro_Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double SideA = Convert.ToDouble(numericUpDown1.Value);
            double SideB = Convert.ToDouble(numericUpDown2.Value);
            double Area = SideA * SideB;
            double Perimetro = 2*SideA + 2* SideB;
            lblarea.Text =  Area.ToString() + "cm²";
            lblperimetro.Text = Perimetro.ToString() + "cm";
        }
    }
}
