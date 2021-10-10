using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueComemosApp.v2
{
    class Receta
    {
        public Receta(string n, int tp, TipoReceta t)
        {
            Ingredientes = new List<Ingrediente>();
            Nombre = n;
            TiempoPreparacion = tp;
            Tipo = t;
        }
        public string Nombre { get; set; }

        public int TiempoPreparacion { get; set; }

        public List<Ingrediente> Ingredientes { get; set; }

        public TipoReceta Tipo { get; set; }

        public void AgregarIngrediente(string n, int c, TipoIngrediente t)
        {

            Ingredientes.Add(new Ingrediente(n, c, t));
        }
    }
}
