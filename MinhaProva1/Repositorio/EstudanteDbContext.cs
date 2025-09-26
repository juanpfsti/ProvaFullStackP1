using Microsoft.EntityFrameworkCore;

namespace Repositorio
{
    public class EstudanteDbContext : DbContext
    {
        public EstudanteDbContext(DbContextOptions<EstudanteDbContext> options)
            : base(options) 
        {
        }

        public DbSet<Dominio.Aluno> Alunos { get; set; }
    }
}
