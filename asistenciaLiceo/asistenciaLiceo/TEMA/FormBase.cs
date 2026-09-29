using System;
using System.Windows.Forms;

namespace asistenciaLiceo.TEMA
{
    public class FormBase : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            TemaAplicador.AplicarTema(this);
        }
    }
}