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
    public partial class Form25 : FormBase
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void matriculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.matriculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form25_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Matriculas' Puede moverla o quitarla según sea necesario.
            this.matriculasTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Matriculas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
