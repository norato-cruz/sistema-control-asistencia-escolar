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
    public partial class Form41 : FormBase
    {
        public Form41()
        {
            InitializeComponent();
        }

        private void Form41_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Reporte2' Puede moverla o quitarla según sea necesario.
            this.reporte2TableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Reporte2);

            reportViewer1.LocalReport.ReportPath = "Report3.rdlc";
            DataTable consulta = reporte2TableAdapter.reportDocente(SesionUsuario.IdDocente);
            ReportDataSource rds = new ReportDataSource("DataSet1", consulta);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
