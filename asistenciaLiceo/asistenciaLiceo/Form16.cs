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
    public partial class Form16 : FormBase
    {
        public bool activo;
        public Form16()
        {
            InitializeComponent();
        }

        private void alumnosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumnosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Alumnos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name, lastN;

            try
            {
                name = textBox1.Text; lastN = textBox2.Text;
                if (radioButton1.Checked == true)
                {
                    activo = true;
                }
                else
                {
                    activo = false;
                }

                if(this.alumnosTableAdapter.guardar(name, lastN,activo)==1)
                {
                    MessageBox.Show("¡Se ha guardado dato con éxito!");
                    textBox1.Clear(); textBox2.Clear(); radioButton1.Checked = false; radioButton2.Checked = false;
                }
                else
                {
                    MessageBox.Show("No se ha podido guardar el dato.");
                    textBox1.Clear(); textBox2.Clear(); radioButton1.Checked = false; radioButton2.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form17 form = new Form17();
            form.Show(); 
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form18 form = new Form18();
            form.Show();
            this.Hide();
        }
    }
}
