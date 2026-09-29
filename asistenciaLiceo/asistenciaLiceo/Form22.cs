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
    public struct matricula
    {
        public int alumno, grado,id; public string fecha, activo;
    }
    public partial class Form22 : FormBase
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void matriculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.matriculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form22_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Matriculas' Puede moverla o quitarla según sea necesario.
            this.matriculasTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Matriculas);

        }

        private void matriculasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            matricula enviado;

            if (e.RowIndex != -1)
            {
                enviado.id = Convert.ToInt32(matriculasDataGridView.Rows[e.RowIndex].Cells[0].Value);
                enviado.alumno = Convert.ToInt32(matriculasDataGridView.Rows[e.RowIndex].Cells[1].Value);
                enviado.grado = Convert.ToInt32(matriculasDataGridView.Rows[e.RowIndex].Cells[2].Value);
                enviado.fecha = matriculasDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                enviado.activo = matriculasDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                Form23 form = new Form23(enviado);
                form.Show();
                this.Hide();
            }
        }
    }
}
