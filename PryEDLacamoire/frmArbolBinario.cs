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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario FilaDePersonas = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
                clsNodo ObjNodo = new clsNodo();
                ObjNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
                ObjNodo.Nombre = txtNombreNuevo.Text;
                ObjNodo.Tramite = txtTramiteNuevo.Text;

                FilaDePersonas.Agregar(ObjNodo);
                FilaDePersonas.RecorrerInOrdenAsc(dgvArbolBinario);
                FilaDePersonas.Recorrer(treeView1);
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

        private void optInOrden_CheckedChanged(object sender, EventArgs e)
        {
            FilaDePersonas.RecorrerInOrdenAsc(dgvArbolBinario);
          
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            FilaDePersonas.RecorrerPreOrdenAsc(dgvArbolBinario);
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            FilaDePersonas.RecorrerPostOrdenAsc(dgvArbolBinario);
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            FilaDePersonas.Equilibrar();
            FilaDePersonas.RecorrerInOrdenAsc(dgvArbolBinario);
            FilaDePersonas.Recorrer(treeView1);
            FilaDePersonas.Recorrer(cmbCodigo);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FilaDePersonas.Eliminar(Convert.ToInt32(cmbCodigo.Text));
            FilaDePersonas.RecorrerInOrdenAsc(dgvArbolBinario);
            FilaDePersonas.Recorrer(treeView1);
            FilaDePersonas.Recorrer(cmbCodigo);
            btnEliminar.Enabled = false;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (optInOrden.Checked)
            {
                FilaDePersonas.ExportarIn(dgvArbolBinario);
            }
            else
            {
                if (optPreOrden.Checked)
                {
                    FilaDePersonas.ExportarPre(dgvArbolBinario);
                }
                else
                {
                    if (optPostOrden.Checked)
                    {
                        FilaDePersonas.ExportarPost(dgvArbolBinario);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una opcion de ordenamiento", "", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex != -1)
            {
                btnEliminar.Enabled = true;
            }
        }
    }
    //Tl
}
