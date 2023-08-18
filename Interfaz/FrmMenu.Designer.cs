namespace Interfaz
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.LblUsuario = new System.Windows.Forms.Label();
            this.MnPrincipal = new System.Windows.Forms.MenuStrip();
            this.rutinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosGastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensualidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repRutinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repIngresosGastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repoMensualidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repBitIngresosSalidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repBitMovimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlOpciones = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.MnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(135, 554);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(632, 17);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Bienvenido: ";
            // 
            // MnPrincipal
            // 
            this.MnPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MnPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.MnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rutinasToolStripMenuItem,
            this.ingresosGastosToolStripMenuItem,
            this.mensualidadesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.MnPrincipal.Location = new System.Drawing.Point(1, 1);
            this.MnPrincipal.Name = "MnPrincipal";
            this.MnPrincipal.Size = new System.Drawing.Size(134, 570);
            this.MnPrincipal.TabIndex = 2;
            this.MnPrincipal.Text = "menuStrip1";
            // 
            // rutinasToolStripMenuItem
            // 
            this.rutinasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rutinasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rutinasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rutinasToolStripMenuItem.Name = "rutinasToolStripMenuItem";
            this.rutinasToolStripMenuItem.Size = new System.Drawing.Size(121, 23);
            this.rutinasToolStripMenuItem.Text = "Rutinas";
            this.rutinasToolStripMenuItem.Click += new System.EventHandler(this.BtnRutinas_Click);
            // 
            // ingresosGastosToolStripMenuItem
            // 
            this.ingresosGastosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ingresosGastosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ingresosGastosToolStripMenuItem.Name = "ingresosGastosToolStripMenuItem";
            this.ingresosGastosToolStripMenuItem.Size = new System.Drawing.Size(121, 23);
            this.ingresosGastosToolStripMenuItem.Text = "Ingresos/Gastos";
            this.ingresosGastosToolStripMenuItem.Click += new System.EventHandler(this.BtnIngresosGastos_Click);
            // 
            // mensualidadesToolStripMenuItem
            // 
            this.mensualidadesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.mensualidadesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mensualidadesToolStripMenuItem.Name = "mensualidadesToolStripMenuItem";
            this.mensualidadesToolStripMenuItem.Size = new System.Drawing.Size(121, 23);
            this.mensualidadesToolStripMenuItem.Text = "Mensualidades";
            this.mensualidadesToolStripMenuItem.Click += new System.EventHandler(this.BtnMensualidades_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repRutinasToolStripMenuItem,
            this.repIngresosGastosToolStripMenuItem,
            this.repoMensualidadesToolStripMenuItem,
            this.repBitIngresosSalidasToolStripMenuItem,
            this.repBitMovimientosToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(121, 23);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // repRutinasToolStripMenuItem
            // 
            this.repRutinasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.repRutinasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.repRutinasToolStripMenuItem.Name = "repRutinasToolStripMenuItem";
            this.repRutinasToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.repRutinasToolStripMenuItem.Text = "Rep Rutinas";
            this.repRutinasToolStripMenuItem.Click += new System.EventHandler(this.BtnRepRutinas_Click);
            // 
            // repIngresosGastosToolStripMenuItem
            // 
            this.repIngresosGastosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.repIngresosGastosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.repIngresosGastosToolStripMenuItem.Name = "repIngresosGastosToolStripMenuItem";
            this.repIngresosGastosToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.repIngresosGastosToolStripMenuItem.Text = "Rep Ingresos/Gastos";
            this.repIngresosGastosToolStripMenuItem.Click += new System.EventHandler(this.BtnRepIngresosGastos_Click);
            // 
            // repoMensualidadesToolStripMenuItem
            // 
            this.repoMensualidadesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.repoMensualidadesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.repoMensualidadesToolStripMenuItem.Name = "repoMensualidadesToolStripMenuItem";
            this.repoMensualidadesToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.repoMensualidadesToolStripMenuItem.Text = "Rep Mensualidades";
            this.repoMensualidadesToolStripMenuItem.Click += new System.EventHandler(this.BtnRepMensualidades_Click);
            // 
            // repBitIngresosSalidasToolStripMenuItem
            // 
            this.repBitIngresosSalidasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.repBitIngresosSalidasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.repBitIngresosSalidasToolStripMenuItem.Name = "repBitIngresosSalidasToolStripMenuItem";
            this.repBitIngresosSalidasToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.repBitIngresosSalidasToolStripMenuItem.Text = "Rep Bit Ingresos/Salidas";
            this.repBitIngresosSalidasToolStripMenuItem.Click += new System.EventHandler(this.BtnRepBitIngresosSalidas_Click);
            // 
            // repBitMovimientosToolStripMenuItem
            // 
            this.repBitMovimientosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.repBitMovimientosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.repBitMovimientosToolStripMenuItem.Name = "repBitMovimientosToolStripMenuItem";
            this.repBitMovimientosToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.repBitMovimientosToolStripMenuItem.Text = "Rep Bit Movimientos";
            this.repBitMovimientosToolStripMenuItem.Click += new System.EventHandler(this.BtnRepBitMovimientos_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.permisosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.mantenimientosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(121, 23);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rolesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.BtnRoles_Click);
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.permisosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.permisosToolStripMenuItem.Text = "Permisos";
            this.permisosToolStripMenuItem.Click += new System.EventHandler(this.BtnPermisos_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(121, 23);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.BtnAcercaDe_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(121, 23);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 23);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // PnlOpciones
            // 
            this.PnlOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.PnlOpciones.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Logo3;
            this.PnlOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PnlOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlOpciones.Location = new System.Drawing.Point(135, 1);
            this.PnlOpciones.Margin = new System.Windows.Forms.Padding(0);
            this.PnlOpciones.Name = "PnlOpciones";
            this.PnlOpciones.Size = new System.Drawing.Size(632, 553);
            this.PnlOpciones.TabIndex = 5;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(135, 1);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 553);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(768, 572);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.PnlOpciones);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.MnPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnPrincipal;
            this.Name = "FrmMenu";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.MnPrincipal.ResumeLayout(false);
            this.MnPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem rutinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosGastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensualidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        public System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.ToolStripMenuItem repRutinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repIngresosGastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repBitIngresosSalidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repBitMovimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repoMensualidadesToolStripMenuItem;
        private System.Windows.Forms.Panel PnlOpciones;
        private System.Windows.Forms.Splitter splitter1;
    }
}