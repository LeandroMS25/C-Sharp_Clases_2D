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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void buttonNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmAltaUsuario = new FrmAltaUsuario();
            if (frmAltaUsuario.ShowDialog() == DialogResult.OK) 
            {
                MiniSuper.AgregarUsuario(frmAltaUsuario.GetUsuario());
            }

            cmbUsuarios.DataSource = null;
            cmbUsuarios.DataSource = MiniSuper.GetUsuarios();           
        }
    }
}
