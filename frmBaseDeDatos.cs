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
    public partial class frmBaseDeDatos : Form
    {
        public frmBaseDeDatos()
        {
            InitializeComponent();
        }

        clsBaseDeDatos clsBaseDeDatos = new clsBaseDeDatos();

        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO " +
                "FROM LIBRO " +
                "ORDER BY 1 DESC";
            clsBaseDeDatos.Listar(dgvDatos, varSQL);
        }

        private void btnProyeccionMultiAtributo_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO,CANTIDAD " +
                " FROM LIBRO " +
                " ORDER BY 2 DESC ";
            clsBaseDeDatos.Listar(dgvDatos, varSQL);
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT PRECIO " +
                " FROM LIBRO " +
                " WHERE PRECIO < 500 ";
            clsBaseDeDatos.Listar(dgvDatos, varSQL);
        }

        private void btnSeleccionMultiAtributo_Click(object sender, EventArgs e)
        {

            String varSQL = "SELECT * " +
                " FROM LIBRO " +
                " WHERE Cantidad IN " +
                " (SELECT DISTINCT Cantidad FROM LIBRO WHERE Cantidad  < 4)";
            clsBaseDeDatos.Listar(dgvDatos, varSQL);
        }
    }
}
