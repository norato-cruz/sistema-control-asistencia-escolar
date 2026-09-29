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

    public struct Alumnos 
    {
        public string name, lastN, activo; public int id;
    }
    public partial class Form18 : FormBase
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void alumnosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumnosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Alumnos);

        }

        private void alumnosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Alumnos enviado;
            
            if (e.RowIndex  != -1)
            {
                enviado.id = Convert.ToInt32(alumnosDataGridView.Rows[e.RowIndex].Cells[0].Value);
                enviado.name = alumnosDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                enviado.lastN = alumnosDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                enviado.activo = alumnosDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

                Form19 form = new Form19(enviado);
                form.Show();
                this.Hide();
            }
        }

        private void alumnosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
