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
    public partial class Form40 : FormBase
    {
        public Form40()
        {
            InitializeComponent();
        }

        private void asistenciasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.asistenciasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form40_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.ConsultaAuditoríaRegistrosporUsuario' Puede moverla o quitarla según sea necesario.
            this.consultaAuditoríaRegistrosporUsuarioTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.ConsultaAuditoríaRegistrosporUsuario);
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Asistencias' Puede moverla o quitarla según sea necesario.
            this.asistenciasTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Asistencias);

            this.consultaAuditoríaRegistrosporUsuarioTableAdapter.Consulta1(asistenciaLiceoItalianoDataSet.ConsultaAuditoríaRegistrosporUsuario, SesionUsuario.IdDocente);

        }

        private void consultaAuditoríaRegistrosporUsuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMaestro form = new FormMaestro();
            form.Show();
            this.Hide();
        }
    }
}
