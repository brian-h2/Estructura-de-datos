using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_de_datos
{
    internal class clsBaseDeDatos
    {

        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string varCadenaConexion1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";
        private string varCadenaConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";

        public void Listar(DataGridView datos)
        {
            try
            {
                conexion.ConnectionString = varCadenaConexion1;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from Libro";

                OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds,"Tabla");

                datos.DataSource = null;
                datos.DataSource = ds.Tables["tabla"];

                conexion.Close();
            
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public void Listar(DataGridView datos, String ConsultaSQL)
        {
            try
            {
                conexion.ConnectionString = varCadenaConexion1;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = ConsultaSQL;

                OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds, "Tabla");

                datos.DataSource = null;
                datos.DataSource = ds.Tables["tabla"];

                conexion.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

    }
}
