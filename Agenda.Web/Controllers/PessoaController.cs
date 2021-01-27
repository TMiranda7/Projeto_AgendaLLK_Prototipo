using Agenda.Dominio.Contratos;
using Agenda.Dominio.Entity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Agenda.Web.Controllers
{
    [Route("api/[controller]")]
    public class PessoaController : Controller
    {
        private readonly IPessoaRepository pessoaRepository;
        public PessoaController(IPessoaRepository _pessoaRepository)
        {
            pessoaRepository = _pessoaRepository;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(pessoaRepository.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Pessoa pessoa)
        {
            try
            {
                if( pessoa.id > 0)
                {
                    pessoaRepository.Update(pessoa);

                }else
                {
                    pessoaRepository.Add(pessoa);
                }
                
                return Created("api/pessoa", pessoa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("Delete")]
        public IActionResult Delete ([FromBody] Pessoa pessoa)
        {
            try
            {
                pessoaRepository.Remove(pessoa);
                return Json(pessoaRepository.ObterTodos());
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }
}
