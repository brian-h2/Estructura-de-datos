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
    public partial class frmListaEnlazada : Form
    {
        public frmListaEnlazada()
        {
            InitializeComponent();
        }

        clsListaDoble doble = new clsListaDoble();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nodo = new clsNodo();
            nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nodo.Nombre = txtNombre.Text;
            nodo.Tramite = txtTramite.Text;

            doble.agregar(nodo);
            
            doble.recorrerAcendente(dgvDatos1);
            doble.recorrerDescendente(dgvDatos);
            
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            //doble.listarDGV(dgvDatos);
        }

        private void frmListaEnlazada_Load(object sender, EventArgs e)
        {
            
           
            
        }

        public Int32 numero;

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            numero = Convert.ToInt32(txtCodigoBorrar.Text);
            doble.eliminar(numero,dgvDatos);
            doble.recorrerAcendente(dgvDatos1);
            doble.recorrerDescendente(dgvDatos);

        }

        private void btnListarAscendente_Click(object sender, EventArgs e)
        {
           
        }

        private void btnListarDescente_Click(object sender, EventArgs e)
        {
           
        }
    }
}
