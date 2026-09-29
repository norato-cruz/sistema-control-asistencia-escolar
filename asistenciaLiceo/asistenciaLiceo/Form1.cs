using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using asistenciaLiceo.TEMA;

namespace asistenciaLiceo
{
    public partial class Form1 : FormBase
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Docentes' Puede moverla o quitarla según sea necesario.
            this.docentesTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Docentes);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text.Trim();
            string contraseña = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Validar si existen las credenciales mediante el TableAdapter
                if (this.docentesTableAdapter.ingresar(asistenciaLiceoItalianoDataSet.Docentes, usuario, contraseña) == 1)
                {
                    // Asegurarnos de que los datos más recientes estén cargados en el DataSet
                    this.docentesTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Docentes);

                    DataRow docenteEncontrado = null;

                    // 2. Buscar al docente comparando sin importar mayúsculas/minúsculas ni espacios
                    foreach (DataRow fila in asistenciaLiceoItalianoDataSet.Docentes.Rows)
                    {
                        if (fila["Usuario"] != DBNull.Value &&
                            string.Equals(fila["Usuario"].ToString().Trim(), usuario, StringComparison.OrdinalIgnoreCase))
                        {
                            docenteEncontrado = fila;
                            break;
                        }
                    }

                    if (docenteEncontrado != null)
                    {
                        // 1. Guardar en la Sesión Global
                        SesionUsuario.IdDocente = Convert.ToInt32(docenteEncontrado["IdDocente"]);
                        SesionUsuario.Nombre = docenteEncontrado["Nombre"].ToString();
                        SesionUsuario.Apellido = docenteEncontrado.Table.Columns.Contains("Apellido") ? docenteEncontrado["Apellido"].ToString() : "";
                        SesionUsuario.IdTipoAcceso = Convert.ToInt32(docenteEncontrado["IdTipoAcceso"]);

                        textBox1.Clear();
                        textBox2.Clear();

                        // 2. Abrir formularios
                        if (SesionUsuario.IdTipoAcceso == 1) // Administrador
                        {
                            MessageBox.Show("Bienvenido Admin: " + SesionUsuario.Nombre + " " + SesionUsuario.Apellido);
                            Form2 formAdmin = new Form2();
                            formAdmin.Show();
                        }
                        else if (SesionUsuario.IdTipoAcceso == 2) // Maestro
                        {
                            FormMaestro formMaestro = new FormMaestro();
                            formMaestro.Show();
                        }

                        this.Hide();
                    
                }
                    else
                    {
                        MessageBox.Show("Credenciales correctas, pero no se encontró la columna 'Usuario' equivalente en el DataSet. Verifica los nombres de los campos.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void docentesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.docentesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.asistenciaLiceoItalianoDataSet);

        }
    }
}
