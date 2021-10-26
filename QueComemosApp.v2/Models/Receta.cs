using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QueComemosApp.v2
{
    public class Receta
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int TiempoPreparacion { get; set; }


        public virtual ICollection<Ingrediente> Ingredientes { get; set; }


        [EnumDataType(typeof(TipoReceta))]
        public TipoReceta Tipo { get; set; }

    }
}
