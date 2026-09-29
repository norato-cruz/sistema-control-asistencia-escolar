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
    public partial class Form24 : FormBase
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void asistenciasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.asistenciasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form24_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Docentes' Puede moverla o quitarla según sea necesario.
            this.docentesTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Docentes);
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.EstadosAsistencia' Puede moverla o quitarla según sea necesario.
            this.estadosAsistenciaTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.EstadosAsistencia);
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Matriculas' Puede moverla o quitarla según sea necesario.
            this.matriculasTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Matriculas);
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Asistencias' Puede moverla o quitarla según sea necesario.
            this.asistenciasTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Asistencias);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form25 form = new Form25();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int matricula, estado, docente; string fecha, motivo;

            try
            {
                matricula = Convert.ToInt32(comboBox1.SelectedValue);
                estado = Convert.ToInt32(comboBox3.SelectedValue);
                docente = Convert.ToInt32(comboBox2.SelectedValue);
                fecha = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                motivo = richTextBox1.Text;

                if (this.asistenciasTableAdapter.guardar(matricula,Convert.ToDateTime(fecha),estado,motivo,docente)==1)
                {
                    MessageBox.Show("¡Se ha guardado dato correctamente!");
                    comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1; comboBox3.SelectedIndex = -1;
                    richTextBox1.Clear();
                }
                else
                {
                    MessageBox.Show("No se ha podido guardar. Ingrese datos correcetamnete.");
                    comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1; comboBox3.SelectedIndex = -1;
                    richTextBox1.Clear();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form26 form = new Form26();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form27 form = new Form27();
            form.Show();
            this.Hide();
        }
    }
}
