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
        //Empleado ->1 Rol
        private Rol rol { get; set; }

        //Constructor
        public Empleado(string nombre, string apellido, string mail,  int telefono,  Rol rol)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.mail = mail;
            this.rol = rol;
        }
        //Getters y Setters AGREGARLOS EN CASO DE SER UN METODO ESPECIFICO QUE SE USE EN EL DIAGRAMA DE SECUENCIA

        //SOLO PARA PROBAR que la sesion tiene este empleado
        //public string getNombre()
        //{
        //    return nombre;
        //}

    }
}