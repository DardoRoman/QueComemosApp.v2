using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueComemosApp.v2
{


    class Program
    {
        static void Main(string[] args)
        {

            Usuario dardo = new Usuario("Dardo", 31695020);

            Receta Receta1 = new Receta("Ensalada Caesar", 30, TipoReceta.ENTRADA);

            Receta1.AgregarIngrediente("Lechuga romana", 2, TipoIngrediente.VERDURA);
            Receta1.AgregarIngrediente("Aceite de oliva", 150, TipoIngrediente.ADEREZO);
            Receta1.AgregarIngrediente("Huevo", 1, TipoIngrediente.PROTEINA);
            Receta1.AgregarIngrediente("Tostadas", 8, TipoIngrediente.PANIFICADOS);
            Receta1.AgregarIngrediente("Jamon crudo", 2, TipoIngrediente.CARNE);
            Receta1.AgregarIngrediente("Aderezo", 100, TipoIngrediente.ADEREZO);
            Receta1.AgregarIngrediente("Semillas de chia", 20, TipoIngrediente.CONDIMENTO);


            Receta Receta2 = new Receta("Solomillo a la mostaza", 50, TipoReceta.PLATO_PRINCIPAL);

            Receta2.AgregarIngrediente("Solomillo de cerdo", 300, TipoIngrediente.CARNE);
            Receta2.AgregarIngrediente("Mostaza", 4, TipoIngrediente.ADEREZO);
            Receta2.AgregarIngrediente("Miel", 4, TipoIngrediente.ADEREZO);
            Receta2.AgregarIngrediente("Vino Blanco", 150, TipoIngrediente.ADEREZO);
            Receta2.AgregarIngrediente("Sal", 2, TipoIngrediente.CONDIMENTO);
            Receta2.AgregarIngrediente("Pimienta", 2, TipoIngrediente.CONDIMENTO);
            Receta2.AgregarIngrediente("Ajo", 1, TipoIngrediente.VERDURA);

            dardo.AgregarIngrediente("Lechuga romana", 2, TipoIngrediente.VERDURA);
            dardo.AgregarIngrediente("Aceite de oliva", 150, TipoIngrediente.ADEREZO);
            dardo.AgregarIngrediente("Huevo", 1, TipoIngrediente.PROTEINA);
            dardo.AgregarIngrediente("Tostadas", 8, TipoIngrediente.PANIFICADOS);

            dardo.AgregarIngrediente("Solomillo de cerdo", 300, TipoIngrediente.CARNE);
            dardo.AgregarIngrediente("Mostaza", 4, TipoIngrediente.ADEREZO);
            dardo.AgregarIngrediente("Miel", 4, TipoIngrediente.ADEREZO);
            dardo.AgregarIngrediente("Vino Blanco", 150, TipoIngrediente.ADEREZO);
            dardo.AgregarIngrediente("Sal", 2, TipoIngrediente.CONDIMENTO);
            dardo.AgregarIngrediente("Pimienta", 2, TipoIngrediente.CONDIMENTO);
            dardo.AgregarIngrediente("Ajo", 1, TipoIngrediente.VERDURA);

           

            Console.Read();
        }
    }

}