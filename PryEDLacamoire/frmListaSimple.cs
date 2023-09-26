using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
namespace PryEDLacamoire
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple FilaDePersonas = new  clsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            ObjNodo.Nombre = txtNombreNuevo.Text;
            ObjNodo.Tramite = txtTramiteNuevo.Text;

            FilaDePersonas.Agregar(ObjNodo);
            FilaDePersonas.Recorrer(dgvListaSimple);
            FilaDePersonas.Recorrer(lstListaSimple);
            FilaDePersonas.Recorrer();
            FilaDePersonas.Recorrer(cmbCodigo);

            txtCodigoNuevo.Text = "";
            txtNombreNuevo.Text = "";
            txtTramiteNuevo.Text = "";
            
        }

       

        private void txtCodigoNuevo_TextChanged_1(object sender, EventArgs e)
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

        private void txtNombreNuevo_TextChanged_1(object sender, EventArgs e)
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

        private void txtTramiteNuevo_TextChanged_1(object sender, EventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbCodigo.Text);
                FilaDePersonas.Eliminar(x);
                FilaDePersonas.Recorrer(dgvListaSimple);
                FilaDePersonas.Recorrer(lstListaSimple);
                FilaDePersonas.Recorrer(cmbCodigo);
                FilaDePersonas.Recorrer();
            }
            else
            {
                MessageBox.Show("La lista está vacía");
            }
            btnEliminar.Enabled = false;
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
        }
    }
}
