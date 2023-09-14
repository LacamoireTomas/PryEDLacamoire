using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDLacamoire
{
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        private void txtCodigoNuevo_TextChanged(object sender, EventArgs e)
        {

            if (txtCodigoNuevo.Text != "")
            {
                txtNombreNuevo.Enabled = true;
            }
            else
            {
                txtNombreNuevo.Enabled = false;
            }
        }

        private void txtNombreNuevo_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreNuevo.Text != "")
            {
                txtTramiteNuevo.Enabled = true;
            }
            else
            {
                txtTramiteNuevo.Enabled = false;
            }
        }

        private void txtTramiteNuevo_TextChanged(object sender, EventArgs e)
        {
            if (txtTramiteNuevo.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }
    }
}
