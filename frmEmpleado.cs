using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo6_proyectoFinal
{
    public partial class frmEmpleado : Form
    {
        ConexionBd cbd = new ConexionBd();

        public frmEmpleado()
        {
            InitializeComponent();
            cbd.MostrarDatos(dtgEmpleados, "select * from empleados;");
        }
        

        private void dtgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmAutos();
            Hide();
            frm1.ShowDialog();
            Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmCliente();
            Hide();
            frm1.ShowDialog();
            Show();
        }

        public void SueldoNeto()
        {
            CalculoSueldo c = new CalculoSueldo();
            c.sueldo = Convert.ToDouble(nudSueldo.Text);
            lbl0.Text = c.SueldoNeto().ToString();
        }

        Limpieza l = new Limpieza();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string codEmp, nom, ape, tel, email;
            decimal sal;
            
            try
            {
                codEmp = mtbCod.Text;
                nom = txtNombre.Text;
                ape = txtApellido.Text;
                sal =nudSueldo.Value;
                tel = mtbTelefono.Text;
                email = txtCorreo.Text;

                Empleado emp = new Empleado(codEmp, nom, ape, sal, tel, email);
                emp.Procedimiento("EmpleadoSp", "Insertar");
                cbd.MostrarDatos(dtgEmpleados, "select * from empleados;");

                SueldoNeto();
            }
            catch (Exception)
            {
                MessageBox.Show("Uy, parece que hubo un error", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Registro guardado!!!");
                    
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string codEmp, nom, ape, tel, email;
            decimal sal;
            try
            {
                codEmp = mtbCod.Text;
                nom = txtNombre.Text;
                ape = txtApellido.Text;
                sal = nudSueldo.Value;
                tel = mtbTelefono.Text;
                email = txtCorreo.Text;

                Empleado emp = new Empleado(codEmp,nom,ape,sal,tel,email);
                emp.Procedimiento("EmpleadoSp", "Actualizar");
                cbd.MostrarDatos(dtgEmpleados, "select * from empleados;");
                SueldoNeto();
            }
            catch (Exception)
            {

                MessageBox.Show("Uy, parece que hubo un error", "Error"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Registro actualizado!!!");
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            string paramBorarrar = dtgEmpleados.CurrentRow.Cells[0].Value.ToString();
            StoredProcedure c = new StoredProcedure();
            c.Borrar(paramBorarrar);
            cbd.MostrarDatos(dtgEmpleados, "select * from empleados;");
            MessageBox.Show("Registro eliminado!!!");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            StoredProcedure c = new StoredProcedure();
            c.Buscar(txtBuscar.Text, dtgEmpleados);
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            
            l.Limpiar(this, grpDatos);
            txtNombre.Focus();
            lbl0.Text = "0";
        }

    }
}
