using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PryEDLacamoire
{
    internal class clsListaSimple
    {
        //Campos de laclase
        private clsNodo pri;

        //Propiedades de la Clase
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        //Metodos
        public void Agregar(clsNodo Nuevo)
        {

            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;
                    while (Nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null)
                        {
                            break;
                        }
                    }
                    ant.Siguiente = Nuevo;
                    Nuevo.Siguiente = aux;
                }
            }
        }
        public void Recorrer()
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("FilaSimple.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Código;Nombre; Trámite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.Write(aux.Tramite);
                aux = aux.Siguiente;

            }
            AD.Close();

        }

        public void Recorrer(ComboBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(DataGridView Grilla)

        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();

            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;

            }
        }

        public void Recorrer(ListBox Lista)

        {
            clsNodo aux = Primero;
            Lista.Items.Clear();

            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;

            }

        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo==Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodo aux1 = Primero;
                clsNodo aux2 = Primero;
                while (aux1.Codigo!=Codigo)
                {
                    aux2 = aux1;
                    aux1 = aux1.Siguiente;

                }
                aux2.Siguiente = aux1.Siguiente;

            }

        }



    }
    
}
