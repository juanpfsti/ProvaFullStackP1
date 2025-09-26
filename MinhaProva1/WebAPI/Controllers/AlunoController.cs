using Microsoft.AspNetCore.Mvc;
using Servico;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoServico _servico;

        public AlunoController(IAlunoServico servico)
        {
            _servico = servico;
        }

        [HttpPost]
        public IActionResult Post(Dominio.Aluno aluno)
        {
            _servico.Adicionar(aluno);
            return Ok("Aluno cadastrado com sucesso");
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_servico.Listar());
        }
    }
}
