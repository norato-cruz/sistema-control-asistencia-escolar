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
    public partial class Form35 : FormBase
    {
        public Form35()
        {
            InitializeComponent();
        }

        private void Form35_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Grados' Puede moverla o quitarla según sea necesario.
            this.gradosTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Grados);
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Reporte1ListaGeneralAsistenciaporFechayGrado' Puede moverla o quitarla según sea necesario.
            this.reporte1ListaGeneralAsistenciaporFechayGradoTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Reporte1ListaGeneralAsistenciaporFechayGrado);

        }

        private void reporte1ListaGeneralAsistenciaporFechayGradoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form34 form = new Form34();
            form.Show(); this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha; int grado;

            try
            {
                fecha = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                grado = Convert.ToInt32(comboBox1.SelectedValue);

                Form36 form = new Form36(fecha,grado);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
