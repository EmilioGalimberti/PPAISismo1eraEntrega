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
        //EstadoOI FALTA BUSCAR EL RESTO DE LOS ESTADOS DE LA OI
        public static EstadoOI EstadoFinalizada { get; set; } = new EstadoOI("Realizada");
        public static EstadoOI EstadoIniciada { get; set; } = new EstadoOI("Iniciada");
        public static EstadoOI EstadoCancelada { get; set; } = new EstadoOI("Cancelada");
    }
}
