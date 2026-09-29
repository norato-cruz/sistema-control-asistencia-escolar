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
    public partial class Form15 : FormBase
    {
        public Form15(grados x)
        {
            InitializeComponent();
            textBox3.Text = x.id.ToString();
            textBox1.Text = x.grado.ToString();
            textBox2.Text = x.seccion.ToString();
            comboBox1.SelectedValue = x.año.ToString();
            comboBox2.SelectedValue = x.docente.ToString();
        }

        private void gradosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gradosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Docentes' Puede moverla o quitarla según sea necesario.
            this.docentesTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Docentes);
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.AñosEscolares' Puede moverla o quitarla según sea necesario.
            this.añosEscolaresTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.AñosEscolares);
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Grados' Puede moverla o quitarla según sea necesario.
            this.gradosTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Grados);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 form = new Form14();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string grado, seccion; int id,año, docente;

            try
            {
                id = Convert.ToInt32(textBox3.Text);
                grado = textBox1.Text; seccion = textBox2.Text;
                año = Convert.ToInt32(comboBox1.SelectedValue);
                docente = Convert.ToInt32(comboBox2.SelectedValue);

                if (this.gradosTableAdapter.modificar(grado, seccion, año, docente,id) == 1)
                {
                    MessageBox.Show("¡El dato se ha modificado con éxito!");
                    textBox1.Clear(); textBox2.Clear();
                    comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1;
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show("Ingrese correctamente lo datos.");
                    textBox1.Clear(); textBox2.Clear();
                    comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1;
                    textBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string grado, seccion; int id, año, docente;

            try
            {
                id = Convert.ToInt32(textBox3.Text);
                grado = textBox1.Text; seccion = textBox2.Text;
                año = Convert.ToInt32(comboBox1.SelectedValue);
                docente = Convert.ToInt32(comboBox2.SelectedValue);

                this.gradosTableAdapter.eliminar(id);
                    MessageBox.Show("¡El dato se ha eliminado con éxito!");
                    textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
                comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1;
                    textBox1.Focus();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
