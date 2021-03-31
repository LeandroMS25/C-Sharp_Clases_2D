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
            txtCotizacionDolar.Text = (Dolar.GetCotizacion()).ToString();
            txtCotizacionEuro.Text = (Euro.GetCotizacion()).ToString();
            txtCotizacionPeso.Text = (Math.Round(Pesos.GetCotizacion(),2)).ToString();
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            euro = new Euro(double.Parse(txtEuro.Text));
            peso = (Pesos)euro;
            dolar = (Dolar)euro;
            txtEuroAEuro.Text = (euro.GetCantidad()).ToString();
            txtEuroADolar.Text = (dolar.GetCantidad()).ToString();
            txtEuroAPeso.Text = (peso.GetCantidad()).ToString();
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            dolar = new Dolar(double.Parse(txtDolar.Text));
            euro = (Euro)dolar;
            peso = (Pesos)dolar;
            txtDolarADolar.Text = (dolar.GetCantidad()).ToString();
            txtDolarAEuro.Text = (euro.GetCantidad()).ToString();
            txtDolarAPeso.Text = (peso.GetCantidad()).ToString();
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            peso = new Pesos(double.Parse(txtPeso.Text));
            euro = (Euro)peso;
            dolar = (Dolar)peso;
            txtPesoADolar.Text = (dolar.GetCantidad()).ToString();
            txtPesoAEuro.Text = (euro.GetCantidad()).ToString();
            txtPesoAPeso.Text = (peso.GetCantidad()).ToString();
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if (btnLockCotizacion.ImageIndex == 0)
            {
                btnLockCotizacion.ImageIndex = 1;
                txtCotizacionPeso.Enabled = true;
                txtCotizacionEuro.Enabled = true;
            }
            else
            {
                Pesos.SetCotizacion(double.Parse(txtCotizacionPeso.Text));
                Euro.SetCotizacion(double.Parse(txtCotizacionEuro.Text));
                btnLockCotizacion.ImageIndex = 0;
                txtCotizacionPeso.Enabled = false;
                txtCotizacionEuro.Enabled = false;
            }
        }
    }
}
