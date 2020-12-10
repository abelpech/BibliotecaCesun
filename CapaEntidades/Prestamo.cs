using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCesun.CapaEntidades;

namespace BibliotecaCesun.CapaEntidades
{
    class Prestamo
    {
        public int id_prestamo { get; set; }
        public Libro libro { get; set; }
        public Bibliotecario bibliotecario { get; set; }
        public Persona personaPrestatario { get; set; }
        public DateTime fechaPrestamo { get; set; }
        public DateTime fechaVencimiento { get; set; }

        public Prestamo()
        {

        }

        public Prestamo(int id_prestamo, Libro libro, Bibliotecario bibliotecario, Persona personaPrestatario, DateTime fechaPrestamo, DateTime fechaVencimiento)
        {
            this.id_prestamo = id_prestamo;
            this.libro = libro;
            this.bibliotecario = bibliotecario;
            this.personaPrestatario = personaPrestatario;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaVencimiento = fechaVencimiento;
        }

        public void VencerPrestamo()
        {
            
        }
    }
}
