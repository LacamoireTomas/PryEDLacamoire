using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEDLacamoire
{
    internal class clsListaDoble2
    {
        //Campos de laclase
        private clsNodo pri;
        private clsNodo ult;

        //Propiedades de la Clase
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }
        //Metodos
        public void Agregar(clsNodo Nvo)
        {
            if (Primero == null)
            {
                Primero = Nvo;
                Ultimo = Nvo;
            }
            else
            {
                if (Nvo.Codigo < Primero.Codigo)
                {
                    Nvo.Siguiente = Primero;
                    Primero.Anterior = Nvo;
                    Primero=Nvo;
                }
                else
                {
                    if (Nvo.Codigo> Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nvo;
                        Nvo.Anterior = Ultimo;
                        Ultimo = Nvo;
                    }
                    else
                    {
                        clsNodo Aux = Primero;
                        clsNodo Ant = Primero;
                        while (Aux.Codigo<Nvo.Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Ant.Siguiente = Nvo;
                        Nvo.Siguiente = Aux;
                        Aux.Anterior = Nvo;
                        Nvo.Anterior = Ant;
                    }
                }
            }

        }
    }
}
