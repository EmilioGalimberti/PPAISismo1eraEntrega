using System.Windows.Forms;

namespace PPAISismos.Entidades
{
    public class Empleado
    {
        //Atributos
        private string nombre;
        private string apellido;
        private string mail;
        private int telefono;
        //Empleado ->1 Rol
        private Rol rol;

        //Constructor
        public Empleado(string nombre, string apellido, string mail,  int telefono,  Rol rol)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.mail = mail;
            this.rol = rol;
        }

        public bool buscarResponsable()
        {
            return rol.esResponsable();
        }

        public string getMail()
        {
            return mail;
        }
    }
}