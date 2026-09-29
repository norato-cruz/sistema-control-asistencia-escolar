using System;
using System.Drawing;
using System.Windows.Forms;

namespace asistenciaLiceo.TEMA
{
    public static class TemaAplicador
    {
        // =====================================================
        // MÉTODO PRINCIPAL
        // =====================================================

        public static void AplicarTema(Control control)
        {
            // -------------------------
            // FORM
            // -------------------------

            if (control is Form)
            {
                control.BackColor = Tema.Fondo;
                control.ForeColor = Tema.Texto;
            }


            // -------------------------
            // PANEL
            // -------------------------

            else if (control is Panel)
            {
                control.BackColor = Tema.FondoPanel;
            }


            // -------------------------
            // GROUPBOX
            // -------------------------

            else if (control is GroupBox)
            {
                control.BackColor = Tema.FondoPanel;
                control.ForeColor = Tema.Texto;
            }


            // -------------------------
            // LABEL
            // -------------------------

            else if (control is Label)
            {
                control.ForeColor = Tema.Texto;
                control.BackColor = Color.Transparent;
            }


            // -------------------------
            // BUTTON
            // -------------------------

            else if (control is Button boton)
            {
                AplicarBoton(boton);
            }


            // -------------------------
            // TEXTBOX
            // -------------------------

            else if (control is TextBox textBox)
            {
                textBox.BackColor = Tema.Blanco;
                textBox.ForeColor = Tema.Texto;
                textBox.BorderStyle = BorderStyle.FixedSingle;
            }


            // -------------------------
            // COMBOBOX
            // -------------------------

            else if (control is ComboBox comboBox)
            {
                comboBox.BackColor = Tema.Blanco;
                comboBox.ForeColor = Tema.Texto;
                comboBox.FlatStyle = FlatStyle.Flat;
            }


            // -------------------------
            // CHECKBOX
            // -------------------------

            else if (control is CheckBox checkBox)
            {
                checkBox.BackColor = Color.Transparent;
                checkBox.ForeColor = Tema.Texto;
            }


            // -------------------------
            // RADIOBUTTON
            // -------------------------

            else if (control is RadioButton radioButton)
            {
                radioButton.BackColor = Color.Transparent;
                radioButton.ForeColor = Tema.Texto;
            }


            // -------------------------
            // TABPAGE
            // -------------------------

            else if (control is TabPage tabPage)
            {
                tabPage.BackColor = Tema.Fondo;
                tabPage.ForeColor = Tema.Texto;
            }


            // -------------------------
            // TABCONTROL
            // -------------------------

            else if (control is TabControl tabControl)
            {
                tabControl.BackColor = Tema.Fondo;
                tabControl.ForeColor = Tema.Texto;
            }


            // -------------------------
            // DATAGRIDVIEW
            // -------------------------

            else if (control is DataGridView grid)
            {
                AplicarDataGridView(grid);
            }


            // =================================================
            // RECORRER CONTROLES INTERNOS
            // =================================================

            foreach (Control hijo in control.Controls)
            {
                AplicarTema(hijo);
            }
        }


        // =====================================================
        // BOTONES
        // =====================================================

        private static void AplicarBoton(Button boton)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;

            boton.ForeColor = Tema.Blanco;

            // ---------------------------------------------
            // BOTONES ESPECIALES MEDIANTE TAG
            // ---------------------------------------------

            string tipo = boton.Tag?.ToString()?.ToLower();

            if (tipo == "dorado")
            {
                boton.BackColor = Tema.BotonDorado;
            }
            else if (tipo == "peligro")
            {
                boton.BackColor = Tema.BotonPeligro;
            }
            else if (tipo == "exito")
            {
                boton.BackColor = Tema.BotonExito;
            }
            else if (tipo == "secundario")
            {
                boton.BackColor = Tema.AzulSecundario;
            }
            else
            {
                boton.BackColor = Tema.BotonNormal;
            }


