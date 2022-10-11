using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace BLL
{
    public class Utilidades
    {
        public static void MensajesAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Error");
        }

        public static void MensajesOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Transacción Correcta");
        }

        public static string AgregarComillas(string texto)
        {
            return "'" + texto + "'";
        }
    }
}
