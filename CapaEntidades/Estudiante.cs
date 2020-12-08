using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCesun.CapaEntidades;

namespace BibliotecaCesun.CapaEntidades
{
    public class Estudiante : Persona
    {
        public String matricula { get; set; }
        public Estudiante() : base()
        {

        }
        public Estudiante(string matricula, string nombre, string apellido, string telefono, string email, string direccion) : base(nombre, apellido, telefono, email, direccion)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.email = email;
            this.direccion = direccion;
        }

        public Libro pedirLibro(Libro libro)
        {
            bool disponible = false;
            disponible = libro.validarDisponibilidad();
            return libro;
        }

        public override bool retornarLibro(Libro libro)
        {
            bool retornado = false;
            retornado = libro.validarDisponibilidad();
            return retornado;
        }

        public override void consultarLibros()
        {
            
        }

        public override void consultarCatalogoDeLibros()
        {

        }

        public override void pagarMulta()
        {

        }

        public void pagarColegiatura()
        {

        }
    }
}
