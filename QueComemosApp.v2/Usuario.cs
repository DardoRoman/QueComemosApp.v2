using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueComemosApp.v2
{
    class Usuario
    {

        public Usuario(string n, int d)
        {
            MisIngredientes = new List<Ingrediente>();
            Nombre = n;
            NumeroUsuario = d;
        }

        public string Nombre { get; set; }

        public int NumeroUsuario { get; set; }

        public List<Ingrediente> MisIngredientes { get; set; }

        public void AgregarIngrediente(string n, int c, TipoIngrediente t)
        {

            MisIngredientes.Add(new Ingrediente(n, c, t));
        }

    }
}
