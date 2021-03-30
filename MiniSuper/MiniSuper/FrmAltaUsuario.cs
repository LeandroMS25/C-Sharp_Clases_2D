using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSuper
{
    public partial class FrmAltaUsuario : Form
    {
        Usuario usuario;

        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // CheckBox
            string[] formasDePago = new string[1];
            foreach (Control miControl in this.panelFormasPago.Controls) 
            {
                if (miControl is CheckBox && ((CheckBox)miControl).Checked) 
                {
                    Array.Resize<string>(ref formasDePago, formasDePago.Length + 1);
                    formasDePago[formasDePago.Length - 1] = ((CheckBox)miControl).Text;
                }
            }

            // Radio Button
            string formaPago = String.Empty;
            foreach (Control miControl in this.groupBoxMediosPago.Controls)
            {
                if (miControl is RadioButton && ((RadioButton)miControl).Checked)
                {
                    formaPago = miControl.Text;
                }
            }

            //ComboBox

            // this.cmbProvincia.DataSource = Coleccion propia de objetos
            // this.cmbProvincia.Items.Add = Un solo item
            string provincia = String.Empty;
            if (this.cmbProvincia.SelectedIndex == -1)
            {
                if (this.cmbProvincia.Text != String.Empty)
                {
                    provincia = this.cmbProvincia.Text;
                }
            }
            else 
            {
                provincia = this.cmbProvincia.SelectedIndex.ToString();
            }

            // TextBox y NumericUpDown
            this.usuario = new Usuario(this.txtApellido.Text,
                this.txtNombre.Text,(long)this.numDni.Value, formasDePago, formaPago, provincia);

            //this.Close();

            this.DialogResult = DialogResult.OK;
        }

        public Usuario GetUsuario()
        {
            return this.usuario;
        }
    }
}
