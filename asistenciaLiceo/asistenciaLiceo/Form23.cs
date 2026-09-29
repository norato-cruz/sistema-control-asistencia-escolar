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
    public partial class Form23 : FormBase
    {
        public bool activ0;
        public Form23(matricula x)
        {
            InitializeComponent();
            comboBox1.SelectedValue = x.alumno.ToString();
            comboBox2.SelectedValue = x.grado.ToString();
            textBox1.Text = x.id.ToString();
            dateTimePicker1.Value = DateTime.Parse(x.fecha);
            if (Convert.ToBoolean(x.activo) == true)
            {
                radioButton1.Checked = true;  // Se selecciona el "Sí"
            }
            else
            {
                radioButton2.Checked = true;  // Se selecciona el "No"
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form20 form = new Form20();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id,alumno, grado; string fecha;

            try
            {
                id = Convert.ToInt32(textBox1.Text);
                alumno = Convert.ToInt32(comboBox1.SelectedValue);
                grado = Convert.ToInt32(comboBox2.SelectedValue);
                fecha = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                if (radioButton1.Checked == true)
                {
                    activ0 = true;
                }
                else
                {
                    activ0 = false;
                }
                if (this.matriculasTableAdapter.modificar(alumno, grado, Convert.ToDateTime(fecha), activ0,id) == 1)
                {
                    MessageBox.Show("¡Se ha modificado dato correctamnete!");
                    comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1;
                    radioButton1.Checked = false; radioButton2.Checked = false;
                }
                else
                {
                    MessageBox.Show("No se ha podido Modificar. Ingrese datos correctamente.");
                    comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1;
                    radioButton1.Checked = false; radioButton2.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void matriculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.matriculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form23_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Grados' Puede moverla o quitarla según sea necesario.
            this.gradosTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Grados);
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Alumnos);
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Matriculas' Puede moverla o quitarla según sea necesario.
            this.matriculasTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Matriculas);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id, alumno, grado; string fecha;

            try
            {
                id = Convert.ToInt32(textBox1.Text);
                alumno = Convert.ToInt32(comboBox1.SelectedValue);
                grado = Convert.ToInt32(comboBox2.SelectedValue);
                fecha = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                if (radioButton1.Checked == true)
                {
                    activ0 = true;
                }
                else
                {
                    activ0 = false;
                }
                this.matriculasTableAdapter.eliminar(id);
                    MessageBox.Show("¡Se ha eliminado dato correctamnete!");
                    comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1;
                    radioButton1.Checked = false; radioButton2.Checked = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
