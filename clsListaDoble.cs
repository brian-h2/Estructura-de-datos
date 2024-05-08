using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_de_datos
{
    class clsListaDoble
    {
        public clsNodo Primero;
        public clsNodo Ultimo;

        public void agregar(clsNodo nuevo)
        {
            if(Primero == null) {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                if(nuevo.Codigo < Primero.Codigo)
                {
                    nuevo.Siguiente = Primero;
                    Primero.Anterior = nuevo;
                    Primero = nuevo;
                } else
                {
                    if (nuevo.Codigo > Ultimo.Codigo)
                    {

                        Ultimo.Siguiente = nuevo;
                        nuevo.Anterior = Ultimo;
                        Ultimo = nuevo;
                    } else
                    {

                        // El nuevo toma valor como siguiente va a tomar lo que la auxiliar siguiente tiene (nuevo.siguiente = aux.siguiente)
                        // Nuevo.siguiente.anterior = (El anterior al nuevo),que apunta el nodo nuevo al anterior
                        // nuevo.anterior = aux1; elanterior del nuevo indica al antecesor con puntero osea el 6 al 5 mientras 7 es el nuevo
                        // aux.siguiente = nuevo; el auxiliar indica al 6 que va a ser el anterior del nuevoes decir el 7 

                        clsNodo aux = Primero;
                        clsNodo ant = Primero;
                        while(aux.Codigo < nuevo.Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                            if (aux == null)
                            {
                                break; // si aux llega a ser nulo por q se corrio y no hay nada se frena 
                            }
                        }
                        ant.Siguiente = nuevo;
                        nuevo.Siguiente = aux;
                        aux.Anterior = nuevo;
                        nuevo.Anterior = ant;
                    }
                }
            }
        }

        public void eliminar(Int32 codigo, DataGridView datos)
        {

            if(Primero == null && Ultimo == Primero)
            {
                MessageBox.Show("No hay elementos para borrar");
            } else if(Primero.Codigo == codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
                datos.Rows.Clear();
            }
            else
            {
                if(Primero.Codigo == codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                } else
                {
                    if (Ultimo.Codigo == codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    } else
                    {
                        clsNodo aux = Primero;
                        clsNodo ant = Primero;
                        while (aux.Codigo < codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                            if (aux == null)
                            {
                                break; // si aux llega a ser nulo por q se corrio y no hay nada se frena 
                            }
                        }
                        ant.Siguiente = aux.Siguiente;
                        aux = aux.Siguiente;
                        aux.Anterior = ant;
                    }
                }
                
            
            }
            MessageBox.Show("Dato eliminado correctamente");
        }

        public void recorrerAcendente(DataGridView datos)
        {
            clsNodo AUX = Primero;
            datos.Rows.Clear();
            do
            {
                datos.Rows.Add(AUX.Codigo, AUX.Nombre, AUX.Tramite);
                AUX = AUX.Siguiente;
                
            } while (AUX != null);
        }

        public void recorrerDescendente(DataGridView datos)
        {
            clsNodo AUX = Ultimo;
            datos.Rows.Clear();
            while (AUX != null)
            {
                datos.Rows.Add(AUX.Codigo, AUX.Nombre, AUX.Tramite);
                AUX = AUX.Anterior;
            }
        }
    }
}
