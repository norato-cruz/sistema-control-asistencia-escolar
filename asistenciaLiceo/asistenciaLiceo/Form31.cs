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
    public partial class Form31 : FormBase
    {
        public Form31()
        {
            InitializeComponent();
        }

        private void Form31_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Docentes' Puede moverla o quitarla según sea necesario.
            this.docentesTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Docentes);
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.ConsultaAuditoríaRegistrosporUsuario' Puede moverla o quitarla según sea necesario.
            this.consultaAuditoríaRegistrosporUsuarioTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.ConsultaAuditoríaRegistrosporUsuario);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int docente;

            try
            {
                docente = Convert.ToInt32(comboBox1.SelectedValue);

                if (this.consultaAuditoríaRegistrosporUsuarioTableAdapter.Consulta1(asistenciaLiceoItalianoDataSet.ConsultaAuditoríaRegistrosporUsuario, docente)==1)
                {
                    MessageBox.Show("¡Se ha buscado correctamente!");
                    comboBox1.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se ha encontrado.");
                    comboBox1.SelectedIndex = -1;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form29 form = new Form29();
            form.Show();
            this.Hide();
        }
    }
}
