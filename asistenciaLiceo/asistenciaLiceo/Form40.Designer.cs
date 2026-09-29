namespace asistenciaLiceo
{
    partial class Form40
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form40));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.asistenciaLiceoItalianoDataSet = new asistenciaLiceo.AsistenciaLiceoItalianoDataSet();
            this.asistenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asistenciasTableAdapter = new asistenciaLiceo.AsistenciaLiceoItalianoDataSetTableAdapters.AsistenciasTableAdapter();
            this.tableAdapterManager = new asistenciaLiceo.AsistenciaLiceoItalianoDataSetTableAdapters.TableAdapterManager();
            this.consultaAuditoríaRegistrosporUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaAuditoríaRegistrosporUsuarioTableAdapter = new asistenciaLiceo.AsistenciaLiceoItalianoDataSetTableAdapters.ConsultaAuditoríaRegistrosporUsuarioTableAdapter();
            this.consultaAuditoríaRegistrosporUsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaLiceoItalianoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaAuditoríaRegistrosporUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaAuditoríaRegistrosporUsuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1127, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Consulta - Asistencia Docente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 107;
            this.label2.Text = "MENÚ";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 64);
            this.button1.TabIndex = 106;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // consultaAuditoríaRegistrosporUsuarioBindingSource
            // 
            this.consultaAuditoríaRegistrosporUsuarioBindingSource.DataMember = "ConsultaAuditoríaRegistrosporUsuario";
            this.consultaAuditoríaRegistrosporUsuarioBindingSource.DataSource = this.asistenciaLiceoItalianoDataSet;
            // 
            // consultaAuditoríaRegistrosporUsuarioTableAdapter
            // 
            this.consultaAuditoríaRegistrosporUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // consultaAuditoríaRegistrosporUsuarioDataGridView
            // 
            this.consultaAuditoríaRegistrosporUsuarioDataGridView.AutoGenerateColumns = false;
            this.consultaAuditoríaRegistrosporUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultaAuditoríaRegistrosporUsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.consultaAuditoríaRegistrosporUsuarioDataGridView.DataSource = this.consultaAuditoríaRegistrosporUsuarioBindingSource;
            this.consultaAuditoríaRegistrosporUsuarioDataGridView.Location = new System.Drawing.Point(12, 109);
            this.consultaAuditoríaRegistrosporUsuarioDataGridView.Name = "consultaAuditoríaRegistrosporUsuarioDataGridView";
            this.consultaAuditoríaRegistrosporUsuarioDataGridView.RowHeadersWidth = 62;
            this.consultaAuditoríaRegistrosporUsuarioDataGridView.RowTemplate.Height = 28;
            this.consultaAuditoríaRegistrosporUsuarioDataGridView.Size = new System.Drawing.Size(1086, 269);
            this.consultaAuditoríaRegistrosporUsuarioDataGridView.TabIndex = 107;
            this.consultaAuditoríaRegistrosporUsuarioDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consultaAuditoríaRegistrosporUsuarioDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Docentes_Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre del Docente";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Docentes_Apellido";
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido del Docente";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Alumnos_Nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre del Alumno";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Alumnos_Apellido";
            this.dataGridViewTextBoxColumn5.HeaderText = "Apellido del Alumno";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NombreEstado";
            this.dataGridViewTextBoxColumn6.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdDocente";
            this.dataGridViewTextBoxColumn7.HeaderText = "IdDocente";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // Form40
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 450);
            this.Controls.Add(this.consultaAuditoríaRegistrosporUsuarioDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.Name = "Form40";
            this.Text = "Consulta - Asistencia Docente";
            this.Load += new System.EventHandler(this.Form40_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaLiceoItalianoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaAuditoríaRegistrosporUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaAuditoríaRegistrosporUsuarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private AsistenciaLiceoItalianoDataSet asistenciaLiceoItalianoDataSet;
        private System.Windows.Forms.BindingSource asistenciasBindingSource;
        private AsistenciaLiceoItalianoDataSetTableAdapters.AsistenciasTableAdapter asistenciasTableAdapter;
        private AsistenciaLiceoItalianoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource consultaAuditoríaRegistrosporUsuarioBindingSource;
        private AsistenciaLiceoItalianoDataSetTableAdapters.ConsultaAuditoríaRegistrosporUsuarioTableAdapter consultaAuditoríaRegistrosporUsuarioTableAdapter;
        private System.Windows.Forms.DataGridView consultaAuditoríaRegistrosporUsuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}