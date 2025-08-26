using Microsoft.EntityFrameworkCore;
using webmvccrud.Models;

using crudMySQL.Models;
using Microsoft.EntityFrameworkCore;

namespace crudMySQL.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
    }
}
