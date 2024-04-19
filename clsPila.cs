using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_de_datos
{
    internal class clsPila
    {
 
        public clsNodo Primero;

       

        public void agregar(clsNodo nuevo)
        {
            if(Primero == null)
            {
                Primero = nuevo;
                MessageBox.Show("Se creo un dato nuevo");
            } else
            {
                nuevo.Siguiente = nuevo;
                Primero = nuevo;
            }
        }

        public void eliminar()
        {
            if(Primero != null)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                MessageBox.Show("No hay datos para borrar");
            }
        }
        
        public void listarPila(DataGridView datos)
        {
            clsNodo AUX = Primero;
          
            if(AUX != null)
            {
                datos.Rows.Add(AUX.Codigo, AUX.Nombre, AUX.Tramite);
                AUX = AUX.Siguiente;
            }
        }

        public void listarLista(ListBox lista)
        {
            clsNodo AUX = Primero;
            
            if (AUX != null)
            {
                lista.Items.Add(AUX.Nombre);
                AUX = AUX.Siguiente;
            }
        }
    }
}
