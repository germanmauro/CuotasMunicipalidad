using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

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
        //Encriptación
        const string hash = "german 123";
        public static string Encrypt(string cadena)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(cadena);

            MD5 md5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();

            tripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripleDES.Mode = CipherMode.ECB;
            
            ICryptoTransform cryptoTransform = tripleDES.CreateEncryptor();
            byte[] result = cryptoTransform.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(result);

        }
    }
}
    
