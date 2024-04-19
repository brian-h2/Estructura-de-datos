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
    
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        clsNodo nodo = new clsNodo();
        clsCola cola = new clsCola();

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nodo.Nombre = txtNombre.Text;
            nodo.Tramite = txtTramite.Text;
            cola.Agregar(nodo);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            cola.ListarDGV(dgvDatos);
            cola.Listar(lstNombres);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(cola.Primero  != null)
            {
                lblCodigo.Text = cola.Primero.Codigo.ToString();
                lblNombre.Text = cola.Primero.Nombre.ToString();
                lblTramite.Text = cola.Primero.Tramite.ToString();
                cola.Eliminar();
                MessageBox.Show("Datos Eliminados correctamente");
                txtNombre.Clear();
                txtTramite.Clear();
                txtCodigo.Clear();
                dgvDatos.Rows.Clear();
                lstNombres.Items.Clear();
            }
            else
            {
                MessageBox.Show("No hay datos para eliminar");
            }
        }

        private void frmCola_Load(object sender, EventArgs e)
        {

        }
    }
}
