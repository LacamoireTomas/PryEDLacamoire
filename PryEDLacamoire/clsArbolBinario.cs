using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDLacamoire
{
    internal class clsArbolBinario
    {
        //Campos
        private clsNodo Inicio;

        //Propiedades

        public clsNodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }


        public void Agregar(clsNodo Nvo)
        {
            Nvo.Izquierdo = null; Nvo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nvo;
            }

            else
            {
                clsNodo NodoPadre = Raiz; //ant
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nvo.Codigo > Aux.Codigo)
                    {

                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                //Afuera del while
                if (Nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nvo;
                }
                else
                {
                    NodoPadre.Derecho = Nvo;

                }
            }
        }


        //Metodos

        public void RecorrerInOrdenAsc(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);

        }

        private void InOrdenAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(dgv, R.Izquierdo);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite); 
            if (R.Derecho != null) InOrdenAsc(dgv, R.Derecho);
                    
        }

        public void RecorrerPreOrdenAsc(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrdenAsc(Grilla, Raiz);

        }

        private void PreOrdenAsc(DataGridView dgv, clsNodo R)
        {
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) PreOrdenAsc(dgv, R.Izquierdo);     
            if (R.Derecho != null) PreOrdenAsc(dgv, R.Derecho);

        }

        public void RecorrerPostOrdenAsc(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrdenAsc(Grilla, Raiz);

        }

        private void PostOrdenAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrdenAsc(dgv, R.Izquierdo);
            if (R.Derecho != null) PostOrdenAsc(dgv, R.Derecho);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

        }

        <   


    }    
}
