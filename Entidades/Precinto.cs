using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Precinto
    {

        #region Propiedades

        public int Codigo { get; set; }

        public string Fecha { get; set; }

        public string Unidad { get; set; }

        public string Chofer { get; set; }

        public string Cisterna1 { get; set; }

        public string Cisterna2 { get; set; }

        public string Cisterna3 { get; set; }

        public string Cisterna4 { get; set; }

        public string Cisterna5 { get; set; }

        public string Cisterna6 { get; set; }

        public string Motivo { get; set; }

        public string Comentarios { get; set; }

        #endregion

        public Precinto(string fecha, string unidad, string chofer, string cisterna1, string cisterna2,
            string cisterna3, string cisterna4, string cisterna5, string cisterna6, string motivo, string comentarios)
        {
            this.Fecha = fecha;
            this.Unidad = unidad;
            this.Chofer = chofer;
            this.Cisterna1 = cisterna1;
            this.Cisterna2 = cisterna2;
            this.Cisterna3 = cisterna3;
            this.Cisterna4 = cisterna4;
            this.Cisterna5 = cisterna5;
            this.Cisterna6 = cisterna6;
            this.Motivo = motivo;
            this.Comentarios = comentarios;
        }

        public Precinto(int codigo)
        {
            this.Codigo = codigo;
        }
    }
}
