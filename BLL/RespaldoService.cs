using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;

namespace BLL
{
    public class RespaldoService
    {
        public static bool GenerarBackUp(string route)
        {
            try
            {
                if(DatosDB.ExecuteNonQuery($"BACKUP DATABASE [Cuotas] TO DISK='{route}\\{DateTime.Today.ToString("dd-MM-yyyy")}.bak' WITH NOFORMAT, NOINIT,  NAME = N'Cuotas-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"))
                {
                    Utilidades.MensajesOK("Respaldo generado correctamente");
                    return true;
                }
                else
                {
                    Utilidades.MensajesAdvertencia("Error al generar respaldo");
                    return false;
                }
            }
            catch (Exception e)
            {
                Utilidades.MensajesAdvertencia("Error al generar respaldo:" + e.Message);
                return false;
            }

        }

    }
}
