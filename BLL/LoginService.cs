using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public sealed class LoginService
    {
        public LoginService()
        {
            
        }

        public bool Login (string user, string password)
        {
            using (CuotasEntities db = new CuotasEntities())
            {
                password = Utilidades.Encrypt(password);
                var usuario = db.users.FirstOrDefault(c => c.usuario == user && c.password == password);
                if (usuario == null)
                {
                    return false;
                }
                else
                {
                    Session s1 = Session.GetInstance();
                    s1.usuario = usuario;
                    return true;
                }
            }
        }
    }
}
