

using Repositorio;

namespace Servico
{
  public class AlunoServico : IAlunoServico
    {
        private readonly IAlunoRepositorio _repositorio;

        public AlunoServico(IAlunoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Adicionar(Dominio.Aluno aluno)
        {
            if (string.IsNullOrWhiteSpace(aluno.Nome))
            {
                throw new Exception("O nome do aluno é obrigatório.");
            }

            _repositorio.Adicionar(aluno);

        }

        public List<Dominio.Aluno> Listar() => _repositorio.Listar();
    }
}
