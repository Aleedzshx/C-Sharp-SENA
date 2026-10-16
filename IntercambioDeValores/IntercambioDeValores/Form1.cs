using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntercambioDeValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SideA = Convert.ToInt32(valueA.Value);
            int SideB = Convert.ToInt32(valueB.Value);

            int TempAToB = SideB;
            int TempBToA = SideA;

            label1.Text = "Valor de A: " + TempAToB.ToString();
            label2.Text = "Valor de B: " + TempBToA.ToString();
        }
    }
}
