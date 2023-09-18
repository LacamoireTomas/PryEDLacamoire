﻿using System;
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

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);

        }

        private void InOrdenAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(dgv, R.Izquierdo);
                dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite); ;

            }
            if (R.Derecho != null)
            {
                InOrdenAsc(dgv, R.Derecho);
            }
                
        }

    }    
}