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
    class Auto: StoredProcedure
    {
        string vin, marca, modelo, tipo, condicion;
        int año, kms, exts; decimal precio;
        
        public Auto(string vin, string marca, string modelo,string tipo, string condicion,
               int año, int kms,int exts, decimal precio)
        {
            this.vin = vin;
            this.marca=marca;
            this.modelo = modelo;
            this.tipo = tipo;
            this.condicion = condicion;
            this.año = año;
            this.kms = kms;
            this.precio = precio;
            this.exts = exts;
            
        }

        public  void Procedimiento(string nombreSp, string accion, string dui, string codEmp)
        {
            try
            {   //creamos un comando sql 
                SqlCommand commandoSql = new SqlCommand(nombreSp, Conectar());
                //indicamos que nuestro comando es un procemiento alcenado
                commandoSql.CommandType = CommandType.StoredProcedure;

                commandoSql.Parameters.AddWithValue("@accion", accion);
                commandoSql.Parameters.AddWithValue("@vin", vin);
                commandoSql.Parameters.AddWithValue("@marca", marca);
                commandoSql.Parameters.AddWithValue("@modelo", modelo);
                commandoSql.Parameters.AddWithValue("@Tipo", tipo);
                commandoSql.Parameters.AddWithValue("@Condición", condicion);
                commandoSql.Parameters.AddWithValue("@año", año);
                commandoSql.Parameters.AddWithValue("@Kilometros", kms);
                commandoSql.Parameters.AddWithValue("@Precio", precio);
                commandoSql.Parameters.AddWithValue("@Existencias", exts);

                commandoSql.Parameters.AddWithValue("@dui", dui);
                commandoSql.Parameters.AddWithValue("@Cod_Empleado", codEmp);

                //ejecutamos el procedure
                commandoSql.ExecuteNonQuery();
                CerrarConexion();// cerrar conexion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

    }
}
 
