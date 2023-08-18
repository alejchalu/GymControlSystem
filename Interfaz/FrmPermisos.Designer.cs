using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
    partial class FrmPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPermisos));
            this.Rol = new System.Windows.Forms.Label();
            this.CbRol = new System.Windows.Forms.ComboBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.ChlOpciones = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rol
            // 
            this.Rol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Rol.AutoSize = true;
            this.Rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Rol.Location = new System.Drawing.Point(427, 33);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(38, 17);
            this.Rol.TabIndex = 0;
            this.Rol.Text = "Rol *";
            // 
            // CbRol
            // 
            this.CbRol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRol.FormattingEnabled = true;
            this.CbRol.Items.AddRange(new object[] {
            "Seleccione"});
            this.CbRol.Location = new System.Drawing.Point(378, 53);
            this.CbRol.Name = "CbRol";
            this.CbRol.Size = new System.Drawing.Size(142, 24);
            this.CbRol.TabIndex = 1;
            this.CbRol.SelectedIndexChanged += new System.EventHandler(this.CbRol_SelectedIndexChanged);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuardar.Location = new System.Drawing.Point(378, 481);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(142, 56);
            this.BtnGuardar.TabIndex = 22;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSalir.Location = new System.Drawing.Point(378, 543);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(142, 56);
            this.BtnSalir.TabIndex = 23;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // ChlOpciones
            // 
            this.ChlOpciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChlOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChlOpciones.FormattingEnabled = true;
            this.ChlOpciones.Items.AddRange(new object[] {
            "Clientes",
            "Usuarios",
            "Roles",
            "Permisos",
            "Rutinas",
            "Mensualidades",
            "Ingresos/Gastos",
            "Rep Rutinas",
            "Rep Mensualidades",
            "Rep Ingresos/Gastos",
            "Rep Bit Ingresos/Salidas",
            "Rep Bit Movimientos",
            "Acerca De",
            "Ayuda"});
            this.ChlOpciones.Location = new System.Drawing.Point(336, 150);
            this.ChlOpciones.Name = "ChlOpciones";
            this.ChlOpciones.Size = new System.Drawing.Size(207, 256);
            this.ChlOpciones.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(4, 598);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 36);
            this.label10.TabIndex = 32;
            this.label10.Text = "Nota: \r\nLos campos con * son abligatorios";
            // 
            // FrmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(872, 647);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ChlOpciones);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CbRol);
            this.Controls.Add(this.Rol);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPermisos";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permisos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPermisos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Rol;
        private ComboBox CbRol;
        private Button BtnGuardar;
        private Button BtnSalir;
        private CheckedListBox ChlOpciones;
        private Label label10;
    }
}