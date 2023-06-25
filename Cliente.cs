using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace grupo6_proyectoFinal
{
    class Cliente :StoredProcedure
    {
        public string nombre, apellido, telefono, email, dui;

        public Cliente()
        {

        }

        public Cliente(string dui,string nombre,string apellido,string telefono,string email)
        {
            this.dui = dui;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.email = email;
        }


        public virtual void Procedimiento(string nombreSp, string accion)
        {
            try
            {   //creamos un comando sql 
                SqlCommand commandoSql = new SqlCommand(nombreSp, Conectar());
                //indicamos que nuestro comando es un procemiento alcenado
                commandoSql.CommandType = CommandType.StoredProcedure;

                commandoSql.Parameters.AddWithValue("@accion", accion);
                commandoSql.Parameters.AddWithValue("@DUI", dui);
                commandoSql.Parameters.AddWithValue("@Nombres", nombre);
                commandoSql.Parameters.AddWithValue("@Apellidos", apellido);
                commandoSql.Parameters.AddWithValue("@Email", email);
                commandoSql.Parameters.AddWithValue("@Telefono", telefono);

                //ejecutamos el procedure
                commandoSql.ExecuteNonQuery();
                CerrarConexion();// cerrar conexion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
    }
}
