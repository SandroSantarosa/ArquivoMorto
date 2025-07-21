using System.ComponentModel.DataAnnotations;

namespace ArquivoMorto.DTO
{
    public class UsuarioDTO
    {
        [Required(ErrorMessage = "É necessário possuir um login")]
        [StringLength(11)]
        public string Login { get; set; } = "";
        
        [Required(ErrorMessage = "É necessário possuir um nome")]
        [StringLength(150)]
        public string Nome { get; set; } = "";

        [Required(ErrorMessage = "É necessário incluir uma senha")]
        [StringLength(255)]
        [DataType(DataType.Password)]
        public string Senha { get; set; } = "";
        public bool Ativo { get; set; } = false;

        [Required(ErrorMessage = "É necessário selecionar uma filial de acesso")]
        public int FilialId { get; set; }

        [Required(ErrorMessage = "É preciso selecionar um perfil")]
        public int PerfilId { get; set; }
    }
}
