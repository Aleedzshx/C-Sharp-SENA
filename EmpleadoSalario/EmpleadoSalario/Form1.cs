using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadoSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           String name =  Convert.ToString(textBox1.Text);
            double hourlywage = Convert.ToDouble(textBox2.Text);
            double hoursworked = Convert.ToDouble(textBox3.Text);
            double Total = hourlywage * hoursworked;

            label5.Text = "Empleado: " + name + "\nSalario Total: " + Total.ToString("C") + "\nSus Horas Trabajadas: " + hoursworked.ToString() + "\nSu Salario por Hora: " + hourlywage.ToString("C");
        }
    }
}
