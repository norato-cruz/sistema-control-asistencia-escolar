using asistenciaLiceo.AsistenciaLiceoItalianoDataSetTableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using asistenciaLiceo.TEMA;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace asistenciaLiceo
{
    public partial class Form38 : FormBase
    {
        string fechaIn, fechaFin; int id;
        public Form38( int docente, string fechaI, string fechaF)
        {
            InitializeComponent();
            this.fechaIn = fechaI;
            this.fechaFin = fechaF;
            this.id = docente;
        }

        private void Form38_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Reporte2' Puede moverla o quitarla según sea necesario.
            this.reporte2TableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Reporte2);

            reportViewer1.LocalReport.ReportPath = "Report2.rdlc";
            DataTable consulta = reporte2TableAdapter.report2(id, Convert.ToDateTime(fechaIn), Convert.ToDateTime(fechaFin));
            ReportDataSource rds = new ReportDataSource("DataSet1", consulta);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);


            this.reportViewer1.RefreshReport();
        }
    }
}
