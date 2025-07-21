using System.ComponentModel.DataAnnotations;

namespace ArquivoMorto.DTO
{
    public class FilialDTO
    {
        [Required]
        public int CodFilial { get; set; }
        
        [Required(ErrorMessage = "Deve incluir um nome para a filial")]
        [StringLength(150)]
        public string Nome { get; set; } = "";
    }
}
