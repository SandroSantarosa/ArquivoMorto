using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArquivoMorto.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }
        
        [StringLength(11)]
        public string Login { get; set; } = "";

        [StringLength(150)]
        public string Nome { get; set; } = "";

        [StringLength(255)]
        [DataType(DataType.Password)]
        
        public string Senha { get; set; } = "";
        
        public bool Ativo { get; set; } = false;

        
        public int FilialId { get; set; }
        public Filial? Filial {  get; set; }


        public int PerfilId { get; set; }

        public Perfil? Perfil {  get; set; }

    }
}
