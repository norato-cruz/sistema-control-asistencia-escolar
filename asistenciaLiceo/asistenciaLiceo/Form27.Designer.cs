namespace asistenciaLiceo
{
    partial class Form27
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
            this.asistenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asistenciasTableAdapter = new asistenciaLiceo.AsistenciaLiceoItalianoDataSetTableAdapters.AsistenciasTableAdapter();
            this.tableAdapterManager = new asistenciaLiceo.AsistenciaLiceoItalianoDataSetTableAdapters.TableAdapterManager();
            this.asistenciasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaLiceoItalianoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // asistenciaLiceoItalianoDataSet
            // 
            this.asistenciaLiceoItalianoDataSet.DataSetName = "AsistenciaLiceoItalianoDataSet";
            this.asistenciaLiceoItalianoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asistenciasBindingSource
            // 
            this.asistenciasBindingSource.DataMember = "Asistencias";
            this.asistenciasBindingSource.DataSource = this.asistenciaLiceoItalianoDataSet;
            // 
            // asistenciasTableAdapter
            // 
            this.asistenciasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnosTableAdapter = null;
            this.tableAdapterManager.AñosEscolaresTableAdapter = null;
            this.tableAdapterManager.AsistenciasTableAdapter = this.asistenciasTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DocentesTableAdapter = null;
            this.tableAdapterManager.EstadosAsistenciaTableAdapter = null;
            this.tableAdapterManager.GradosTableAdapter = null;
            this.tableAdapterManager.MatriculasTableAdapter = null;
            this.tableAdapterManager.TiposAccesoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = asistenciaLiceo.AsistenciaLiceoItalianoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // asistenciasDataGridView
            // 
            this.asistenciasDataGridView.AllowUserToAddRows = false;
            this.asistenciasDataGridView.AllowUserToDeleteRows = false;
            this.asistenciasDataGridView.AutoGenerateColumns = false;
            this.asistenciasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asistenciasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.asistenciasDataGridView.DataSource = this.asistenciasBindingSource;
            this.asistenciasDataGridView.Location = new System.Drawing.Point(12, 80);
            this.asistenciasDataGridView.Name = "asistenciasDataGridView";
            this.asistenciasDataGridView.ReadOnly = true;
            this.asistenciasDataGridView.RowHeadersWidth = 62;
            this.asistenciasDataGridView.RowTemplate.Height = 28;
            this.asistenciasDataGridView.Size = new System.Drawing.Size(1039, 358);
            this.asistenciasDataGridView.TabIndex = 1;
            this.asistenciasDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asistenciasDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdAsistencia";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdAsistencia";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdMatricula";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdMatricula";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdEstado";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdEstado";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Motivo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Motivo";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdDocente";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdDocente";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 42);
            this.label1.TabIndex = 86;
            this.label1.Text = "Modificar / Eliminar  -  Asistencia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form27
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asistenciasDataGridView);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.Name = "Form27";
            this.Text = "Modificar / Eliminar - Asistencia";
            this.Load += new System.EventHandler(this.Form27_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaLiceoItalianoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AsistenciaLiceoItalianoDataSet asistenciaLiceoItalianoDataSet;
        private System.Windows.Forms.BindingSource asistenciasBindingSource;
        private AsistenciaLiceoItalianoDataSetTableAdapters.AsistenciasTableAdapter asistenciasTableAdapter;
        private AsistenciaLiceoItalianoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView asistenciasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
    }
}