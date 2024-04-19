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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila pila = new clsPila();
        clsNodo nodo = new clsNodo();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nodo.Nombre = txtNombre.Text;
            nodo.Tramite = txtTramite.Text;

            pila.agregar(nodo);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            pila.listarLista(lstNombres);
            pila.listarPila(dgvDatos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (pila.Primero != null)
            {
                lblCodigo.Text = pila.Primero.Codigo.ToString();
                lblNombre.Text = pila.Primero.Nombre.ToString();
                lblTramite.Text = pila.Primero.Tramite.ToString();
                pila.eliminar();
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
                dgvDatos.Rows.Clear();
                lstNombres.Items.Clear();
                MessageBox.Show("Datos Eliminados correctamente");
            }
            else
            {
                MessageBox.Show("No hay datos para eliminar");
            }
        }

        private void frmPila_Load(object sender, EventArgs e)
        {

        }
    }
}