            // ---------------------------------------------
            // HOVER / PRESSED AUTOMÁTICOS
            // ---------------------------------------------

            boton.MouseEnter -= Boton_MouseEnter;
            boton.MouseLeave -= Boton_MouseLeave;
            boton.MouseDown -= Boton_MouseDown;
            boton.MouseUp -= Boton_MouseUp;

            boton.MouseEnter += Boton_MouseEnter;
            boton.MouseLeave += Boton_MouseLeave;
            boton.MouseDown += Boton_MouseDown;
            boton.MouseUp += Boton_MouseUp;
        }


        // =====================================================
        // MOUSE ENTER
        // =====================================================

        private static void Boton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button boton && boton.Enabled)
            {
                string tipo = boton.Tag?.ToString()?.ToLower();

                if (tipo == "dorado")
                {
                    boton.BackColor = Tema.DoradoClaro;
                }
                else if (tipo == "peligro")
                {
                    boton.BackColor = Color.FromArgb(220, 80, 90);
                }
                else if (tipo == "exito")
                {
                    boton.BackColor = Color.FromArgb(70, 170, 110);
                }
                else
                {
                    boton.BackColor = Tema.BotonHover;
                }
            }
        }


        // =====================================================
        // MOUSE LEAVE
        // =====================================================

        private static void Boton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button boton && boton.Enabled)
            {
                RestaurarColorBoton(boton);
            }
        }


        // =====================================================
        // MOUSE DOWN
        // =====================================================

        private static void Boton_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button boton && boton.Enabled)
            {
                boton.BackColor = Tema.BotonPressed;
            }
        }


        // =====================================================
        // MOUSE UP
        // =====================================================

        private static void Boton_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Button boton && boton.Enabled)
            {
                string tipo = boton.Tag?.ToString()?.ToLower();

                if (tipo == "dorado")
                {
                    boton.BackColor = Tema.DoradoClaro;
                }
                else
                {
                    boton.BackColor = Tema.BotonHover;
                }
            }
        }


        // =====================================================
        // RESTAURAR COLOR DEL BOTÓN
        // =====================================================

        private static void RestaurarColorBoton(Button boton)
        {
            string tipo = boton.Tag?.ToString()?.ToLower();

            if (tipo == "dorado")
            {
                boton.BackColor = Tema.BotonDorado;
            }
            else if (tipo == "peligro")
            {
                boton.BackColor = Tema.BotonPeligro;
            }
            else if (tipo == "exito")
            {
                boton.BackColor = Tema.BotonExito;
            }
            else if (tipo == "secundario")
            {
                boton.BackColor = Tema.AzulSecundario;
            }
            else
            {
                boton.BackColor = Tema.BotonNormal;
            }
        }


        // =====================================================
        // DATAGRIDVIEW
        // =====================================================

        private static void AplicarDataGridView(DataGridView grid)
        {
            grid.BackgroundColor = Tema.Fondo;
            grid.BorderStyle = BorderStyle.None;

            // Encabezados
            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersDefaultCellStyle.BackColor =
                Tema.AzulInstitucional;

            grid.ColumnHeadersDefaultCellStyle.ForeColor =
                Tema.Blanco;


            // Celdas
            grid.DefaultCellStyle.BackColor =
                Tema.Blanco;

            grid.DefaultCellStyle.ForeColor =
                Tema.Texto;


            // Selección
            grid.DefaultCellStyle.SelectionBackColor =
                Tema.AzulSecundario;

            grid.DefaultCellStyle.SelectionForeColor =
                Tema.Blanco;


            // Bordes
            grid.GridColor = Tema.Borde;


            // Encabezado de filas
            grid.RowHeadersDefaultCellStyle.BackColor =
                Tema.AzulInstitucional;

            grid.RowHeadersDefaultCellStyle.ForeColor =
                Tema.Blanco;
        }
    }
}