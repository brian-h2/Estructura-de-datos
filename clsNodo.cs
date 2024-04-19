using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_datos
{
    internal class clsNodo
    {
        private Int32 dato;
        private clsNodo sig;
        private clsNodo ant;



       

        public Int32 Dato
        {
            get { return dato; }
            set { dato = value; }
        }

       
        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }

        public clsNodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }
    }


}
