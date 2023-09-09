namespace WindowsFormsApp1
{
    partial class FrmGenerarReportes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerarReportes));
            this.mantaFitnessClubDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mantaFitnessClubDataSet = new WindowsFormsApp1.MantaFitnessClubDataSet();
            this.RutinasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RvVerReportes = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.mantaFitnessClubDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantaFitnessClubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RutinasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mantaFitnessClubDataSetBindingSource
            // 
            this.mantaFitnessClubDataSetBindingSource.DataSource = this.mantaFitnessClubDataSet;
            this.mantaFitnessClubDataSetBindingSource.Position = 0;
            // 
            // mantaFitnessClubDataSet
            // 
            this.mantaFitnessClubDataSet.DataSetName = "MantaFitnessClubDataSet";
            this.mantaFitnessClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RutinasBindingSource
            // 
            this.RutinasBindingSource.DataMember = "Rutinas";
            this.RutinasBindingSource.DataSource = this.mantaFitnessClubDataSet;
            // 
            // RvVerReportes
            // 
            this.RvVerReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RvVerReportes.Location = new System.Drawing.Point(0, 0);
            this.RvVerReportes.Name = "RvVerReportes";
            this.RvVerReportes.ServerReport.BearerToken = null;
            this.RvVerReportes.Size = new System.Drawing.Size(906, 390);
            this.RvVerReportes.TabIndex = 0;
            // 
            // FrmGenerarReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 390);
            this.Controls.Add(this.RvVerReportes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGenerarReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.GenerarReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mantaFitnessClubDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantaFitnessClubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RutinasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource mantaFitnessClubDataSetBindingSource;
        private MantaFitnessClubDataSet mantaFitnessClubDataSet;
        private System.Windows.Forms.BindingSource RutinasBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer RvVerReportes;
    }
}