namespace grupo6_proyectoFinal
{
    partial class frmAutos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutos));
            this.dtgAutos = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.mtbVin = new System.Windows.Forms.MaskedTextBox();
            this.mtbCod = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.mtbAño = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbDui = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.nudExistencias = new System.Windows.Forms.NumericUpDown();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.nudKms = new System.Windows.Forms.NumericUpDown();
            this.lblDatosAuto = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cboCondicion = new System.Windows.Forms.ComboBox();
            this.lblExistencias = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblKilometros = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblVin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAutos)).BeginInit();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKms)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAutos
            // 
            this.dtgAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAutos.Location = new System.Drawing.Point(286, 46);
            this.dtgAutos.Name = "dtgAutos";
            this.dtgAutos.Size = new System.Drawing.Size(776, 429);
            this.dtgAutos.TabIndex = 2;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Black;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrar.Location = new System.Drawing.Point(951, 499);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(85, 44);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.Color.Maroon;
            this.grpDatos.Controls.Add(this.mtbVin);
            this.grpDatos.Controls.Add(this.mtbCod);
            this.grpDatos.Controls.Add(this.btnLimpiar);
            this.grpDatos.Controls.Add(this.txtBuscar);
            this.grpDatos.Controls.Add(this.nudPrecio);
            this.grpDatos.Controls.Add(this.mtbAño);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Controls.Add(this.mtbDui);
            this.grpDatos.Controls.Add(this.btnBuscar);
            this.grpDatos.Controls.Add(this.nudExistencias);
            this.grpDatos.Controls.Add(this.cboTipo);
            this.grpDatos.Controls.Add(this.nudKms);
            this.grpDatos.Controls.Add(this.lblDatosAuto);
            this.grpDatos.Controls.Add(this.btnAgregar);
            this.grpDatos.Controls.Add(this.btnActualizar);
            this.grpDatos.Controls.Add(this.lblCondicion);
            this.grpDatos.Controls.Add(this.txtModelo);
            this.grpDatos.Controls.Add(this.txtMarca);
            this.grpDatos.Controls.Add(this.cboCondicion);
            this.grpDatos.Controls.Add(this.lblExistencias);
            this.grpDatos.Controls.Add(this.lblPrecio);
            this.grpDatos.Controls.Add(this.lblTipo);
            this.grpDatos.Controls.Add(this.lblKilometros);
            this.grpDatos.Controls.Add(this.lblAño);
            this.grpDatos.Controls.Add(this.lblModelo);
            this.grpDatos.Controls.Add(this.lblMarca);
            this.grpDatos.Controls.Add(this.lblVin);
            this.grpDatos.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDatos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpDatos.Location = new System.Drawing.Point(0, 0);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(3, 3, 150, 3);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(277, 624);
            this.grpDatos.TabIndex = 6;
            this.grpDatos.TabStop = false;
            // 
            // mtbVin
            // 
            this.mtbVin.Location = new System.Drawing.Point(58, 46);
            this.mtbVin.Mask = "99999999999999999";
            this.mtbVin.Name = "mtbVin";
            this.mtbVin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbVin.Size = new System.Drawing.Size(116, 20);
            this.mtbVin.TabIndex = 39;
            this.mtbVin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbCod
            // 
            this.mtbCod.Location = new System.Drawing.Point(146, 383);
            this.mtbCod.Mask = "99999999-9";
            this.mtbCod.Name = "mtbCod";
            this.mtbCod.Size = new System.Drawing.Size(77, 20);
            this.mtbCod.TabIndex = 38;
            this.mtbCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Black;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.Location = new System.Drawing.Point(36, 531);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(174, 31);
            this.btnLimpiar.TabIndex = 37;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(24, 446);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(109, 20);
            this.txtBuscar.TabIndex = 35;
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPrecio.Location = new System.Drawing.Point(149, 320);
            this.nudPrecio.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(95, 20);
            this.nudPrecio.TabIndex = 34;
            this.nudPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbAño
            // 
            this.mtbAño.Location = new System.Drawing.Point(58, 156);
            this.mtbAño.Mask = "9999";
            this.mtbAño.Name = "mtbAño";
            this.mtbAño.Size = new System.Drawing.Size(100, 20);
            this.mtbAño.TabIndex = 33;
            this.mtbAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(143, 367);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 50, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "código empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 367);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 50, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "DUI de comprador";
            // 
            // mtbDui
            // 
            this.mtbDui.Location = new System.Drawing.Point(24, 383);
            this.mtbDui.Mask = "99999999-9";
            this.mtbDui.Name = "mtbDui";
            this.mtbDui.Size = new System.Drawing.Size(77, 20);
            this.mtbDui.TabIndex = 28;
            this.mtbDui.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(149, 440);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 31);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // nudExistencias
            // 
            this.nudExistencias.Location = new System.Drawing.Point(12, 268);
            this.nudExistencias.Name = "nudExistencias";
            this.nudExistencias.Size = new System.Drawing.Size(131, 20);
            this.nudExistencias.TabIndex = 22;
            this.nudExistencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboTipo
            // 
            this.cboTipo.CausesValidation = false;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Deportivo",
            "Sedan",
            "Camioneta",
            "Autobus"});
            this.cboTipo.Location = new System.Drawing.Point(156, 268);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(88, 21);
            this.cboTipo.TabIndex = 21;
            this.cboTipo.Text = "Seleccione...";
            // 
            // nudKms
            // 
            this.nudKms.Location = new System.Drawing.Point(67, 192);
            this.nudKms.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudKms.Name = "nudKms";
            this.nudKms.ReadOnly = true;
            this.nudKms.Size = new System.Drawing.Size(76, 20);
            this.nudKms.TabIndex = 20;
            this.nudKms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDatosAuto
            // 
            this.lblDatosAuto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDatosAuto.Location = new System.Drawing.Point(55, 9);
            this.lblDatosAuto.Name = "lblDatosAuto";
            this.lblDatosAuto.Size = new System.Drawing.Size(167, 23);
            this.lblDatosAuto.TabIndex = 18;
            this.lblDatosAuto.Text = "Ingrese Los Datos Del Auto";
            this.lblDatosAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(36, 495);
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
            this.btnActualizar.Location = new System.Drawing.Point(126, 494);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(84, 31);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblCondicion
            // 
            this.lblCondicion.BackColor = System.Drawing.Color.Black;
            this.lblCondicion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCondicion.Location = new System.Drawing.Point(14, 303);
            this.lblCondicion.Margin = new System.Windows.Forms.Padding(10, 50, 3, 0);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(129, 13);
            this.lblCondicion.TabIndex = 17;
            this.lblCondicion.Text = "Condición";
            this.lblCondicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(58, 123);
            this.txtModelo.MaxLength = 40;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 11;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(58, 80);
            this.txtMarca.MaxLength = 20;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 10;
            // 
            // cboCondicion
            // 
            this.cboCondicion.CausesValidation = false;
            this.cboCondicion.FormattingEnabled = true;
            this.cboCondicion.Items.AddRange(new object[] {
            "Nuevo",
            "Usado"});
            this.cboCondicion.Location = new System.Drawing.Point(17, 319);
            this.cboCondicion.Name = "cboCondicion";
            this.cboCondicion.Size = new System.Drawing.Size(126, 21);
            this.cboCondicion.TabIndex = 2;
            this.cboCondicion.Text = "Seleccione...";
            // 
            // lblExistencias
            // 
            this.lblExistencias.BackColor = System.Drawing.Color.Black;
            this.lblExistencias.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblExistencias.Location = new System.Drawing.Point(16, 252);
            this.lblExistencias.Margin = new System.Windows.Forms.Padding(10, 50, 3, 0);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(127, 13);
            this.lblExistencias.TabIndex = 9;
            this.lblExistencias.Text = "Existencias:";
            this.lblExistencias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.Black;
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecio.Location = new System.Drawing.Point(156, 303);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(10, 50, 3, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(80, 13);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipo
            // 
            this.lblTipo.BackColor = System.Drawing.Color.Black;
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTipo.Location = new System.Drawing.Point(157, 252);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(10, 50, 3, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(87, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo: ";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKilometros
            // 
            this.lblKilometros.AutoSize = true;
            this.lblKilometros.BackColor = System.Drawing.Color.Maroon;
            this.lblKilometros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKilometros.Location = new System.Drawing.Point(9, 199);
            this.lblKilometros.Margin = new System.Windows.Forms.Padding(10, 50, 3, 0);
            this.lblKilometros.Name = "lblKilometros";
            this.lblKilometros.Size = new System.Drawing.Size(29, 13);
            this.lblKilometros.TabIndex = 6;
            this.lblKilometros.Text = "kms:";
            this.lblKilometros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAño.Location = new System.Drawing.Point(9, 163);
            this.lblAño.Margin = new System.Windows.Forms.Padding(10, 50, 3, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 13);
            this.lblAño.TabIndex = 5;
            this.lblAño.Text = "Año:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModelo.Location = new System.Drawing.Point(7, 130);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(10, 50, 3, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarca.Location = new System.Drawing.Point(16, 87);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(10, 50, 3, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.BackColor = System.Drawing.Color.Maroon;
            this.lblVin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVin.Location = new System.Drawing.Point(27, 49);
            this.lblVin.Margin = new System.Windows.Forms.Padding(10, 50, 3, 0);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(25, 13);
            this.lblVin.TabIndex = 2;
            this.lblVin.Text = "Vin:";
            // 
            // frmAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1074, 624);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dtgAutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TodoAutos Sa de CV";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAutos)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAutos;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.MaskedTextBox mtbAño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.NumericUpDown nudExistencias;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.NumericUpDown nudKms;
        private System.Windows.Forms.Label lblDatosAuto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cboCondicion;
        private System.Windows.Forms.Label lblExistencias;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblKilometros;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblVin;
        private System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.MaskedTextBox mtbVin;
        public System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.MaskedTextBox mtbCod;
        private System.Windows.Forms.MaskedTextBox mtbDui;



    }
}

