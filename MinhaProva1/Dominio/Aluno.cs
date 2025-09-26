
namespace Dominio
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public float Nota { get; set; }

        public bool EhMaiorIdade() => Idade >= 18;
        public bool EstaAprovado() => Nota >= 7;
    }
}
