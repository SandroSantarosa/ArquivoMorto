using System.ComponentModel.DataAnnotations;

namespace ArquivoMorto.DTO
{
    public class ArqMortoDTO
    {
        [Required]
        public int? CodFilial { get; set; }
        public int? NrPasta { get; set; }

        [StringLength(9)]
        public string RA { get; set; } = "";

        [Required]
        [StringLength(150)]
        public string Nome { get; set; } = "";

        [StringLength(400)]
        public string Observacao { get; set; } = "";
        public DateOnly? DataCriacao { get; set; }
        [StringLength(11)]
        public string UsuarioCriacao { get; set; } = "";
        public DateOnly? DataAlteracao { get; set; }
        [StringLength(11)]
        public string UsuarioAlteracao { get; set; } = "";
    }
}
