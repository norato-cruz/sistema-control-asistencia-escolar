using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using asistenciaLiceo.TEMA;

namespace asistenciaLiceo
{
    public partial class Form7 : FormBase
    {
        public bool activO;
        public Form7(AñosE x)
        {
            InitializeComponent();
            textBox2.Text = x.idAño.ToString();
            textBox1.Text = x.año.ToString();
            dateTimePicker1.Value = DateTime.Parse(x.fechaI);
            dateTimePicker2.Value = DateTime.Parse(x.fechaF);
            if (Convert.ToBoolean(x.activo) == true)
            {
                radioButton1.Checked = true;  // Se selecciona el "Sí"
            }
            else
            {
                radioButton2.Checked = true;  // Se selecciona el "No"
            }

        }

        private void añosEscolaresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.añosEscolaresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.AñosEscolares' Puede moverla o quitarla según sea necesario.
            this.añosEscolaresTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.AñosEscolares);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string año, fechaI, fechaF;int id;

            try
            {
                id = Convert.ToInt16(textBox2.Text);
                año = textBox1.Text;
                fechaI = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                fechaF = dateTimePicker2.Value.ToString("dd/MM/yyyy");

                if (radioButton1.Checked == true)
                {
                    activO = true;
                }
                else
                {
                    activO = false;
                }

                if (this.añosEscolaresTableAdapter.modificar(año, Convert.ToDateTime(fechaI), Convert.ToDateTime(fechaF), activO,id) == 1)
                {
                    textBox1.Clear();
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;

                    MessageBox.Show("¡El dato se ha modificado con éxito!");
                }
                else
                {
                    MessageBox.Show("El dato no se ha podido modificar, ingresar correctamente los datos.");                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string año, fechaI, fechaF; int id;

            try
            {
                id = Convert.ToInt16(textBox2.Text);
                año = textBox1.Text;
                fechaI = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                fechaF = dateTimePicker2.Value.ToString("dd/MM/yyyy");

                if (radioButton1.Checked == true)
                {
                    activO = true;
                }
                else
                {
                    activO = false;
                }

                this.añosEscolaresTableAdapter.eliminar(id);
                MessageBox.Show("¡El dato se ha eliminado con éxito!");
                textBox1.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
