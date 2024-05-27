using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_de_datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void sistemasLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDelDesarrollador datos = new frmDatosDelDesarrollador();
            datos.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola cola = new frmCola();
            cola.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila pila = new frmPila();
            pila.ShowDialog();
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrafo frmGrafo = new frmGrafo();
            frmGrafo.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listaEnlazadaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple simple = new frmListaSimple();
            simple.ShowDialog();
        }

        private void listaDoblementeEnlazadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaEnlazada enlazada = new frmListaEnlazada();
            enlazada.ShowDialog();
        }

        private void arbolBinarioDeBusquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbol arbol = new frmArbol();
            arbol.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaBaseDeDatos frmConsultaBaseDeDatos = new frmConsultaBaseDeDatos();
            frmConsultaBaseDeDatos.ShowDialog();
        }

        private void operacionesConTablasDeBasesDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDeDatos frmBaseDeDatos = new frmBaseDeDatos();
            frmBaseDeDatos.ShowDialog();
        }
    }
}
