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
    public partial class frmRepasoOperaciones : Form
    {
        public frmRepasoOperaciones()
        {
            InitializeComponent();
        }
        clsBaseDatos objBD = new clsBaseDatos();
        private void btnListar_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT * FROM LIBRO";
            objBD.Listar(dgvRepasoOperaciones, VarSQL);
            
            switch (cmbOperacion.SelectedIndex)
            {
                case 0:
                     lblRepasoOperaciones.Text = cmbOperacion.Text + ":" + 
                    "Paises que no tienen libros";
                    VarSQL = "Select * FROM pais where idpais not in (select idpais FROM libro";
                break;
            }
        }

        private void frmRepasoOperaciones_Load(object sender, EventArgs e)
        {
            
            cmbOperacion.Items.Add("Diferencia");
            cmbOperacion.Items.Add("Interseccion");
            cmbOperacion.Items.Add("Juntar");
            cmbOperacion.Items.Add("Proyeccion Simple");
            cmbOperacion.Items.Add("Proyeccion Multiatributo");
            cmbOperacion.Items.Add("Selección Multiatributo con operador AND");
            cmbOperacion.Items.Add("Selección Multiatributo por Convulsión");
            cmbOperacion.Items.Add("Selección Simple");
            cmbOperacion.Items.Add("Unión");
            cmbOperacion.SelectedIndex = 0;
        }
    }
}
