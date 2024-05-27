using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private Int32 i = 0;
        private clsNodo[] Vector = new clsNodo[100];
       

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

        //Combo box
        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        private void InOrdenAsc(ComboBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Lst, R.Izquierdo);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }

        public void listar(ListBox lista)
        {
            
            lista.Items.Clear();
            InOrdAsc(Raiz, lista);
           

        }

        public void InOrdAsc(clsNodo R, ListBox lst)
        {
            if(R.Izquierdo != null)
            {
                InOrdAsc(R.Izquierdo,lst);
            }
           
            lst.Items.Add(R.Codigo);
            if(R.Derecho != null)
            {
                InOrdAsc(R.Derecho,lst);
            }
        }

        public void InOrdDesc(clsNodo R, ListBox lst)
        {
            if (R.Derecho != null)
            {
                InOrdDesc(R.Derecho,lst);
            }

            lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                InOrdDesc(R.Izquierdo,lst);
            }
        }

        public void listar(ListBox lista, Int32 orden )
        {
            lista.Items.Clear();
            switch (orden)
            {
                case 1:
                    InOrdAsc(Raiz, lista);
                    break;
                case 2:
                    preOrden(Raiz, lista);
                    break;
                case 3:
                    postOrden(Raiz, lista);
                    break;
                default:
                    MessageBox.Show("uwu");
                    break;
            }
        }

        public void preOrden(clsNodo R, ListBox lst)
        {
            lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                preOrden(R.Izquierdo,lst);
            }
           
            if (R.Derecho != null)
            {
                preOrden(R.Derecho,lst);
            }
        }

        public void postOrden(clsNodo R, ListBox lst)
        {
           
            if (R.Izquierdo != null)
            {
                postOrden(R.Izquierdo,lst);
            }

            if (R.Derecho != null)
            {
                postOrden(R.Derecho,lst);
            }

            lst.Items.Add(R.Codigo);
        }

        //Equilibrar nodos es distribuir la cantidad de nodos de forma igualitaria

        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz); //Asigno los valores al vector
            Raiz = null; //Resguardo del arbol (pisando la raiz) 
            EquilibrarArbol(0, i - 1); //Recorremos el vector y vamos llamando al 
                                     //metodo agregar para ir construyendo el nuevo vector
        }

        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2; // el valor m es la mitad del arbol
            if (ini <= fin)
            {
                agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1); //Comienza por la izquierda de raiz
                EquilibrarArbol(m + 1, fin); //Se mueve al derecho de la raiz
            }
        }

        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }
            Vector[i] = NodoPadre;
            i = i + 1;
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }

        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVector(Raiz, codigo);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        private void GrabarVector(clsNodo NodoPadre, Int32 Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVector(NodoPadre.Izquierdo, Codigo);
            }
            if (NodoPadre.Codigo != Codigo)
            {
                Vector[i] = NodoPadre;
                i = i + 1;
            }
            if (NodoPadre.Derecho != null)
            {
                GrabarVector(NodoPadre.Derecho, Codigo);
            }
        }

    }
}
