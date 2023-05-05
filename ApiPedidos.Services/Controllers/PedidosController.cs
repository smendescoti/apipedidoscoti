using ApiPedidos.Application.Commands;
using ApiPedidos.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPedidos.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidoAppService? _pedidoAppService;

        public PedidosController(IPedidoAppService? pedidoAppService)
        {
            _pedidoAppService = pedidoAppService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(PedidoCreateCommand command)
        {
            await _pedidoAppService.Add(command);
            
            return StatusCode(201, new 
            { 
                status = "success",
                message = "Pedido realizado com sucesso."
            });
        }
    }
}
