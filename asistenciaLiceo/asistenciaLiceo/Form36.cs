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

namespace asistenciaLiceo
{
    public partial class Form36 : FormBase
    {
        string time; int grad;
        public Form36(string fecha, int grado)
        {
            InitializeComponent();
            time = fecha;
            grad = grado;
        }

        private void Form36_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Reporte1ListaGeneralAsistenciaporFechayGrado' Puede moverla o quitarla según sea necesario.
            this.reporte1ListaGeneralAsistenciaporFechayGradoTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Reporte1ListaGeneralAsistenciaporFechayGrado);

            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            DataTable consulta = reporte1ListaGeneralAsistenciaporFechayGradoTableAdapter.report1(Convert.ToDateTime(time), grad);
            ReportDataSource rds = new ReportDataSource("DataSet1", consulta);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
