using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo6_proyectoFinal
{
    public partial class frmAutos : Form
    {
        ConexionBd cbd = new ConexionBd();
        Limpieza l = new Limpieza();

        public frmAutos()
        {
            InitializeComponent();
            cbd.MostrarDatos(dtgAutos,"select * from Autos;");
        }

        

        public void button1_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmCliente();
            Hide();
            frm1.ShowDialog();
            Show();
        }

        public void btnAuto_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmAutos();
            Hide();
            frm1.ShowDialog();
            Show();
        }

        public void btnEmpleado_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmEmpleado();
            Hide();
            frm1.ShowDialog();
            Show();
        }
        public void btnLimpiar_Click(object sender, EventArgs e)
        {
         
            l.Limpiar(this,grpDatos);

            mtbVin.Focus();
            cbd.MostrarDatos(dtgAutos, "select * from Autos;");
        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            string vin, marca, modelo; int año,kms, exts;
            string tipo, condi, dui, codEmp; decimal precio;
            try
            {
            año= Convert.ToInt32(mtbAño.Text);
            kms = Convert.ToInt32(nudKms.Value);
            exts = Convert.ToInt32(nudExistencias.Value);
            marca=txtMarca.Text;
           modelo= txtModelo.Text;
           precio= nudPrecio.Value;
            tipo= cboTipo.Text;
            condi=cboCondicion.Text;
            vin= mtbVin.Text;
            dui= mtbDui.Text;
            codEmp= mtbCod.Text;

                Auto a = new Auto(vin,marca,modelo,tipo, condi, año, kms, exts,precio);

                a.Procedimiento("AutoSp","Insertar",dui,codEmp);
                
                cbd.MostrarDatos(dtgAutos, "select * from autos;");
            }
            catch (Exception)
            {

                MessageBox.Show("Uy, parece que hubo un error", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Registro guardado!!!");
        }

        public void btnActualizar_Click(object sender, EventArgs e)
        {
            string vin, marca, modelo; int año, kms, exts;
            string tipo, condi, dui, codEmp; decimal precio;
            try
            {
                año = Convert.ToInt32(mtbAño.Text);
                kms = Convert.ToInt32(nudKms.Value);
                exts = Convert.ToInt32(nudExistencias.Value);
                marca = txtMarca.Text;
                modelo = txtModelo.Text;
                precio = nudPrecio.Value;
                tipo = cboTipo.Text;
                condi = cboCondicion.Text;
                vin = mtbVin.Text;
                dui = mtbDui.Text;
                codEmp = mtbCod.Text;

                Auto a = new Auto(vin, marca, modelo, tipo, condi, año, kms, exts, precio);

                a.Procedimiento("AutoSp", "Actualizar", dui, codEmp);
                cbd.MostrarDatos(dtgAutos, "select * from autos;");
            }
            catch (Exception)
            {

                MessageBox.Show("Uy, parece que hubo un error", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Registro actualizado!!!");
        }

       public void btnBuscar_Click(object sender, EventArgs e)
        {
            StoredProcedure c = new StoredProcedure();
            c.Buscar(txtBuscar.Text, dtgAutos);
           
        }

        public void dtgAutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void btnBorrar_Click(object sender, EventArgs e)
        {
            string paramBorarrar = dtgAutos.CurrentRow.Cells[0].Value.ToString();
            StoredProcedure c = new StoredProcedure();
            c.Borrar(paramBorarrar);
            cbd.MostrarDatos(dtgAutos, "select * from autos;");
        }
        
    }
}
