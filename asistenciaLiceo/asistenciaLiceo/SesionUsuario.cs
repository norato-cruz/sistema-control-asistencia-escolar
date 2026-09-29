using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asistenciaLiceo
{
    public static class SesionUsuario
    {
        public static int IdDocente { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static int IdTipoAcceso { get; set; }

        // Método opcional para cerrar sesión y limpiar datos
        public static void LimpiarSesion()
        {
            IdDocente = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            IdTipoAcceso = 0;
        }
    }
}
