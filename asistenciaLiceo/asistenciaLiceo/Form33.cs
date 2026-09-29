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
    public partial class Form33 : FormBase
    {
        public Form33()
        {
            InitializeComponent();
        }

        private void Form33_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Docentes' Puede moverla o quitarla según sea necesario.
            this.docentesTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Docentes);
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.ConsultaListadeAlumnosdelGradoAsignado' Puede moverla o quitarla según sea necesario.
            this.consultaListadeAlumnosdelGradoAsignadoTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.ConsultaListadeAlumnosdelGradoAsignado);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int docente;

            try
            {
                docente = Convert.ToInt32(comboBox1.SelectedValue);


                if ( this.consultaListadeAlumnosdelGradoAsignadoTableAdapter.consulta2(asistenciaLiceoItalianoDataSet.ConsultaListadeAlumnosdelGradoAsignado,docente)==1)
                {
                    MessageBox.Show("¡Se ha buscado correctamente!");
                    comboBox1.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Sin resultados.");
                    comboBox1.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form29 form = new Form29();
            form.Show();
            this.Hide();
        }
    }
}
