using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crudMySQL.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [Display(Name = "código")]
        [Column("UsuarioId")]
        public int UsuarioId { get; set; }

        [Display(Name = "Nome")]
        [Required, StringLength(100)]
        [Column("Nome")]
        public string UsuarioNome { get; set; }

        [Required]
        public int UsuarioMatricula { get; set; }

        [Required, StringLength(256)]
        public string UsuarioSenha { get; set; }

        public DateTime? UsuarioDtUltimoLogin { get; set; }
        public DateTime? UsuarioDtUltimaTroca { get; set; }

        [ForeignKey("Perfil")]
        public int PerfilId { get; set; } // FK
        public Perfil Perfil { get; set; } // Navigation property

        public bool UsuarioAtivo { get; set; }

    }
}
