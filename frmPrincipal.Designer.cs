namespace grupo6_proyectoFinal
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.autosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empladosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empladosActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesFrecuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInventario,
            this.empladosToolStripMenuItem,
            this.mnuCliente,
            this.cerrarToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnuInventario
            // 
            this.mnuInventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autosToolStripMenuItem});
            this.mnuInventario.Image = ((System.Drawing.Image)(resources.GetObject("mnuInventario.Image")));
            this.mnuInventario.Name = "mnuInventario";
            this.mnuInventario.Size = new System.Drawing.Size(88, 20);
            this.mnuInventario.Text = "Inventario";
            // 
            // autosToolStripMenuItem
            // 
            this.autosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("autosToolStripMenuItem.Image")));
            this.autosToolStripMenuItem.Name = "autosToolStripMenuItem";
            this.autosToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.autosToolStripMenuItem.Text = "Autos";
            this.autosToolStripMenuItem.Click += new System.EventHandler(this.autosToolStripMenuItem_Click);
            // 
            // empladosToolStripMenuItem
            // 
            this.empladosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empladosActivosToolStripMenuItem});
            this.empladosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empladosToolStripMenuItem.Image")));
            this.empladosToolStripMenuItem.Name = "empladosToolStripMenuItem";
            this.empladosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.empladosToolStripMenuItem.Text = "Emplados";
            // 
            // empladosActivosToolStripMenuItem
            // 
            this.empladosActivosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empladosActivosToolStripMenuItem.Image")));
            this.empladosActivosToolStripMenuItem.Name = "empladosActivosToolStripMenuItem";
            this.empladosActivosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.empladosActivosToolStripMenuItem.Text = "Emplados Activos";
            this.empladosActivosToolStripMenuItem.Click += new System.EventHandler(this.empladosActivosToolStripMenuItem_Click);
            // 
            // mnuCliente
            // 
            this.mnuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesFrecuentesToolStripMenuItem});
            this.mnuCliente.Image = ((System.Drawing.Image)(resources.GetObject("mnuCliente.Image")));
            this.mnuCliente.Name = "mnuCliente";
            this.mnuCliente.Size = new System.Drawing.Size(77, 20);
            this.mnuCliente.Text = "Clientes";
            // 
            // clientesFrecuentesToolStripMenuItem
            // 
            this.clientesFrecuentesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesFrecuentesToolStripMenuItem.Image")));
            this.clientesFrecuentesToolStripMenuItem.Name = "clientesFrecuentesToolStripMenuItem";
            this.clientesFrecuentesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.clientesFrecuentesToolStripMenuItem.Text = "Clientes Frecuentes";
            this.clientesFrecuentesToolStripMenuItem.Click += new System.EventHandler(this.clientesFrecuentesToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarToolStripMenuItem.Image")));
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel.Text = "Todo Autos";
            this.toolStripStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mnuInventario;
        private System.Windows.Forms.ToolStripMenuItem empladosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCliente;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesFrecuentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empladosActivosToolStripMenuItem;
    }
}



