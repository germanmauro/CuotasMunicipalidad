using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMyG
{
    public static class Tipos
    {
        public static List<string> Perfiles()
        {
            List<string> lista = new List<string>();
            lista.Add("Admin");
            lista.Add("Normal");
            return lista;
        }

        public static List<string> CondicionesIVA()
        {
            List<string> lista = new List<string>();
            lista.Add("Consumidor Final");
            lista.Add("Monotributista");
            lista.Add("Responsable Inscripto");
            lista.Add("Exento");
            return lista;
        }

        public static List<string> FormaPago(bool todos = false)
        {
            List<string> lista = new List<string>();
            if (todos)
            {
                lista.Add("Todas");
            }
            lista.Add("Cheque");
            lista.Add("Efectivo");
            lista.Add("Transferencia");
            return lista;
        }

        public static List<string> TipoCuenta(bool todos = false)
        {
            List<string> lista = new List<string>();
            if (todos)
            {
                lista.Add("Todas");
            }
            lista.Add("Caja de ahorro");
            lista.Add("Cuenta Corriente");
            return lista;
        }
    }
}
