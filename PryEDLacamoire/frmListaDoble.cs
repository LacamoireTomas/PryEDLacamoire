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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble2 FilaDePersonas = new clsListaDoble2();
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
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            ObjNodo.Nombre = txtNombreNuevo.Text;
            ObjNodo.Tramite = txtTramiteNuevo.Text;
            FilaDePersonas.Agregar(ObjNodo);
            FilaDePersonas.RecorrerAsc(dgvLista);
            FilaDePersonas.RecorrerAsc(lstLista);
            FilaDePersonas.RecorrerAsc();
            FilaDePersonas.Recorrer(cmbCodigo);
            txtCodigoNuevo.Text = "";
            txtNombreNuevo.Text = "";
            txtTramiteNuevo.Text = "";
            btnAgregar.Enabled = false;
        }

        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {
            if (optAscendente.Checked)
            {
                FilaDePersonas.RecorrerAsc(dgvLista);
                FilaDePersonas.RecorrerAsc(lstLista);
                FilaDePersonas.RecorrerAsc();
            }
        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {
            if (optDescendente.Checked)
            {
                FilaDePersonas.RecorrerDes(dgvLista);
                FilaDePersonas.RecorrerDes(lstLista);
                FilaDePersonas.RecorrerDes();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbCodigo.Text);
                FilaDePersonas.Eliminar(x);
                FilaDePersonas.RecorrerAsc(dgvLista);
                FilaDePersonas.RecorrerAsc(lstLista);
                FilaDePersonas.Recorrer(cmbCodigo);
                FilaDePersonas.RecorrerAsc();
            }
            else
            {
                MessageBox.Show("La lista está vacía");
            }
            btnEliminar.Enabled = false;
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex != -1)
            {
                btnEliminar.Enabled = true;
            }
        }
    }
}
