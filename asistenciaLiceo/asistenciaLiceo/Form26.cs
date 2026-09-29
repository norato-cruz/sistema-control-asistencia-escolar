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
    public partial class Form26 : FormBase
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void asistenciasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.asistenciasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form26_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Asistencias' Puede moverla o quitarla según sea necesario.
            this.asistenciasTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Asistencias);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form24 form = new Form24();
            form.Show();
            this.Hide();
        }
    }
}
