using System;
using System.CodeDom;
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
    public partial class Form12 : FormBase
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void gradosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gradosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form12_Load(object sender, EventArgs e)
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
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string grado, seccion; int año, docente;

            try
            {
                grado = textBox1.Text; seccion = textBox2.Text;
                año = Convert.ToInt32(comboBox1.SelectedValue);
                docente = Convert.ToInt32(comboBox2.SelectedValue);

                if (this.gradosTableAdapter.guardar(grado,seccion,año,docente)==1)
                {
                    MessageBox.Show("¡El dato se ha guardado con éxito!");
                    textBox1.Clear();textBox2.Clear();
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
            Form13 form = new Form13();
            form.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form14 form = new Form14();
            form.Show();
            this.Hide();
        }
    }
}
