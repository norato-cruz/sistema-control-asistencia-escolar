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
    public partial class Form29 : FormBase
    {
        public Form29()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form30 form = new Form30();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form31 form = new Form31();
            form.Show(); this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form32 form = new Form32();
            form.Show(); this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form33 form = new Form33(); 
            form.Show(); this.Hide();
        }
    }
}
