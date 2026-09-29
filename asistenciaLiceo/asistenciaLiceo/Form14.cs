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
    public struct grados
    {
        public string grado, seccion; public int id,año, docente;
    }
    public partial class Form14 : FormBase
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 form = new Form12();
            form.Show();
            this.Hide();
        }

        private void gradosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gradosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Grados' Puede moverla o quitarla según sea necesario.
            this.gradosTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Grados);

        }

        private void gradosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grados enviado;

            if(e.RowIndex != -1)
            {
                enviado.id = Convert.ToInt32(gradosDataGridView.Rows[e.RowIndex].Cells[0].Value);
                enviado.grado = gradosDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                enviado.seccion = gradosDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                enviado.año = Convert.ToInt32(gradosDataGridView.Rows[e.RowIndex].Cells[3].Value);
                enviado.docente = Convert.ToInt32(gradosDataGridView.Rows[e.RowIndex].Cells[4].Value);

                Form15 form = new Form15(enviado);
                form.Show();
                this.Hide();
            }
        }

        private void gradosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
