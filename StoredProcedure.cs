using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo6_proyectoFinal
{
    class StoredProcedure : ConexionBd
    {
        
        public void Buscar(string busqueda, DataGridView gridView)
        {
            try
            {
                //1. crear el comando sql
                SqlCommand comandoSql = new SqlCommand("buscar", Conectar());
                //indicar que el comando stored ´rocedure
                comandoSql.CommandType = CommandType.StoredProcedure;
                // Agregar parámetros al procedimiento almacenado
                comandoSql.Parameters.AddWithValue("@busqueda", busqueda);

                // convertir el comando en una sentecia sql
                SqlDataAdapter adapter = new SqlDataAdapter(comandoSql);

                //Muestra el sp en pantalla
                gridView.DataSource = null;

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                gridView.DataSource = dt;
                CerrarConexion();
            }
            catch (Exception )
            {
                MessageBox.Show("Uy, parece que hubo un error", "Error"
                     , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Borrar(string paramBorrar)
        {
            try
            {   //creamos un comando sql 
                SqlCommand commandoSql = new SqlCommand("BORRAR", Conectar());
                //indicamos que nuestro comando es un procemiento alcenado
                commandoSql.CommandType = CommandType.StoredProcedure;
                // le añadimos un parametro
                commandoSql.Parameters.AddWithValue("@paramBorrar", paramBorrar);

                //ejecutamos el comando
                commandoSql.ExecuteNonQuery();
                CerrarConexion();// cerrar conexion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}