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
    public partial class Form4 : FormBase
    {
        public bool activo;
        public Form4()
        {
            InitializeComponent();
        }

        private void añosEscolaresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.añosEscolaresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.AñosEscolares' Puede moverla o quitarla según sea necesario.
            this.añosEscolaresTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.AñosEscolares);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string año, fechaI, fechaF;

            try
            {
                año = textBox1.Text;
                fechaI = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                fechaF = dateTimePicker2.Value.ToString("dd/MM/yyyy");

                if (radioButton1.Checked == true)
                {
                    activo = true;
                }
                else
                {
                    activo = false;
                }

                if (this.añosEscolaresTableAdapter.guardar(año,Convert.ToDateTime(fechaI),Convert.ToDateTime(fechaF),activo)==1)
                {
                    textBox1.Clear();
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;

                    MessageBox.Show("¡El dato se ha guardado con éxito!");
                }
                else
                {
                    MessageBox.Show("El dato no se ha podido guardar, ingresar correctamente los datos.");
                    textBox1.Clear();
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
            this.Hide();
        }
    }
}
