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
    public partial class Form8 : FormBase
    {
        public bool activo;
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void docentesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.docentesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.TiposAcceso' Puede moverla o quitarla según sea necesario.
            this.tiposAccesoTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.TiposAcceso);
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Docentes' Puede moverla o quitarla según sea necesario.
            this.docentesTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Docentes);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre, apellido, usuario, contra; int acceso;

            try
            {
                nombre = textBox1.Text; apellido = textBox2.Text;
                usuario = textBox3.Text; contra = textBox4.Text;
                acceso = Convert.ToInt32(comboBox1.SelectedValue);

                if (radioButton1.Checked == true)
                {
                    activo = true;                   
                }
                else
                {
                    activo = false;
                }

                if (this.docentesTableAdapter.guardar(nombre,apellido,usuario, contra,acceso,activo)==1)
                {
                    textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                    comboBox1.SelectedIndex = -1;
                    MessageBox.Show("¡El dato se ha guardado correctamente!");
                }
                else
                {
                    textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                    comboBox1.SelectedIndex = -1;
                    MessageBox.Show("No se ha podido guardar el dato, ingrese correctamente los valroes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.Show();
        }
    }
}
