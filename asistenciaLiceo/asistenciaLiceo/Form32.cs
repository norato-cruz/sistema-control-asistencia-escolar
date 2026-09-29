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
    public partial class Form32 : FormBase
    {
        public Form32()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form29 form = new Form29();
            form.Show();
            this.Hide();
        }

        private void Form32_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.ConsultaControlUsuariosyRolesdelSistema' Puede moverla o quitarla según sea necesario.
            this.consultaControlUsuariosyRolesdelSistemaTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.ConsultaControlUsuariosyRolesdelSistema);

        }
    }
}
