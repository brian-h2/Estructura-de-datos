using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_de_datos
{
    internal class clsCola
    {

        public clsNodo Primero;
        public clsNodo Ultimo;

        public void Agregar (clsNodo Nuevo )
        {
            
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;

                /*El primero si es igual a null (No existe un elemento) 
                Se asigna a primero un elemento nuevo y al ultimo el mismo ya que es el unico*/

            }
            else
            {
                
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;

                /*El ultimo elemento tiene alguien que le sigue y por eso se coloca nuevo,
                se agrega uno nuevo al ultimo y asi*/

            }
            MessageBox.Show(Nuevo.ToString());

        }

       
        public void Eliminar ()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero.Siguiente = Primero;
            }   
        }
        public void Listar(ListBox lista)
        {
            clsNodo AUX = Primero;

            if (AUX != null)
            {
                lista.Items.Add(AUX.Nombre);
                AUX = AUX.Siguiente;
            }

        }

        public void ListarDGV(DataGridView datos)
        {
            clsNodo AUX = Primero;
            
            if (AUX != null)
            {
                datos.Rows.Add(AUX.Codigo, AUX.Nombre, AUX.Tramite);
                AUX = AUX.Siguiente;
            }
        }


        /*Que acabo de hacer? 
            (Borre bucle while unicamente, xq se hacia un bucle infinito)
            (Borre el datos.rows.clear porque cada vez que se ejecutaba 
            listar, se borraba el dato anterior por limpiar filas)
         */


    }
}
