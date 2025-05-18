using System.Windows.Forms;

namespace PPAISismos.Entidades
{
    public class Empleado
    {
        //Atributos
        private string nombre { get; set; }
        private string apellido { get; set; }
        private string mail { get; set; }
        private int telefono { get; set; }
        private string email { get; set; }

        //un cliente tiene un rol
        private Rol rol { get; set; }

        //Constructor
        public Empleado(string nombre, string apellido, string dni,  int telefono, string email, Rol rol)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = dni;
            this.telefono = telefono;
            this.email = email;
            this.rol = rol;
        }
        //Getters y Setters AGREGARLOS EN CASO DE SER UN METODO ESPECIFICO QUE SE USE EN EL DIAGRAMA DE SECUENCIA
 

    }
}