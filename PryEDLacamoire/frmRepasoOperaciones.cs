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
                    VarSQL = "Select * FROM pais where idpais not in (SELECT idpais FROM libro)";
                    break;


                case 1:
                    lblRepasoOperaciones.Text = cmbOperacion.Text + ":" +
                        "Autores con Id > 10 e Idiomas con Id > 5";
                    VarSQL = "SELECT * FROM Libro WHERE IdAutor>10 INTERSECT SELECT * FROM Libro WHERE IdIdioma>5";

                    break;

                case 2:
                    lblRepasoOperaciones.Text = cmbOperacion.Text + ":" +
                        "Libros Posteriores al año 2000 y libros de menos de $200";
                    VarSQL = "SELECT Libro.Titulo, Libro.Año FROM Libro JOIN Pais.Nombre FROM Pais ON *";
                    break;

                case 3:
                    lblRepasoOperaciones.Text = cmbOperacion.Text + ":" +
                        "Titulos de los Libros";
                    VarSQL = "SELECT Titulo FROM Libro";
                    break;

                case 4:
                    lblRepasoOperaciones.Text = cmbOperacion.Text + ":" +
                        "Todos los libros por titulo y año ordenados por precio de forma ascendente";
                    VarSQL = "SELECT Titulo, Precio FROM Libro ORDER BY Precio ASC";
                    break;

                case 5:
                    lblRepasoOperaciones.Text = cmbOperacion.Text + ":" +//
                        "Todos los libros de Estados Unidos y en idioma Ingles";
                    VarSQL = "SELECT * FROM Libro WHERE IdPais = 4 AND IdIdioma = 1";
                    break;

                case 6://
                    lblRepasoOperaciones.Text = cmbOperacion.Text + ":" +
                        "Todos los libros de mas caros que $100 y esten en Ingles";
                    VarSQL = "SELECT * FROM Libro WHERE Precio > 200 INTERSECT SELECT * FROM Libro WHERE IdIdioma = 1; ";
                    break;

                case 7://
                    lblRepasoOperaciones.Text = cmbOperacion.Text + ":" +
                        "Todos los libros que valgan 200";
                    VarSQL = "SELECT * FROM Libro WHERE Precio = 200";
                    break;

                case 8: //
                    lblRepasoOperaciones.Text = cmbOperacion.Text + ":" +
                        "Libros de origen Sudamericano (Argentina, Colombia, Brasil)";
                    VarSQL = "SELECT * FROM libro WHERE IdPais = 8 " + "UNION SELECT * FROM libro WHERE IdPais = 24 " +
                             "UNION SELECT * FROM libro WHERE IdPais = 26";    
                    break;
            }
            objBD.Listar(dgvRepasoOperaciones, VarSQL);
        }
        //
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
