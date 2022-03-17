using Marzo17.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marzo17.repo
{
    class CategoriaRepo
    {
        public List<Categoria> ListarTodas()
        {
            var resultado = new List<Categoria>();
            resultado.Add(new Categoria(0, "--Seleccione una categoria--"));
            resultado.Add(new Categoria(1, "Comedia"));
            resultado.Add(new Categoria(2, "Novela"));
            resultado.Add(new Categoria(3, "Ciencia Ficción"));

            return resultado;
        }
    }
}
