using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
    partial class FrmRutinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRutinas));
            this.GcRutinas = new System.Windows.Forms.DataGridView();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DtBuscar = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RtxtRutina = new System.Windows.Forms.RichTextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.PbImagen = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnImagen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnQuitarImagen = new System.Windows.Forms.Button();
            this.DtFecha = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RtxtTrabajo2Mujeres = new System.Windows.Forms.RichTextBox();
            this.RtxtTrabajo2Hombres = new System.Windows.Forms.RichTextBox();
            this.RtxtTrabajo1Mujeres = new System.Windows.Forms.RichTextBox();
            this.RtxtTrabajo1Hombres = new System.Windows.Forms.RichTextBox();
            this.RtxtCalentaMujeres = new System.Windows.Forms.RichTextBox();
            this.RtxtCalentaHombres = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RtxtTrabajo3Mujeres = new System.Windows.Forms.RichTextBox();
            this.RtxtTrabajo3Hombres = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GcRutinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagen)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GcRutinas
            // 
            this.GcRutinas.AllowUserToAddRows = false;
            this.GcRutinas.AllowUserToDeleteRows = false;
            this.GcRutinas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.GcRutinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GcRutinas.Dock = System.Windows.Forms.DockStyle.Top;
            this.GcRutinas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.GcRutinas.Location = new System.Drawing.Point(1, 1);
            this.GcRutinas.MultiSelect = false;
            this.GcRutinas.Name = "GcRutinas";
            this.GcRutinas.ReadOnly = true;
            this.GcRutinas.RowTemplate.Height = 25;
            this.GcRutinas.Size = new System.Drawing.Size(870, 149);
            this.GcRutinas.TabIndex = 0;
            this.GcRutinas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GcRutinas_CellClick);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(366, 224);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(197, 32);
            this.BtnLimpiar.TabIndex = 24;
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
            this.label1.Location = new System.Drawing.Point(389, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fecha";
            // 
            // DtBuscar
            // 
            this.DtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DtBuscar.CustomFormat = "dd/MM/yyyy";
            this.DtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtBuscar.Location = new System.Drawing.Point(442, 187);
            this.DtBuscar.Name = "DtBuscar";
            this.DtBuscar.Size = new System.Drawing.Size(88, 23);
            this.DtBuscar.TabIndex = 25;
            this.DtBuscar.ValueChanged += new System.EventHandler(this.DtBuscar_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(7, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fecha *";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(7, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Rutina ";
            // 
            // RtxtRutina
            // 
            this.RtxtRutina.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RtxtRutina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtRutina.Location = new System.Drawing.Point(7, 320);
            this.RtxtRutina.Name = "RtxtRutina";
            this.RtxtRutina.Size = new System.Drawing.Size(128, 173);
            this.RtxtRutina.TabIndex = 29;
            this.RtxtRutina.Text = "";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(402, 558);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(128, 48);
            this.BtnSalir.TabIndex = 33;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(536, 504);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(128, 48);
            this.BtnEliminar.TabIndex = 32;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(402, 504);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(128, 48);
            this.BtnActualizar.TabIndex = 31;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(268, 504);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(128, 48);
            this.BtnAgregar.TabIndex = 30;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // PbImagen
            // 
            this.PbImagen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbImagen.Location = new System.Drawing.Point(740, 309);
            this.PbImagen.Name = "PbImagen";
            this.PbImagen.Size = new System.Drawing.Size(128, 187);
            this.PbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbImagen.TabIndex = 34;
            this.PbImagen.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnImagen
            // 
            this.BtnImagen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImagen.Location = new System.Drawing.Point(740, 269);
            this.BtnImagen.Name = "BtnImagen";
            this.BtnImagen.Size = new System.Drawing.Size(100, 34);
            this.BtnImagen.TabIndex = 35;
            this.BtnImagen.Text = "Imagen";
            this.BtnImagen.UseVisualStyleBackColor = true;
            this.BtnImagen.Click += new System.EventHandler(this.BtnImagen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(8, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "ID";
            this.label4.Visible = false;
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(31, 169);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(29, 23);
            this.TxtID.TabIndex = 37;
            this.TxtID.Visible = false;
            // 
            // BtnQuitarImagen
            // 
            this.BtnQuitarImagen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnQuitarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitarImagen.Location = new System.Drawing.Point(846, 269);
            this.BtnQuitarImagen.Name = "BtnQuitarImagen";
            this.BtnQuitarImagen.Size = new System.Drawing.Size(22, 33);
            this.BtnQuitarImagen.TabIndex = 38;
            this.BtnQuitarImagen.Text = "X";
            this.BtnQuitarImagen.UseVisualStyleBackColor = true;
            this.BtnQuitarImagen.Click += new System.EventHandler(this.BtnQuitarImagen_Click);
            // 
            // DtFecha
            // 
            this.DtFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFecha.Location = new System.Drawing.Point(7, 262);
            this.DtFecha.Name = "DtFecha";
            this.DtFecha.Size = new System.Drawing.Size(78, 23);
            this.DtFecha.TabIndex = 39;
            this.DtFecha.Value = new System.DateTime(2023, 2, 26, 0, 0, 0, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.64171F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.35829F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Controls.Add(this.RtxtTrabajo2Mujeres, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.RtxtTrabajo2Hombres, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.RtxtTrabajo1Mujeres, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.RtxtTrabajo1Hombres, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.RtxtCalentaMujeres, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.RtxtCalentaHombres, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RtxtTrabajo3Mujeres, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.RtxtTrabajo3Hombres, 4, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(189, 267);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.7651F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.2349F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(508, 230);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // RtxtTrabajo2Mujeres
            // 
            this.RtxtTrabajo2Mujeres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxtTrabajo2Mujeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtTrabajo2Mujeres.Location = new System.Drawing.Point(295, 24);
            this.RtxtTrabajo2Mujeres.Name = "RtxtTrabajo2Mujeres";
            this.RtxtTrabajo2Mujeres.Size = new System.Drawing.Size(97, 103);
            this.RtxtTrabajo2Mujeres.TabIndex = 4;
            this.RtxtTrabajo2Mujeres.Text = "";
            // 
            // RtxtTrabajo2Hombres
            // 
            this.RtxtTrabajo2Hombres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxtTrabajo2Hombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtTrabajo2Hombres.Location = new System.Drawing.Point(295, 134);
            this.RtxtTrabajo2Hombres.Name = "RtxtTrabajo2Hombres";
            this.RtxtTrabajo2Hombres.Size = new System.Drawing.Size(97, 92);
            this.RtxtTrabajo2Hombres.TabIndex = 5;
            this.RtxtTrabajo2Hombres.Text = "";
            // 
            // RtxtTrabajo1Mujeres
            // 
            this.RtxtTrabajo1Mujeres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxtTrabajo1Mujeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtTrabajo1Mujeres.Location = new System.Drawing.Point(189, 24);
            this.RtxtTrabajo1Mujeres.Name = "RtxtTrabajo1Mujeres";
            this.RtxtTrabajo1Mujeres.Size = new System.Drawing.Size(99, 103);
            this.RtxtTrabajo1Mujeres.TabIndex = 2;
            this.RtxtTrabajo1Mujeres.Text = "";
            // 
            // RtxtTrabajo1Hombres
            // 
            this.RtxtTrabajo1Hombres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxtTrabajo1Hombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtTrabajo1Hombres.Location = new System.Drawing.Point(189, 134);
            this.RtxtTrabajo1Hombres.Name = "RtxtTrabajo1Hombres";
            this.RtxtTrabajo1Hombres.Size = new System.Drawing.Size(99, 92);
            this.RtxtTrabajo1Hombres.TabIndex = 3;
            this.RtxtTrabajo1Hombres.Text = "";
            // 
            // RtxtCalentaMujeres
            // 
            this.RtxtCalentaMujeres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxtCalentaMujeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtCalentaMujeres.Location = new System.Drawing.Point(79, 24);
            this.RtxtCalentaMujeres.Name = "RtxtCalentaMujeres";
            this.RtxtCalentaMujeres.Size = new System.Drawing.Size(103, 103);
            this.RtxtCalentaMujeres.TabIndex = 0;
            this.RtxtCalentaMujeres.Text = "";
            // 
            // RtxtCalentaHombres
            // 
            this.RtxtCalentaHombres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxtCalentaHombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtCalentaHombres.Location = new System.Drawing.Point(79, 134);
            this.RtxtCalentaHombres.Name = "RtxtCalentaHombres";
            this.RtxtCalentaHombres.Size = new System.Drawing.Size(103, 92);
            this.RtxtCalentaHombres.TabIndex = 1;
            this.RtxtCalentaHombres.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(4, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 109);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mujeres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(4, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 98);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hombres";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(399, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Trabajo #3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(295, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Trabajo #2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(189, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Trabajo #1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(79, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Calentamiento";
            // 
            // RtxtTrabajo3Mujeres
            // 
            this.RtxtTrabajo3Mujeres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxtTrabajo3Mujeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtTrabajo3Mujeres.Location = new System.Drawing.Point(399, 24);
            this.RtxtTrabajo3Mujeres.Name = "RtxtTrabajo3Mujeres";
            this.RtxtTrabajo3Mujeres.Size = new System.Drawing.Size(105, 103);
            this.RtxtTrabajo3Mujeres.TabIndex = 12;
            this.RtxtTrabajo3Mujeres.Text = "";
            // 
            // RtxtTrabajo3Hombres
            // 
            this.RtxtTrabajo3Hombres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxtTrabajo3Hombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtTrabajo3Hombres.Location = new System.Drawing.Point(399, 134);
            this.RtxtTrabajo3Hombres.Name = "RtxtTrabajo3Hombres";
            this.RtxtTrabajo3Hombres.Size = new System.Drawing.Size(105, 92);
            this.RtxtTrabajo3Hombres.TabIndex = 13;
            this.RtxtTrabajo3Hombres.Text = "";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(4, 574);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 55);
            this.label11.TabIndex = 41;
            this.label11.Text = "Notas: \r\nLos campos con * son abligatorios\r\nSe debe completar alguna opción";
            // 
            // FrmRutinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(872, 647);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DtFecha);
            this.Controls.Add(this.BtnQuitarImagen);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnImagen);
            this.Controls.Add(this.PbImagen);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.RtxtRutina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtBuscar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GcRutinas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRutinas";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rutinas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRutinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GcRutinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagen)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GcRutinas;
        private Button BtnLimpiar;
        private Label label1;
        private DateTimePicker DtBuscar;
        private Label label2;
        private Label label3;
        private RichTextBox RtxtRutina;
        private Button BtnSalir;
        private Button BtnEliminar;
        private Button BtnActualizar;
        private Button BtnAgregar;
        private PictureBox PbImagen;
        private OpenFileDialog openFileDialog1;
        private Button BtnImagen;
        private Label label4;
        private TextBox TxtID;
        private Button BtnQuitarImagen;
        private DateTimePicker DtFecha;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox RtxtTrabajo2Mujeres;
        private RichTextBox RtxtTrabajo2Hombres;
        private RichTextBox RtxtTrabajo1Mujeres;
        private RichTextBox RtxtTrabajo1Hombres;
        private RichTextBox RtxtCalentaMujeres;
        private RichTextBox RtxtCalentaHombres;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private RichTextBox RtxtTrabajo3Mujeres;
        private RichTextBox RtxtTrabajo3Hombres;
        private Label label11;
    }
}