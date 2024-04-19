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

            } else if(nuevo.Dato < Primero.Dato)
            {
                    nuevo.Siguiente = Primero;
                    Primero = nuevo;
            } 
            
            else
            {
                clsNodo aux1 = Primero;
                if(aux1.Siguiente != null)
                {
                    while (nuevo.Dato > aux1.Siguiente.Dato)
                    {
                        aux1 = aux1.Siguiente;
                        if(aux1.Siguiente == null )
                        {
                            break;
                        }
                    }
                }
                nuevo.Siguiente = aux1.Siguiente;
                aux1.Siguiente = nuevo;
            }
               
            
            
        }

        public void eliminar()
        {

        }

        public void listarDGV(DataGridView datos)
        {
            clsNodo AUX = Primero;

            if (AUX != null)
            {
                datos.Rows.Add(AUX.Codigo, AUX.Nombre, AUX.Tramite);
                AUX = AUX.Siguiente;
            }
        }

        public void listarLST(ListBox lista)
        {

        }
    }
}
