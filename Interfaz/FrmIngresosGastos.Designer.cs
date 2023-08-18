using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
    partial class FrmIngresosGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresosGastos));
            this.GcIngresosGastos = new System.Windows.Forms.DataGridView();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DtBuscar = new System.Windows.Forms.DateTimePicker();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NuMonto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.RbIngreso = new System.Windows.Forms.RadioButton();
            this.RbGasto = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.DtFecha = new System.Windows.Forms.DateTimePicker();
            this.CbFormaPago = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GcIngresosGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // GcIngresosGastos
            // 
            this.GcIngresosGastos.AllowUserToAddRows = false;
            this.GcIngresosGastos.AllowUserToDeleteRows = false;
            this.GcIngresosGastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.GcIngresosGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GcIngresosGastos.Dock = System.Windows.Forms.DockStyle.Top;
            this.GcIngresosGastos.GridColor = System.Drawing.Color.Black;
            this.GcIngresosGastos.Location = new System.Drawing.Point(1, 1);
            this.GcIngresosGastos.Name = "GcIngresosGastos";
            this.GcIngresosGastos.RowTemplate.Height = 25;
            this.GcIngresosGastos.Size = new System.Drawing.Size(870, 149);
            this.GcIngresosGastos.TabIndex = 0;
            this.GcIngresosGastos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GcIngresosGastos_CellClick);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(370, 499);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(128, 48);
            this.BtnSalir.TabIndex = 41;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(504, 445);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(128, 48);
            this.BtnEliminar.TabIndex = 40;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(370, 445);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(128, 48);
            this.BtnActualizar.TabIndex = 39;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(236, 445);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(128, 48);
            this.BtnAgregar.TabIndex = 38;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(234, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Fecha *";
            // 
            // DtBuscar
            // 
            this.DtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtBuscar.Location = new System.Drawing.Point(401, 171);
            this.DtBuscar.Name = "DtBuscar";
            this.DtBuscar.Size = new System.Drawing.Size(113, 23);
            this.DtBuscar.TabIndex = 46;
            this.DtBuscar.ValueChanged += new System.EventHandler(this.DtBuscar_ValueChanged);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(343, 210);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(171, 32);
            this.BtnLimpiar.TabIndex = 45;
            this.BtnLimpiar.Text = "Limpiar campos";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(340, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Fecha";
            // 
            // NuMonto
            // 
            this.NuMonto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NuMonto.DecimalPlaces = 2;
            this.NuMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuMonto.Location = new System.Drawing.Point(237, 329);
            this.NuMonto.Name = "NuMonto";
            this.NuMonto.Size = new System.Drawing.Size(111, 23);
            this.NuMonto.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(235, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Monto *";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(502, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Descripción *";
            // 
            // RtxtDescripcion
            // 
            this.RtxtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RtxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtDescripcion.Location = new System.Drawing.Point(504, 269);
            this.RtxtDescripcion.Name = "RtxtDescripcion";
            this.RtxtDescripcion.Size = new System.Drawing.Size(128, 93);
            this.RtxtDescripcion.TabIndex = 50;
            this.RtxtDescripcion.Text = "";
            // 
            // RbIngreso
            // 
            this.RbIngreso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RbIngreso.AutoSize = true;
            this.RbIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbIngreso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RbIngreso.Location = new System.Drawing.Point(505, 367);
            this.RbIngreso.Name = "RbIngreso";
            this.RbIngreso.Size = new System.Drawing.Size(73, 21);
            this.RbIngreso.TabIndex = 51;
            this.RbIngreso.TabStop = true;
            this.RbIngreso.Text = "Ingreso";
            this.RbIngreso.UseVisualStyleBackColor = true;
            this.RbIngreso.CheckedChanged += new System.EventHandler(this.RbIngreso_CheckedChanged);
            // 
            // RbGasto
            // 
            this.RbGasto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RbGasto.AutoSize = true;
            this.RbGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbGasto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RbGasto.Location = new System.Drawing.Point(505, 394);
            this.RbGasto.Name = "RbGasto";
            this.RbGasto.Size = new System.Drawing.Size(64, 21);
            this.RbGasto.TabIndex = 52;
            this.RbGasto.TabStop = true;
            this.RbGasto.Text = "Gasto";
            this.RbGasto.UseVisualStyleBackColor = true;
            this.RbGasto.CheckedChanged += new System.EventHandler(this.RbGasto_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(21, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "ID";
            this.label5.Visible = false;
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(20, 219);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(34, 23);
            this.TxtID.TabIndex = 54;
            this.TxtID.Visible = false;
            // 
            // DtFecha
            // 
            this.DtFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFecha.Location = new System.Drawing.Point(236, 269);
            this.DtFecha.Name = "DtFecha";
            this.DtFecha.Size = new System.Drawing.Size(112, 23);
            this.DtFecha.TabIndex = 55;
            this.DtFecha.Value = new System.DateTime(2023, 2, 26, 0, 0, 0, 0);
            // 
            // CbFormaPago
            // 
            this.CbFormaPago.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbFormaPago.FormattingEnabled = true;
            this.CbFormaPago.Location = new System.Drawing.Point(238, 391);
            this.CbFormaPago.Name = "CbFormaPago";
            this.CbFormaPago.Size = new System.Drawing.Size(110, 24);
            this.CbFormaPago.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(235, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "Forma de pago *";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(4, 584);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 36);
            this.label10.TabIndex = 59;
            this.label10.Text = "Notas: \r\nLos campos con * son abligatorios";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(4, 620);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(558, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Los ingresos por mensualidades se deben editar desde la ventana de \"mensualidades" +
    "\"";
            // 
            // FrmIngresosGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(872, 647);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbFormaPago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DtFecha);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RbGasto);
            this.Controls.Add(this.RbIngreso);
            this.Controls.Add(this.RtxtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NuMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtBuscar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.GcIngresosGastos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmIngresosGastos";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresos y gastos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmIngresosGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GcIngresosGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GcIngresosGastos;
        private Button BtnSalir;
        private Button BtnEliminar;
        private Button BtnActualizar;
        private Button BtnAgregar;
        private Label label2;
        private DateTimePicker DtBuscar;
        private Button BtnLimpiar;
        private Label label1;
        private NumericUpDown NuMonto;
        private Label label3;
        private Label label4;
        private RichTextBox RtxtDescripcion;
        private RadioButton RbIngreso;
        private RadioButton RbGasto;
        private Label label5;
        private TextBox TxtID;
        private DateTimePicker DtFecha;
        private ComboBox CbFormaPago;
        private Label label7;
        private Label label10;
        private Label label6;
    }
}