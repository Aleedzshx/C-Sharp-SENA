using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrecioConDescuento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int precio = int.Parse(price.Text);
            int descuento = int.Parse(discount.Text);
            int precioFinal = precio - (precio * descuento / 100);
            lblPriceWithDiscount.Text = precioFinal.ToString();
        }
    }
}
