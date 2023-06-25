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
    public partial class frmCliente : Form
    {
        ConexionBd cbd = new ConexionBd();
        Limpieza l = new Limpieza();

        public frmCliente()
        {
            InitializeComponent();
            cbd.MostrarDatos(dtgCliente, "select * from Clientes_frecuentes;");
        }
        public  void btnAgregar_Click(object sender, EventArgs e)
        {
            string dui, nom, ape, tel, email;
            try
            {
                dui = mtbDui.Text;
                nom=txtNombre.Text;
                ape = txtApellido.Text;
                tel = mtbTelefono.Text;
                email = txtCorreo.Text;

                Cliente c = new Cliente(dui,nom,ape,tel,email);

              

                c.Procedimiento("ClienteSp", "Insertar");
                cbd.MostrarDatos(dtgCliente, "select * from Clientes_frecuentes;");
            }
            catch (Exception)
            {

                MessageBox.Show("Uy, parece que hubo un error", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Registro guardado!!!");
        }

        public  void btnActualizar_Click(object sender, EventArgs e)
        {
            string dui, nom, ape, tel, email;
            try
            {
                dui = mtbDui.Text;
                nom = txtNombre.Text;
                ape = txtApellido.Text;
                tel = mtbTelefono.Text;
                email = txtCorreo.Text;

                Cliente c = new Cliente(dui, nom, ape, tel, email);

                c.Procedimiento("ClienteSp", "Actualizar");
                cbd.MostrarDatos(dtgCliente, "select * from Clientes_frecuentes;");
            }
            catch (Exception)
            {
                MessageBox.Show("Uy, parece que hubo un error", "Error"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            MessageBox.Show("Registro actualizado!!!");
        }

        public  void btnBorrar_Click(object sender, EventArgs e)
        {
            string paramBorarrar = dtgCliente.CurrentRow.Cells[0].Value.ToString();
            StoredProcedure c = new StoredProcedure();
            c.Borrar(paramBorarrar);
            cbd.MostrarDatos(dtgCliente, "select * from Clientes_frecuentes;");
        }

        public  void btnBuscar_Click(object sender, EventArgs e)
        {
            StoredProcedure c = new StoredProcedure();
            c.Buscar(txtBuscar.Text, dtgCliente);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            l.Limpiar(this, grpDatos);
            txtNombre.Focus();
            cbd.MostrarDatos(dtgCliente, "select * from Clientes_frecuentes;");
        }       
    }
}
