using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asistenciaLiceo
{
    public partial class FormMaestro : Form
    {
        public FormMaestro()
        {
            InitializeComponent();
        }

        private void FormMaestro_Load(object sender, EventArgs e)
        {
            int idDelMaestro = SesionUsuario.IdDocente;
        }
        private void FormMaestro_FormClosing(object sender, FormClosingEventArgs e)
        {            
            SesionUsuario.LimpiarSesion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
        "¿Está seguro de que desea cerrar sesión teacher: "+ SesionUsuario.Nombre + " " + SesionUsuario .Apellido +" ?",
        "Cerrar Sesión",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                // 2. Limpiar completamente los datos del maestro actual
                SesionUsuario.LimpiarSesion();

                // 3. Crear una nueva instancia de la pantalla de Login
                Form1 login = new Form1();
                login.Show();

                // 4. Cerrar o destruir el formulario actual
                this.Close();
            }

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form39 form = new Form39();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form40 form = new Form40();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form41 form = new Form41();
            form.Show();
            
        }
    }
}
