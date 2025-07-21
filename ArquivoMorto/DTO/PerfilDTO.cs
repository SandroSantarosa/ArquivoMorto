using System.ComponentModel.DataAnnotations;

namespace ArquivoMorto.DTO
{
    public class PerfilDTO
    {
        [Required(ErrorMessage = "É necessário inluir um nome para o perfil")]
        [StringLength(100)]
        public string Nome { get; set; } = "";
        [StringLength(400)]
        public string MenuAtivo { get; set; } = "";
    }
}
