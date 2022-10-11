using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace BLL
{
    public sealed class Session
    {
        private Session() { }

        public user usuario { get; set; }

        private static Session _session;

        public static Session GetInstance()
        {
            if(_session == null)
            {
                _session = new Session();
            }
            return _session;
        }
    }
}
