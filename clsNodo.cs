using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_datos
{
    internal class clsNodo
    {


        private Int32 cod;
        private clsNodo sig;
        private clsNodo ant;
        private string nom;
        private string tram;


        public Int32 Codigo
        {
            get { return cod; }
            set { cod = value; }
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

        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Tramite
        {
            get { return tram; }
            set { tram = value; }
        }

        public clsNodo Izquierdo
        {
            get { return sig; }
            set { sig = value; }
        }

        public clsNodo Derecho
        {
            get { return ant; }
            set { ant = value; }
        }
    }
    
}
