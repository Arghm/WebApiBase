using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Serilog;
using Microsoft.Extensions.Logging;
using WebApi.Core;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WebApiController : ControllerBase
    {
        private readonly ILogger<WebApiController> _logger;
        private readonly IClientService _clientService;

        public WebApiController(ILogger<WebApiController> logger,
            IClientService clientService)
        {
            _logger = logger;
            _clientService = clientService;
        }

        [HttpGet]
        public string About()
        {
            Log.Information("Call WebApiController/About");
            return $"Сервис {nameof(WebApiController)}";
        }

        /// <summary>
        /// Создать элемент
        /// </summary>
        [HttpPost()]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public async Task<ActionResult<int>> CreateItem([FromBody] ClientInfoJson data)
        {
            var clId = await _clientService.CreateClient(data);
            return Ok(clId);
        }

        /// <summary>
        /// Обновить элемент
        /// </summary>
        [HttpPatch("{id}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public string PatchItem(int id, [FromBody] string data)
        {
            return $"patched: {data}";
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ClientInfo), StatusCodes.Status200OK)]
        public async Task<ActionResult<ClientInfo>> GetClientInfo(int id)
        {
            var clInfo = await _clientService.GetClientInfo(id);
            return Ok(clInfo);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult> DeleteById(int id)
        {
            var delNum = await _clientService.DeleteClient(id);
            return Ok();
        }
    }
}
