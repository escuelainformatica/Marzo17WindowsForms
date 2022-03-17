using Marzo17.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marzo17.ui
{
    class LibroUI
    {
        public Libro Factory(NumericUpDown textoId,TextBox textoTitulo,ComboBox categoria)
        {
            Libro libro = new Libro();
            libro.Id = (int)textoId.Value; // conversion
            libro.Titulo = textoTitulo.Text;
            libro.Cat = (Categoria) categoria.SelectedItem; // cast.
            return libro;
        }

        /// <summary>
        /// Esta funcion devuelve un mensaje de error o vacio si no hay error.
        /// </summary>
        /// <param name="libro"></param>
        /// <returns></returns>
        public List<string> Validar(Libro libro)
        {
            var mensajeError = new List<string>();
            if(libro.Id<=0) // < = 
            {
                mensajeError.Add("El id no puede ser negativo o cero");
            }
            if(libro.Titulo=="")
            {
                mensajeError.Add("El titulo no puede ser vacio");
            }
            if(libro.Cat.Id==0)
            {
                mensajeError.Add("Tiene que seleccionar una categoria");
            }

            return mensajeError;
        }

    }
}
