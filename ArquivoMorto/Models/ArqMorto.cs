using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArquivoMorto.Models
{
    public class ArqMorto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? ArqMortoId { get; set; }
        public int? CodFilial { get; set; }
        public int? NrPasta { get; set; }
        
        [StringLength(9)]
        public string RA { get; set; } = "";

        [StringLength(150)]
        public string Nome { get; set; } = "";

        [StringLength(400)]
        public string Observacao { get; set; } = "";


        public int FilialId { get; set; }
        public Filial? Filial { get; set; }


        public DateOnly? DataCriacao { get; set; }
        [StringLength(11)]
        public string UsuarioCriacao { get; set; } = "";
        public DateOnly? DataAlteracao { get; set; }
        [StringLength(11)]
        public string UsuarioAlteracao { get; set; } = "";
    }
}
