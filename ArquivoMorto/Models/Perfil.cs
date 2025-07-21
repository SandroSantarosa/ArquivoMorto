using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArquivoMorto.Models
{
    public class Perfil
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PerfilId { get; set; }
        [StringLength(100)]
        public string Nome { get; set; } = "";
        [StringLength(400)]
        public string MenuAtivo { get; set; } = "";


        public ICollection<Usuario>? Usuarios { get; set; }
    }
}
