using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCesun.CapaEntidades
{
    public class Libro
    {
        public String codigo { get; set; }
        public String titulo { get; set; }
        public String coleccion { get; set; }
        public String autor { get; set; }
        public String cantidadPaginas { get; set; }

        public bool validarDisponibilidad()
        {
            return true;
        }
    }
}
