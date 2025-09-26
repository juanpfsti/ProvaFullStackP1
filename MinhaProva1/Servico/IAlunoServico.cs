using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico
{
    public interface IAlunoServico
    {
        void Adicionar(Dominio.Aluno aluno);
        List<Dominio.Aluno> Listar();
    }
}
