using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marzo17.modelo
{
    class Libro
    {
        public int Id { set; get; }
        public string Titulo { set; get; }
        public Categoria Cat { set; get; }

        public Libro(int id, string titulo, Categoria cat)
        {
            Id = id;
            Titulo = titulo;
            Cat = cat;
        }

        public Libro()
        {
        }
    }
}
