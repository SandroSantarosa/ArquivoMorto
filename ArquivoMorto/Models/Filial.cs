using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArquivoMorto.Models
{
    public class Filial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FilialId { get; set; }
        public int CodFilial { get; set; }

        [StringLength(150)]
        public string Nome { get; set; } = "";

        public ICollection<Usuario>? Usuarios { get; set; }

        public ICollection<ArqMorto>? ArqMortos { get; set; }
    }
}
