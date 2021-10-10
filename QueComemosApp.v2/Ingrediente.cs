using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueComemosApp.v2
{
    class Ingrediente
    {

        public Ingrediente(string n, int c, TipoIngrediente t)
        {
            Nombre = n;
            Cantidad = c;
            Tipo = t;
        }

        public string Nombre { get; set; }

        public int Cantidad { get; set; }

        public TipoIngrediente Tipo { get; set; }


    }
}
