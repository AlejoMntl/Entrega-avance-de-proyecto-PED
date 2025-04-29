using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPED_1
{
    //clase que gestiona la lista enlazda de los libros
    internal class ListaEnlazada
    {
        private Libro primero;
        private int ultimoID;

        public ListaEnlazada()
        {
            primero = null;
            ultimoID = 0;
        }

        public int GenerarID()
        {
            return ++ultimoID;
        }

        //metodo que añade un libro a la lista:
        public void AgregarLibro(string autor, string titulo, DateTime fechapubli,
            bool disponible)
        {
            int nuevoID = GenerarID();
            Libro nuevoLibro = new Libro(nuevoID, autor, titulo, fechapubli, disponible);

            if(primero == null)
            {
                primero = nuevoLibro;
            }
            else
            {
                Libro actual = primero;
                while(actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoLibro;
            }
        }

        //metodo para buscar un libro
        public Libro BuscarLibro(int id,string titulo , string autor)
        {
            Libro actual = primero;
            while(actual != null)
            {
                if (actual.ID == id)
                    return actual;
                actual = actual.Siguiente;

                if (actual.Titulo == titulo)
                    return actual;
                actual = actual.Siguiente;

                if (actual.Autor == autor)
                    return actual;
                actual = actual.Siguiente;
            }
            return null;
        }
        // Buscar libro solo por ID
        public Libro BuscarLibro(int id)
        {
            Libro actual = primero;
            while (actual != null)
            {
                if (actual.ID == id)
                    return actual;

                actual = actual.Siguiente;
            }
            return null;
        }

        //Elimina un libro por ID:
        public bool EliminarLibro(int id)
        {
            if (primero == null)
                return false;
            if(primero.ID == id)
            {
                primero = primero.Siguiente;
                return true;
            }

            Libro actual = primero;
            while (actual.Siguiente != null)
            {
                if(actual.Siguiente.ID == id)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }

        // Eliminar un libro por título:
        public bool EliminarLibroPorTitulo(string titulo)
        {
            if (primero == null)
                return false;

            if (primero.Titulo == titulo)
            {
                primero = primero.Siguiente;
                return true;
            }

            Libro actual = primero;
            while (actual.Siguiente != null)
            {
                if (actual.Siguiente.Titulo == titulo)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }

        // Eliminar un libro por autor:
        public bool EliminarLibroPorAutor(string autor)
        {
            if (primero == null)
                return false;

            if (primero.Autor == autor)
            {
                primero = primero.Siguiente;
                return true;
            }

            Libro actual = primero;
            while (actual.Siguiente != null)
            {
                if (actual.Siguiente.Autor == autor)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }

        public List<LibroDTO> ObtenerLibros()
        {
            List<LibroDTO> libros = new List<LibroDTO>();
            Libro actual = primero;

            while(actual != null)
            {
                libros.Add(new LibroDTO
                {
                    ID = actual.ID,
                    Autor = actual.Autor,
                    Titulo = actual.Titulo,
                    FechaPubli = actual.FechaPubli,
                    Disponibilidad = actual.Disponibilidad,
                });

                actual = actual.Siguiente;
            }
            return libros;
        }



    }//no tocar nada a partir de aca.
}
