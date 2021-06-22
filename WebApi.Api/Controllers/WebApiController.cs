using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Serilog;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WebApiController : ControllerBase
    {
        private readonly ILogger<WebApiController> _logger;

        public WebApiController(ILogger<WebApiController> logger)
        {
            _logger = logger;
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
        [ProducesResponseType(StatusCodes.Status201Created)]
        public string CreateItem([FromBody] string data)
        {
            return $"created: {data}";
        }

        /// <summary>
        /// Обновить элемент
        /// </summary>
        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public string PatchItem(int id, [FromBody] string data)
        {
            return $"patched: {data}";
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"value {id}";
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public void DeleteById(int id)
        {
        }
    }
}
