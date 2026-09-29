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
    public struct AñosE
    {
        public string año, fechaI, fechaF,activo;public int idAño;
    }
    public partial class Form6 : FormBase
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void añosEscolaresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.añosEscolaresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.AñosEscolares' Puede moverla o quitarla según sea necesario.
            this.añosEscolaresTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.AñosEscolares);

        }

        private void añosEscolaresDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AñosE enviado;

            if (e.RowIndex != -1)
            {
                enviado.idAño = Convert.ToInt16(añosEscolaresDataGridView.Rows[e.RowIndex].Cells[0].Value);
                enviado.año = añosEscolaresDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                enviado.fechaI = añosEscolaresDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                enviado.fechaF = añosEscolaresDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                enviado.activo = añosEscolaresDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                Form7 form = new Form7(enviado);
                form.Show();

                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }
    }
}
