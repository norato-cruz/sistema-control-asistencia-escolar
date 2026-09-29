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
    public partial class Form28 : FormBase
    {
        public Form28(Asistencia x)
        {
            InitializeComponent();
            textBox1.Text = x.id.ToString();
            comboBox1.SelectedValue = x.matricula.ToString();
            dateTimePicker1.Value = DateTime.Parse(x.fecha);
            comboBox3.SelectedValue = x.estado.ToString();
            richTextBox1.Text = x.motivo.ToString();
            comboBox2.SelectedValue = x.docente.ToString();
        }

        private void asistenciasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.asistenciasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form28_Load(object sender, EventArgs e)
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
            Form24 form = new Form24();
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
            int id,matricula, estado, docente; string fecha, motivo;

            try
            {
                id = Convert.ToInt32(textBox1.Text);
                matricula = Convert.ToInt32(comboBox1.SelectedValue);
                estado = Convert.ToInt32(comboBox3.SelectedValue);
                docente = Convert.ToInt32(comboBox2.SelectedValue);
                fecha = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                motivo = richTextBox1.Text;

                if (this.asistenciasTableAdapter.modificar(matricula, Convert.ToDateTime(fecha), estado, motivo, docente,id) == 1)
                {
                    MessageBox.Show("¡Se ha modificado dato correctamente!");
                    comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1; comboBox3.SelectedIndex = -1;
                    richTextBox1.Clear();
                }
                else
                {
                    MessageBox.Show("No se ha podido modificar. Ingrese datos correcetamnete.");
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
            int id, matricula, estado, docente; string fecha, motivo;

            try
            {
                id = Convert.ToInt32(textBox1.Text);
                matricula = Convert.ToInt32(comboBox1.SelectedValue);
                estado = Convert.ToInt32(comboBox3.SelectedValue);
                docente = Convert.ToInt32(comboBox2.SelectedValue);
                fecha = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                motivo = richTextBox1.Text;

                this.asistenciasTableAdapter.eliminar(id);
                    MessageBox.Show("¡Se ha eliminado dato correctamente!");
                    comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1; comboBox3.SelectedIndex = -1;
                    richTextBox1.Clear();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
