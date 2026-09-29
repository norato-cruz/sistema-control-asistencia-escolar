using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using asistenciaLiceo.TEMA;

namespace asistenciaLiceo
{
    public partial class Form39 : FormBase
    {
        private string CadenaConexion => this.asistenciasTableAdapter.Connection.ConnectionString;

        public Form39()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form39_Load(object sender, EventArgs e)
        {
            CargarComboBoxMatriculas();
            textBox1.Text = SesionUsuario.Nombre + " " + SesionUsuario.Apellido;
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.Asistencias' Puede moverla o quitarla según sea necesario.
            this.asistenciasTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.Asistencias);
            // TODO: esta línea de código carga datos en la tabla 'asistenciaLiceoItalianoDataSet.EstadosAsistencia' Puede moverla o quitarla según sea necesario.
            this.estadosAsistenciaTableAdapter.Fill(this.asistenciaLiceoItalianoDataSet.EstadosAsistencia);
            textBox1.Text = SesionUsuario.Nombre + " " + SesionUsuario.Apellido;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMaestro form = new FormMaestro();
            form.Show();
            this.Hide();
        }
        private void CargarComboBoxMatriculas()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(CadenaConexion))
                {
                    // Forzamos la consulta leyendo directamente los datos físicos actualizados
                    string sql = @"SELECT 
                            m.IdMatricula, 
                            (g.NombreGrado + ' ' + g.Seccion + ' - ' + a.Nombre + ' ' + a.Apellido) AS InfoMatricula 
                          FROM ((Matriculas m
                          INNER JOIN Grados g ON m.IdGrado = g.IdGrado)
                          INNER JOIN Alumnos a ON m.IdAlumno = a.IdAlumno)
                          WHERE g.IdDocente = ?
                          ORDER BY g.NombreGrado, a.Apellido, a.Nombre";

                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        // Pasamos el IdDocente de la sesión activa
                        cmd.Parameters.AddWithValue("@IdDocente", SesionUsuario.IdDocente);

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dtMatriculas = new DataTable();

                        con.Open();
                        adapter.Fill(dtMatriculas);

                        // Asignación directa al ComboBox
                        comboBoxMatricula.DataSource = null;
                        comboBoxMatricula.DisplayMember = "InfoMatricula";
                        comboBoxMatricula.ValueMember = "IdMatricula";
                        comboBoxMatricula.DataSource = dtMatriculas;
                        comboBoxMatricula.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las matrículas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ExisteAsistenciaEnFecha(int idMatricula, DateTime fecha)
        {
            bool existe = false;
            try
            {
                using (OleDbConnection con = new OleDbConnection(CadenaConexion))
                {
                    string sql = "SELECT COUNT(*) FROM Asistencias WHERE IdMatricula = ? AND Fecha = ?";
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@IdMatricula", idMatricula);
                        cmd.Parameters.AddWithValue("@Fecha", fecha.Date);

                        con.Open();
                        int conteo = Convert.ToInt32(cmd.ExecuteScalar());
                        existe = (conteo > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar duplicados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return existe;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboBoxMatricula.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione una matrícula del listado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Variable que guarda la matricula seleccionada
            int idMatriculaSeleccionada = Convert.ToInt32(comboBoxMatricula.SelectedValue);
            DateTime fechaSeleccionada = dateTimePicker1.Value.Date;

            // Validación de duplicados en la misma fecha
            if (ExisteAsistenciaEnFecha(idMatriculaSeleccionada, fechaSeleccionada))
            {
                MessageBox.Show("Ya existe una asistencia registrada para este alumno en la fecha " + fechaSeleccionada.ToString("dd/MM/yyyy") + ".",
                                "Registro Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idEstado = Convert.ToInt32(comboBoxEstado.SelectedValue);
                string motivo = txtMotivo.Text.Trim();
                int idDocente = SesionUsuario.IdDocente;
                
                // Llamada a tu método del TableAdapter para insertar en la tabla Asistencias
                this.asistenciasTableAdapter.guardar(idMatriculaSeleccionada, fechaSeleccionada, idEstado, motivo, idDocente);

                MessageBox.Show("Asistencia guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxMatricula.SelectedIndex = -1;
                comboBoxEstado.SelectedIndex = -1;
                txtMotivo.Clear();

                // Recargar el ComboBox para mantenerlo al día tras guardar
                CargarComboBoxMatriculas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar asistencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


    
