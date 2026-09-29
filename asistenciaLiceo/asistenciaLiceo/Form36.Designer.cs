namespace asistenciaLiceo
{
    partial class Form36
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
            this.asistenciaLiceoItalianoDataSet = new asistenciaLiceo.AsistenciaLiceoItalianoDataSet();
            this.reporte1ListaGeneralAsistenciaporFechayGradoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte1ListaGeneralAsistenciaporFechayGradoTableAdapter = new asistenciaLiceo.AsistenciaLiceoItalianoDataSetTableAdapters.Reporte1ListaGeneralAsistenciaporFechayGradoTableAdapter();
            this.tableAdapterManager = new asistenciaLiceo.AsistenciaLiceoItalianoDataSetTableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaLiceoItalianoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte1ListaGeneralAsistenciaporFechayGradoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // asistenciaLiceoItalianoDataSet
            // 
            this.asistenciaLiceoItalianoDataSet.DataSetName = "AsistenciaLiceoItalianoDataSet";
            this.asistenciaLiceoItalianoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporte1ListaGeneralAsistenciaporFechayGradoBindingSource
            // 
            this.reporte1ListaGeneralAsistenciaporFechayGradoBindingSource.DataMember = "Reporte1ListaGeneralAsistenciaporFechayGrado";
            this.reporte1ListaGeneralAsistenciaporFechayGradoBindingSource.DataSource = this.asistenciaLiceoItalianoDataSet;
            // 
            // reporte1ListaGeneralAsistenciaporFechayGradoTableAdapter
            // 
            this.reporte1ListaGeneralAsistenciaporFechayGradoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnosTableAdapter = null;
            this.tableAdapterManager.AñosEscolaresTableAdapter = null;
            this.tableAdapterManager.AsistenciasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DocentesTableAdapter = null;
            this.tableAdapterManager.EstadosAsistenciaTableAdapter = null;
            this.tableAdapterManager.GradosTableAdapter = null;
            this.tableAdapterManager.MatriculasTableAdapter = null;
            this.tableAdapterManager.TiposAccesoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = asistenciaLiceo.AsistenciaLiceoItalianoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1441, 469);
            this.reportViewer1.TabIndex = 0;
            // 
            // Form36
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 469);
            this.Controls.Add(this.reportViewer1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.Name = "Form36";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Form36_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaLiceoItalianoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte1ListaGeneralAsistenciaporFechayGradoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AsistenciaLiceoItalianoDataSet asistenciaLiceoItalianoDataSet;
        private System.Windows.Forms.BindingSource reporte1ListaGeneralAsistenciaporFechayGradoBindingSource;
        private AsistenciaLiceoItalianoDataSetTableAdapters.Reporte1ListaGeneralAsistenciaporFechayGradoTableAdapter reporte1ListaGeneralAsistenciaporFechayGradoTableAdapter;
        private AsistenciaLiceoItalianoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}