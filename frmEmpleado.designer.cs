using System;

namespace grupo6_proyectoFinal
{
    partial class frmEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.nudSueldo = new System.Windows.Forms.NumericUpDown();
            this.mtbCod = new System.Windows.Forms.MaskedTextBox();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lblNeto = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDatosAuto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSueldo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleados.Location = new System.Drawing.Point(332, 22);
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.Size = new System.Drawing.Size(657, 383);
            this.dtgEmpleados.TabIndex = 34;
            this.dtgEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmpleados_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(159, 379);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 31);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscar.Location = new System.Drawing.Point(11, 385);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(142, 20);
            this.txtBuscar.TabIndex = 32;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Black;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBorrar.Location = new System.Drawing.Point(802, 429);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(84, 31);
            this.btnBorrar.TabIndex = 35;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.Color.Maroon;
            this.grpDatos.Controls.Add(this.nudSueldo);
            this.grpDatos.Controls.Add(this.mtbCod);
            this.grpDatos.Controls.Add(this.lbl0);
            this.grpDatos.Controls.Add(this.lblNeto);
            this.grpDatos.Controls.Add(this.btnLimpiar);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.textBox4);
            this.grpDatos.Controls.Add(this.btnBuscar);
            this.grpDatos.Controls.Add(this.txtBuscar);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.mtbTelefono);
            this.grpDatos.Controls.Add(this.txtCorreo);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Controls.Add(this.txtApellido);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.btnAgregar);
            this.grpDatos.Controls.Add(this.btnActualizar);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblDatosAuto);
            this.grpDatos.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDatos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpDatos.Location = new System.Drawing.Point(0, 0);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(3, 3, 150, 3);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(267, 685);
            this.grpDatos.TabIndex = 36;
            this.grpDatos.TabStop = false;
            // 
            // nudSueldo
            // 
            this.nudSueldo.DecimalPlaces = 2;
            this.nudSueldo.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudSueldo.Location = new System.Drawing.Point(0, 335);
            this.nudSueldo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSueldo.Name = "nudSueldo";
            this.nudSueldo.Size = new System.Drawing.Size(97, 20);
            this.nudSueldo.TabIndex = 39;
            this.nudSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbCod
            // 
            this.mtbCod.Location = new System.Drawing.Point(17, 164);
            this.mtbCod.Mask = "99999999-9";
            this.mtbCod.Name = "mtbCod";
            this.mtbCod.Size = new System.Drawing.Size(92, 20);
            this.mtbCod.TabIndex = 38;
            this.mtbCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl0
            // 
            this.lbl0.BackColor = System.Drawing.Color.Black;
            this.lbl0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl0.Location = new System.Drawing.Point(138, 332);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(65, 23);
            this.lbl0.TabIndex = 37;
            this.lbl0.Text = "0";
            this.lbl0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNeto
            // 
            this.lblNeto.AutoSize = true;
            this.lblNeto.BackColor = System.Drawing.Color.Black;
            this.lblNeto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNeto.Location = new System.Drawing.Point(138, 319);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(65, 13);
            this.lblNeto.TabIndex = 36;
            this.lblNeto.Text = "sueldo neto:";
            this.lblNeto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Black;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.Location = new System.Drawing.Point(43, 485);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 31);
            this.btnLimpiar.TabIndex = 35;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(385, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Sueldo Neto:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox4.Location = new System.Drawing.Point(348, 420);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(128, 20);
            this.textBox4.TabIndex = 32;
            this.textBox4.Text = "Ej: Emp0001";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(3, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ingrese Su Sueldo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(6, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Codígo de Empleado:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "numero telefonico";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(0, 277);
            this.mtbTelefono.Mask = "000-000-0000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(163, 20);
            this.mtbTelefono.TabIndex = 24;
            this.mtbTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCorreo
            // 
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCorreo.Location = new System.Drawing.Point(6, 227);
            this.txtCorreo.MaxLength = 100;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(151, 20);
            this.txtCorreo.TabIndex = 23;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ingrese Su Correo Electotonico";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtApellido
            // 
            this.txtApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtApellido.Location = new System.Drawing.Point(9, 110);
            this.txtApellido.MaxLength = 75;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 21;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(8, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ingrese Su Apellido";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(9, 449);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 30);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Black;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizar.Location = new System.Drawing.Point(93, 448);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(84, 31);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombre.Location = new System.Drawing.Point(6, 57);
            this.txtNombre.MaxLength = 75;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDatosAuto
            // 
            this.lblDatosAuto.AutoSize = true;
            this.lblDatosAuto.BackColor = System.Drawing.Color.Black;
            this.lblDatosAuto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDatosAuto.Location = new System.Drawing.Point(6, 41);
            this.lblDatosAuto.Name = "lblDatosAuto";
            this.lblDatosAuto.Size = new System.Drawing.Size(98, 13);
            this.lblDatosAuto.TabIndex = 19;
            this.lblDatosAuto.Text = "Ingrese Su Nombre";
            this.lblDatosAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1146, 685);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dtgEmpleados);
            this.Name = "frmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formulario de empleado";
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSueldo)).EndInit();
            this.ResumeLayout(false);

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblDatosAuto;
        private System.Windows.Forms.Label lblNeto;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.MaskedTextBox mtbCod;
        public System.Windows.Forms.GroupBox grpDatos;
        public System.Windows.Forms.Label lbl0;
        public System.Windows.Forms.NumericUpDown nudSueldo;
       
    }
}