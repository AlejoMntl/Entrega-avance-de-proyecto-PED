using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPED_1
{
    public class Libro
    {
        public int ID { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaPubli { get; set; }
        public bool Disponibilidad { get; set; }
        public Libro Siguiente { get; set; }

        public Libro(int id, string autor, string titulo,
            DateTime fechapubli, bool disponible)
        {
            ID = id;
            Autor = autor;
            Titulo = titulo;
            FechaPubli = fechapubli;
            Disponibilidad = disponible;
            Siguiente = null;
        }
    }
}
