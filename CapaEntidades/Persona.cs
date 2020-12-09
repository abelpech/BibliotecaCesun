using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCesun.CapaEntidades;

namespace BibliotecaCesun.CapaEntidades
{
    public class Persona
    {
        public String matricula { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String telefono { get; set; }
        public String email { get; set; }
        public String direccion { get; set; }

        public Persona()
        {

        }
        public Persona(string matricula, string nombre, string apellido, string telefono, string email, string direccion)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.email = email;
            this.direccion = direccion;
        }

        public virtual Libro pedirLibro(Libro libro)
        {
            bool disponible = false;
            disponible = libro.validarDisponibilidad();
            return libro;
        }

        public virtual bool retornarLibro(Libro libro)
        {
            bool retornado = false;
            retornado = libro.validarDisponibilidad();
            return retornado;
        }

        public virtual void consultarLibros()
        {
            
        }

        public virtual void consultarCatalogoDeLibros()
        {

        }

        public virtual void pagarMulta()
        {

        }
    }
}
