using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_datos
{
    internal class clsArbol
    {
        private clsNodo inicio;

        public clsNodo Raiz
        {
            
            get { return inicio; }
            set { inicio = value; }
        }

        public void agregar(clsNodo nuevo)
        {
            nuevo.Izquierdo = null;
            nuevo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = nuevo;
            }
            else
            {
                clsNodo padre = Raiz;
                clsNodo aux = Raiz; //Auxiliar toma el valor de la raiz para ir iterando cada uno
                while(aux != null)
                {
                    padre = aux;
                    if(nuevo.Codigo < aux.Codigo)
                    {
                        aux = aux.Izquierdo;
                    } else
                    {
                        aux = aux.Derecho;
                    }
                }
                if(nuevo.Codigo < padre.Codigo)
                {
                    padre.Izquierdo = nuevo;
                } else
                {
                    padre.Derecho = nuevo;
                }
            }
        }
    }
}
