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
    public struct Asistencia
    {
        public int id,matricula, estado, docente; public string fecha, motivo;
    }
    public partial class Form27 : FormBase
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void asistenciasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.asistenciasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form27_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Asistencias' Puede moverla o quitarla según sea necesario.
            this.asistenciasTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Asistencias);

        }

        private void asistenciasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Asistencia enviado;

            if (e.RowIndex != -1)
            {
                enviado.id = Convert.ToInt32(asistenciasDataGridView.Rows[e.RowIndex].Cells[0].Value);
                enviado.matricula = Convert.ToInt32(asistenciasDataGridView.Rows[e.RowIndex].Cells[1].Value);
                enviado.fecha = asistenciasDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                enviado.estado = Convert.ToInt32(asistenciasDataGridView.Rows[e.RowIndex].Cells[3].Value);
                enviado.motivo = asistenciasDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                enviado.docente = Convert.ToInt32(asistenciasDataGridView.Rows[e.RowIndex].Cells[5].Value);

                Form28 form = new Form28(enviado);
                form.Show();
                this.Hide();
            }
        }
    }
}
