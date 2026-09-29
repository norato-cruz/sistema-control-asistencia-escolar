using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace asistenciaLiceo.TEMA
{
    public static class Tema
    {
        // =====================================================
        // AZULES INSTITUCIONALES
        // =====================================================

        public static Color AzulInstitucional =>
            Color.FromArgb(24, 83, 166);

        public static Color AzulSecundario =>
            Color.FromArgb(45, 99, 179);

        public static Color AzulOscuro =>
            Color.FromArgb(13, 43, 91);


        // =====================================================
        // DORADOS
        // =====================================================

        public static Color Dorado =>
            Color.FromArgb(198, 165, 58);

        public static Color DoradoClaro =>
            Color.FromArgb(221, 199, 117);

        public static Color DoradoOscuro =>
            Color.FromArgb(154, 126, 35);


        // =====================================================
        // BLANCOS Y FONDOS
        // =====================================================

        public static Color Blanco =>
            Color.FromArgb(255, 255, 255);

        public static Color Fondo =>
            Color.FromArgb(244, 246, 249);

        public static Color FondoPanel =>
            Color.FromArgb(255, 255, 255);


        // =====================================================
        // TEXTOS
        // =====================================================

        public static Color Texto =>
            Color.FromArgb(31, 41, 55);

        public static Color TextoSecundario =>
            Color.FromArgb(102, 112, 128);


        // =====================================================
        // BORDES
        // =====================================================

        public static Color Borde =>
            Color.FromArgb(214, 220, 229);


        // =====================================================
        // ESTADOS
        // =====================================================

        public static Color Rojo =>
            Color.FromArgb(198, 57, 70);

        public static Color Verde =>
            Color.FromArgb(46, 140, 87);


        // =====================================================
        // COLORES PARA BOTONES
        // =====================================================

        public static Color BotonNormal =>
            AzulInstitucional;

        public static Color BotonHover =>
            AzulSecundario;

        public static Color BotonPressed =>
            AzulOscuro;

        public static Color BotonDorado =>
            Dorado;

        public static Color BotonPeligro =>
            Rojo;

        public static Color BotonExito =>
            Verde;
    }
}
