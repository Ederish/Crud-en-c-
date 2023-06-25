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
    class ConexionBd
    {
        //nombre de su instacia de sql Server
        static string server = "DESKTOP-T3ND265\\MSSQLSERVER02;";
        //cadena de conexion
        public string cadenaConec = "Data Source="+server+"Initial Catalog=TodoAuto;Integrated Security=True;";



        SqlConnection conexion = new SqlConnection();

       

        public SqlConnection Conectar()
        {

            try
            {
                conexion.ConnectionString = cadenaConec;
                conexion.Open();

            }
            catch (Exception err)
            {

                MessageBox.Show("Error," + err.ToString());
            }

            return conexion;
        }

        //Metodo para cerrar conexion
        public void CerrarConexion()
        {
            conexion.Close();
        }

        // Medodo para mostrar datos
        public virtual void MostrarDatos(DataGridView gridView,string comandoSql)
        {
            try
            {
                gridView.DataSource = null;
                SqlDataAdapter adapter = new SqlDataAdapter(comandoSql, Conectar());
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                gridView.DataSource = dt;
                CerrarConexion();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error," + err.ToString());
            }
        }
    }
}
