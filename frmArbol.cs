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
    public partial class frmArbol : Form
    {
        public frmArbol()
        {
            InitializeComponent();
        }

        private void frmArbol_Load(object sender, EventArgs e)
        {

        }

     
        clsArbol arbo = new clsArbol();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nodo = new clsNodo();

            nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nodo.Tramite = txtTramite.Text;
            nodo.Nombre = txtNombre.Text;

            arbo.agregar(nodo);
            arbo.Recorrer(cmbElementos);
            arbo.listar(lstArbolInOrden, 1);
            arbo.listar(lstArbolPreOrden, 2);
            arbo.listar(lstArbolPostOrden, 3);



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 valorSeleccionado = Convert.ToInt32(cmbElementos.SelectedItem);
            arbo.Eliminar(valorSeleccionado);
            arbo.Recorrer(cmbElementos);
            arbo.listar(lstArbolInOrden, 1);
            arbo.listar(lstArbolPreOrden, 2);
            arbo.listar(lstArbolPostOrden, 3);
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            arbo.Equilibrar();
            arbo.Recorrer(cmbElementos);
            arbo.listar(lstArbolInOrden, 1);
            arbo.listar(lstArbolPreOrden, 2);
            arbo.listar(lstArbolPostOrden, 3);
        }
    }
}
