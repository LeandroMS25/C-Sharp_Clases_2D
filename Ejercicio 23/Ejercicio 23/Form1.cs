using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Ejercicio_23
{
    public partial class Conversor : Form
    {
        Dolar dolar;
        Pesos peso;
        Euro euro;
        public Conversor()
        {
            InitializeComponent();
        }
        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            euro = new Euro(double.Parse(txtEuro.Text));
            txtEuroAEuro.Text = (euro.GetCantidad()).ToString();
            txtEuroADolar.Text = ((Dolar)euro.GetCantidad()).ToString();
            txtEuroAPeso.Text = ((Pesos)euro.GetCantidad()).ToString();
        }
    }
}
