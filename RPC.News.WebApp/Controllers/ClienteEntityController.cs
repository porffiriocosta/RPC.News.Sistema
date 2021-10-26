using Microsoft.AspNetCore.Mvc;
using RPC.News.Sistema.Application.Contracts;
using System.Threading.Tasks;

namespace RPC.News.WebApp.Controllers
{
    public class ClienteEntityController : Controller
    {
        private readonly IClienteEntityService _clienteService;

        public ClienteEntityController(IClienteEntityService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        [Route("getAllClientes")]
        public async Task<IActionResult> GetClienteEntity()
        {
            return Ok(await _clienteService.GetClientes());
        }
    }
}
