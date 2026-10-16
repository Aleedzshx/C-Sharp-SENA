using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionDeSegundos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void segundos_ValueChanged(object sender, EventArgs e)
        {
            int seconds = Convert.ToInt32(segundos.Value);
            int minutes = (seconds % 3600) / 60;
            int hours = seconds / 3600;

            print.Text = $" {seconds} segundo(s) equivalen a : \n {hours} hora(s), {minutes} minuto(s), {seconds % 60} segundo(s)";
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
