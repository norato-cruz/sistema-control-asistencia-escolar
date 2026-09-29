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
    public partial class Form2 : FormBase
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Centro = new Form3();
            Centro.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form29 form = new Form29();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
        "¿Está seguro de que desea cerrar sesión Admin: " + SesionUsuario.Nombre + " " + SesionUsuario.Apellido + " ?",
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
        private void button4_Click(object sender, EventArgs e)
        {
            Form34 form = new Form34();
            form.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
