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
    public partial class Form5 : FormBase
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void añosEscolaresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.añosEscolaresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
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
    }
}
