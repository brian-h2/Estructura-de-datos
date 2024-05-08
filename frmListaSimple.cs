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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsNodo nodo = new clsNodo();
        clsListaSimple simple = new clsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nodo.Nombre = txtNombre.Text;
            nodo.Tramite = txtTramite.Text;
            simple.agregar(nodo);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            simple.listarDGV(dgvDatos);
           
        }

        public Int32 codigo;

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(txtCodigoBorrar.Text);
            simple.eliminar(codigo,dgvDatos);
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }
    }
}
