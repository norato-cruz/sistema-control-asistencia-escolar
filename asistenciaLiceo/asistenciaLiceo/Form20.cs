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
    public partial class Form20 : FormBase
    {
        public bool activo;
        public Form20()
        {
            InitializeComponent();
        }

        private void matriculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.matriculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form20_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Grados' Puede moverla o quitarla según sea necesario.
            this.gradosTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Grados);
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Alumnos);
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Matriculas' Puede moverla o quitarla según sea necesario.
            this.matriculasTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Matriculas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int alumno, grado; string fecha;

            try
            {
                alumno = Convert.ToInt32(comboBox1.SelectedValue); 
                grado = Convert.ToInt32(comboBox2.SelectedValue);
                fecha = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                if (radioButton1.Checked == true)
                {
                    activo = true;
                }
                else
                {
                    activo = false;
                }
                if (this.matriculasTableAdapter.guardar(alumno, grado,Convert.ToDateTime(fecha),activo)==1)
                {
                    MessageBox.Show("¡Se ha guardado dato correctamnete!");
                    comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1;
                    radioButton1.Checked = false; radioButton2.Checked = false; 
                }
                else
                {
                    MessageBox.Show("No se ha podido guardar. Ingrese datos correctamente.");
                    comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1;
                    radioButton1.Checked = false; radioButton2.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form21 form = new Form21();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form22 form = new Form22();
            form.Show();
            this.Hide();
        }
    }
}
