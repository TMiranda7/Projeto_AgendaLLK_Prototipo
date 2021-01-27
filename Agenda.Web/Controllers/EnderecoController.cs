using Agenda.Dominio.Contratos;
using Agenda.Dominio.Entity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Agenda.Web.Controllers
{
    [Route("api/[controller]")]
    public class EnderecoController : Controller
    {
        private readonly IEnderecoRepository enderecoRepository ;
        public EnderecoController(IEnderecoRepository _enderecoRepository)
        {
            enderecoRepository = _enderecoRepository;
        }

        [HttpGet]
        public ActionResult Get(Endereco endereco)
        { 
            try
            {
                if (endereco.id > 0)
                {
                    return Ok(enderecoRepository.ObterId(endereco));
                }
                else
                {
                    return Ok(enderecoRepository.ObterTodos());
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Endereco endereco)
        {
            try
            {   
                enderecoRepository.Add(endereco);
                return Created("api/endereco", endereco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
