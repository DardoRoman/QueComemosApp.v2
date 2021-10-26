using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QueComemosApp.v2
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NumeroUsuario { get; set; }

        public string Nombre { get; set; }


        public virtual ICollection<Ingrediente> MisIngredientes { get; set; }

        

    }
}
