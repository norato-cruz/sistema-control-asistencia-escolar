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
    public struct Docentes
    {
        public string nombre, apellido, usuario, contra,activo; public int id,acceso; 
    }
    public partial class Form10 : FormBase
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void docentesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.docentesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Docentes' Puede moverla o quitarla según sea necesario.
            this.docentesTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Docentes);

        }

        private void docentesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Docentes enviado;

            if (e.RowIndex != -1)
            {
                enviado.id = Convert.ToInt32(docentesDataGridView.Rows[e.RowIndex].Cells[0].Value);
                enviado.nombre = docentesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                enviado.apellido = docentesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                enviado.usuario = docentesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                enviado.contra = docentesDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                enviado.acceso = Convert.ToInt32(docentesDataGridView.Rows[e.RowIndex].Cells[5].Value);
                enviado.activo = docentesDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();

                Form11 form = new Form11(enviado);
                form.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
