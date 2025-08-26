using System.ComponentModel.DataAnnotations;
using webmvccrud.Models;

namespace crudMySQL.Models
{
    public class Perfil
    {
        [Key] public int PerfilId { get; set; }

        [Required, StringLength(50)]
        public string PerfilDesc { get; set; }

        public int PerfilNivel { get; set; }

        public ICollection<Usuario> Usuarios { get; set; } // FK
    }
}
