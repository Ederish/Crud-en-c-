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
    class Empleado : Cliente
    {
        public decimal sueldo;
        

          
     
        public Empleado(string dui, string nombre, string apellido, decimal sueldo, string telefono, string email):
            base()
        {
            this.dui = dui;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldo = sueldo;
            this.telefono = telefono;
            this.email = email;
        }

        public override void Procedimiento(string nombreSp, string accion)
        {
            try
            {   //creamos un comando sql 
                SqlCommand commandoSql = new SqlCommand(nombreSp, Conectar());
                //indicamos que nuestro comando es un procemiento alcenado
                commandoSql.CommandType = CommandType.StoredProcedure;

                commandoSql.Parameters.AddWithValue("@accion", accion);
                commandoSql.Parameters.AddWithValue("@Cod_Empleado", dui);
                commandoSql.Parameters.AddWithValue("@Nombres", nombre);
                commandoSql.Parameters.AddWithValue("@Apellidos", apellido);
                commandoSql.Parameters.AddWithValue("@Email", email);
                commandoSql.Parameters.AddWithValue("@Telefono", telefono);
                commandoSql.Parameters.AddWithValue("@Sueldos", sueldo);

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
