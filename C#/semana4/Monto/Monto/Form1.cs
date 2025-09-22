using Monto.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precio = double.Parse(tbPrecio.Text);
            lbMonto.Text = "Monto: " + Calculo.CalcularMonto(precio) + "\nPrecio: " + precio;

        }

        private void btncalcularRef_Click(object sender, EventArgs e)
        {
            double precio = double.Parse(tbPrecio.Text);
            lbMonto.Text ="Monto: " + Calculo.CalcularMonto(ref precio)  + "\nPrecio: " + precio;
        }

        private void lbMonto_Click(object sender, EventArgs e)
        {

        }
    }
}
