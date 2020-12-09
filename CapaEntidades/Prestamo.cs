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
        public String id_prestamo { get; set; }
        public Libro libro { get; set; }
        public Persona persona { get; set; }
        public DateTime fechaPrestamo { get; set; }
        public DateTime fechaVencimiento { get; set; }

        public Prestamo()
        {

        }

        public Prestamo(string id_prestamo, Libro libro, Persona persona, DateTime fechaPrestamo, DateTime fechaVencimiento)
        {
            this.id_prestamo = id_prestamo;
            this.libro = libro;
            this.persona = persona;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaVencimiento = fechaVencimiento;
        }

        public void VencerPrestamo()
        {
            
        }
    }
}
