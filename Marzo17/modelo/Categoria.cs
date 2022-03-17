using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marzo17.modelo
{
    class Categoria
    {
        public int Id { set; get; }
        public string Nombre { set; get; }

        public Categoria(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public Categoria()
        {
        }
    }
}
