namespace grupo6_proyectoFinal
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.mtbDui = new System.Windows.Forms.MaskedTextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCliente
            // 
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Location = new System.Drawing.Point(318, 45);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.Size = new System.Drawing.Size(638, 397);
            this.dtgCliente.TabIndex = 35;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Black;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBorrar.Location = new System.Drawing.Point(821, 464);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(84, 31);
            this.btnBorrar.TabIndex = 28;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscar.Location = new System.Drawing.Point(15, 269);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(142, 20);
            this.txtBuscar.TabIndex = 33;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(163, 269);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 31);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.Color.Maroon;
            this.grpDatos.Controls.Add(this.btnLimpiar);
            this.grpDatos.Controls.Add(this.btnBuscar);
            this.grpDatos.Controls.Add(this.mtbDui);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.txtBuscar);
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
            this.grpDatos.Size = new System.Drawing.Size(270, 585);
            this.grpDatos.TabIndex = 36;
            this.grpDatos.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Black;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.Location = new System.Drawing.Point(26, 395);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 31);
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // mtbDui
            // 
            this.mtbDui.Location = new System.Drawing.Point(15, 225);
            this.mtbDui.Mask = "99999999-9";
            this.mtbDui.Name = "mtbDui";
            this.mtbDui.Size = new System.Drawing.Size(77, 20);
            this.mtbDui.TabIndex = 27;
            this.mtbDui.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(15, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ingrese Su DUI:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ingrese Su numero telefonico";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(15, 170);
            this.mtbTelefono.Mask = "000-000-0000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(163, 20);
            this.mtbTelefono.TabIndex = 24;
            this.mtbTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCorreo
            // 
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCorreo.Location = new System.Drawing.Point(15, 120);
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
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ingrese Su Correo Electotonico";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtApellido
            // 
            this.txtApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtApellido.Location = new System.Drawing.Point(116, 71);
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
            this.label4.Location = new System.Drawing.Point(116, 55);
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
            this.btnAgregar.Location = new System.Drawing.Point(10, 358);
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
            this.btnActualizar.Location = new System.Drawing.Point(94, 358);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(84, 31);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AcceptsReturn = true;
            this.txtNombre.AcceptsTab = true;
            this.txtNombre.AccessibleName = "txt";
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombre.Location = new System.Drawing.Point(10, 71);
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
            this.lblDatosAuto.Location = new System.Drawing.Point(12, 55);
            this.lblDatosAuto.Name = "lblDatosAuto";
            this.lblDatosAuto.Size = new System.Drawing.Size(98, 13);
            this.lblDatosAuto.TabIndex = 19;
            this.lblDatosAuto.Text = "Ingrese Su Nombre";
            this.lblDatosAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(989, 585);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dtgCliente);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDatosAuto;
        protected System.Windows.Forms.Button btnLimpiar;
        protected System.Windows.Forms.Button btnAgregar;
        protected System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.TextBox txtCorreo;
        public System.Windows.Forms.MaskedTextBox mtbTelefono;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.MaskedTextBox mtbDui;
        public System.Windows.Forms.GroupBox grpDatos;

    }
}