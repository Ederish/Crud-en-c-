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
    class ProcedimientosAlm : ConexionBd
    {
        public void AgregarAutos(string vin, string marca, string modelo, int año, int Kilometros,
            string tipo, string condición, decimal precio, int existencias, string dui, string cod_Empleado)
        {
            ConexionBd conexBd = new ConexionBd();

            try
            {
                SqlCommand command = new SqlCommand("AGREGAR_AUTO", Conectar());
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al procedimiento almacenado
                command.Parameters.AddWithValue("@VIN", vin);
                command.Parameters.AddWithValue("@Marca", marca);
                command.Parameters.AddWithValue("@Modelo", modelo);
                command.Parameters.AddWithValue("@Año", año);
                command.Parameters.AddWithValue("@Kilometros", Kilometros);
                command.Parameters.AddWithValue("@Tipo", tipo);
                command.Parameters.AddWithValue("@Condición", condición);
                command.Parameters.AddWithValue("@Precio", precio);
                command.Parameters.AddWithValue("@Existencias", existencias);
                command.Parameters.AddWithValue("@DUI", dui);
                command.Parameters.AddWithValue("@Cod_Empleado", cod_Empleado);

                command.ExecuteNonQuery();
                CerrarConexion();
            }
            catch
            {
                MessageBox.Show("Uy, parece que hubo un error", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertEmp(string CodEmpleado,string Nombres,string Apellidos,decimal Sueldos,string Telefono,string Email)
        {
             String insert;
            try
            {
                 insert = "insert into EMPLEADOS(Cod_Empleado,Nombres,Apellidos,Sueldos,Telefono,Email)"+
                    "values('"+CodEmpleado+"','"+Nombres+"','"+Apellidos+"',"+Sueldos+",'"+Telefono+"','"+Email+"');";
  
                SqlCommand comandoSql= new SqlCommand(insert,Conectar());
                SqlDataReader leer;
                leer = comandoSql.ExecuteReader();
              
            }
            catch (Exception err)
            {
                MessageBox.Show("Error," + err.ToString());
            }
        }

    }
}
