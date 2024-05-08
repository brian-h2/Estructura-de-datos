using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_de_datos
{
    internal class clsListaSimple
    {
        public clsNodo Primero;
        public clsNodo Anterior;

        public void agregar(clsNodo nuevo)
        {
            if(Primero == null)
            {
                Primero = nuevo;
                Anterior = null;

            } else

            {
                clsNodo aux = Primero;
                clsNodo ant = Primero;

                while (nuevo.Codigo > aux.Codigo) // Mientras nuevo sea mayor a auxiliar (que va a ser el primero lugar)
                {
                    ant = aux; // ant va a ser aux
                    aux = aux.Siguiente; // aux va a correrse

                    if (aux == null)
                    {
                        break; // si aux llega a ser nulo por q se corrio y no hay nada se frena 
                    }
                }

                ant.Siguiente = nuevo; // nuevo toma su lugar entre ant y aux
                nuevo.Siguiente = aux;
            }

        }

        public void eliminar(Int32 codigo,DataGridView datos)
        {
            if(Primero == null)
            {
                MessageBox.Show("No existen elementos para eliminar");
            } else if (Primero.Codigo == codigo) {
                Primero = Primero.Siguiente;
                datos.Rows.Clear();
            }  
            else
            {
                clsNodo aux1 = Primero;
                clsNodo aux2 = Primero;
                while(aux1.Codigo != codigo)
                {
                    aux2 = aux1;
                    aux1 = aux1.Siguiente;
                    if (aux1 == null)
                    {
                        MessageBox.Show("Elemento no existente");
                        break;

                    }

                }
                aux1.Siguiente = aux2.Siguiente;

                if (aux1 != null)
                {
                    aux2.Siguiente = aux1.Siguiente;
                }

            }
           

        }

        public void listarDGV(DataGridView datos)
        {
            clsNodo AUX = Primero;

            while (AUX != null)
            {
                datos.Rows.Add(AUX.Codigo, AUX.Nombre, AUX.Tramite);
                AUX = AUX.Siguiente;
            }
        }

        public void listarLST(ListBox lista)
        {
            clsNodo AUX = Primero;

            while (AUX != null)
            {
                lista.Items.Add(AUX.Nombre);
                AUX = AUX.Siguiente;
            }
        }
    }
}
