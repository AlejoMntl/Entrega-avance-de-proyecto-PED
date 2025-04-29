using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPED_1
{
    internal class LibroDTO
    {
        public int ID { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaPubli { get; set; }
        public bool Disponibilidad { get; set; }
    }
}
