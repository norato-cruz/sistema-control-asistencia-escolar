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
    public partial class Form19 : FormBase
    {
        public bool activ0;
        public Form19(Alumnos x)
        {
            InitializeComponent();
            textBox1.Text = x.name.ToString();
            textBox2.Text = x.lastN.ToString();
            textBox3.Text = x.id.ToString();
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
            Form16 form = new Form16();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name, lastN; int id;

            try
            {
                name = textBox1.Text; lastN = textBox2.Text; id = Convert.ToInt32(textBox3.Text);
                if (radioButton1.Checked == true)
                {
                    activ0 = true;
                }
                else
                {
                    activ0 = false;
                }

                if (this.alumnosTableAdapter.modificar(name, lastN, activ0,id) == 1)
                {
                    MessageBox.Show("¡Se ha modificado dato con éxito!");
                    textBox1.Clear(); textBox2.Clear(); radioButton1.Checked = false; radioButton2.Checked = false;
                }
                else
                {
                    MessageBox.Show("No se ha podido modificar el dato.");
                    textBox1.Clear(); textBox2.Clear(); radioButton1.Checked = false; radioButton2.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void alumnosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumnosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form19_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Alumnos);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name, lastN; int id;

            try
            {
                name = textBox1.Text; lastN = textBox2.Text; id = Convert.ToInt32(textBox3.Text);
                if (radioButton1.Checked == true)
                {
                    activ0 = true;
                }
                else
                {
                    activ0 = false;
                }

                    this.alumnosTableAdapter.eliminar(id);
                    MessageBox.Show("¡Se ha Eliminado dato con éxito!");
                    textBox1.Clear(); textBox2.Clear(); radioButton1.Checked = false; radioButton2.Checked = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
