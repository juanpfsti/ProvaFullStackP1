
namespace Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly EstudanteDbContext _context;

        public AlunoRepositorio(EstudanteDbContext contexto)
        {
            _context = contexto;
        }

        public void Adicionar(Dominio.Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
        }

        public List<Dominio.Aluno> Listar()
        {
            return _context.Alunos.ToList();
        }
    }
}
