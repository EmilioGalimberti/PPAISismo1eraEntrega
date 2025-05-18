using PPAISismos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAISismos.Data
{
    public class Data
    {
        //Roles (nombre, descripcion)
        public static Rol ResponsableDeReparacion { get; set; } = new Rol("ResponsableEnReparacion", "descripcion");
        //buscar en el dominio mas roles este es solo de prueba:
        public static Rol ResponsableEnNada { get; set; } = new Rol("ResponsableEnNada", "descripcion2");
        //Clientes (nombre, apellido, mail, telefono, rol)
        public static Empleado Empleado1 { get; set; } = new Empleado("Juan", "Lopez", "mail@gmail.com", 123456789, ResponsableDeReparacion);
        public static Empleado Emplado2 { get; set; } = new Empleado("Pedro", "Picapiedra", "mail2@gmail.com", 803456789, ResponsableDeReparacion);
        public static Empleado Empleado3 { get; set; } = new Empleado("Pablo", "ASD", "mail3@gmail.com", 803456789, ResponsableEnNada);

        //Usuario (string nombreUsuario, string contrasena, Empleado empleado)
        public static Usuario Usuario1 { get; set; } = new Usuario("Juanito", "1234", Empleado1);
        public static Usuario Usuario2 { get; set; } = new Usuario("Pedrito", "1234", Emplado2);
        public static Usuario Usuario3 { get; set; } = new Usuario("Pablito", "1234", Empleado3);

        //Sesion actual
        public static DateTime fechaInicio = DateTime.Now;
        public static DateTime fechaFin = DateTime.Now.AddHours(2);
        public static Sesion sesionActual = new Sesion(fechaFin, fechaInicio, Usuario1);

        public static Sesion loadSesion() { return sesionActual; }



        //EstadoOI FALTA BUSCAR EL RESTO DE LOS ESTADOS DE LA OI
        public static EstadoOI EstadoRealizada { get; set; } = new EstadoOI("Realizada");
        public static EstadoOI EstadoCerrada { get; set; } = new EstadoOI("Cerrada");
        //Buscar mas estados en el dominio, estos son solo de prueba:
        public static EstadoOI EstadoNada { get; set; } = new EstadoOI("Nada");


        
    }
}
