using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ContaCorrente.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacaoController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetTransacoesCliente(Guid clienteId)
        {
            return Ok();
        }
    }
}
