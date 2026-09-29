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
    
    public partial class Form11 : FormBase
    {
        public bool activO;
        public Form11(Docentes x)
        {
            InitializeComponent();
            textBox5.Text = x.id.ToString();    
            textBox1.Text = x.nombre.ToString();
            textBox2.Text = x.apellido.ToString();
            textBox3.Text = x.usuario.ToString();
            textBox4.Text = x.contra.ToString();
            comboBox1.SelectedValue = x.acceso.ToString();
            if (Convert.ToBoolean(x.activo) == true)
            {
                radioButton1.Checked = true;  // Se selecciona el "Sí"
            }
            else
            {
                radioButton2.Checked = true;  // Se selecciona el "No"
            }

        }

        private void docentesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.docentesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.TiposAcceso' Puede moverla o quitarla según sea necesario.
            this.tiposAccesoTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.TiposAcceso);
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.EstadosAsistencia' Puede moverla o quitarla según sea necesario.
            this.estadosAsistenciaTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.EstadosAsistencia);
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Docentes' Puede moverla o quitarla según sea necesario.
            this.docentesTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Docentes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre, apellido, usuario, contra; int id,acceso;

            try
            {
                id = Convert.ToInt32(textBox5.Text);
                nombre = textBox1.Text; apellido = textBox2.Text;
                usuario = textBox3.Text; contra = textBox4.Text;
                acceso = Convert.ToInt32(comboBox1.SelectedValue);

                if (radioButton1.Checked == true)
                {
                    activO = true;
                }
                else
                {
                    activO = false;
                }

                if (this.docentesTableAdapter.modificar(nombre, apellido, usuario, contra, acceso, activO,id) == 1)
                {
                    
                    MessageBox.Show("¡El dato se ha Modificado correctamente!");
                    textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                    comboBox1.SelectedIndex = -1;
                }
                else
                {
                    
                    MessageBox.Show("No se ha podido guardar el dato, ingrese correctamente los valroes.");
                    textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                    comboBox1.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre, apellido, usuario, contra; int id, acceso;

            try
            {
                id = Convert.ToInt32(textBox5.Text);
                nombre = textBox1.Text; apellido = textBox2.Text;
                usuario = textBox3.Text; contra = textBox4.Text;
                acceso = Convert.ToInt32(comboBox1.SelectedValue);

                if (radioButton1.Checked == true)
                {
                    activO = true;
                }
                else
                {
                    activO = false;
                }

                this.docentesTableAdapter.eliminar(id);
                MessageBox.Show("Se ha eliminado correctamente.");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
