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
        //Constructor
        public Empleado(string nombre, string apellido, string dni,  int telefono, string email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = dni;
            this.telefono = telefono;
            this.email = email;
        }
        //Getters y Setters AGREGARLOS EN CASO DE SER UN METODO ESPECIFICO QUE SE USE EN EL DIAGRAMA DE SECUENCIA
 

    }
}