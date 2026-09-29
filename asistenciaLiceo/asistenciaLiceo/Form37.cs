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
    public partial class Form37 : FormBase
    {
        public Form37()
        {
            InitializeComponent();
        }

        private void Form37_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Docentes' Puede moverla o quitarla según sea necesario.
            this.docentesTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Docentes);
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Reporte2' Puede moverla o quitarla según sea necesario.
            this.reporte2TableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Reporte2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form34 form = new Form34();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fechaI, fechaF; int docente;

            try
            {
                fechaI = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                fechaF = dateTimePicker2.Value.ToString("dd/MM/yyyy");
                docente = Convert.ToInt32(comboBox1.SelectedValue);

                Form38 form = new Form38(docente,fechaI,fechaF);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
