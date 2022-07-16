using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoPOA.Models
{
    public class Empleado
    {
        public int codigo { get; set; }
        public string? nombre { get; set; }
        public string? apellidos { get; set; }
        public string? direccion { get; set; }
        public string? cedula { get; set; }
        public string? sexo { get; set; }
        public string? telefono { get; set; }
        public string? correo { get; set; }
        public string? departamento { get; set; }
        public int sueldo { get; set; }
    }
}
