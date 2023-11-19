using Microsoft.AspNetCore.Mvc;
using voicevista_cassandra.DataAccess.Database.Mappings;
using voicevista_cassandra.Enpoints.Models;
using voicevista_cassandra.Services.Interfaces;

namespace voicevista_cassandra.Enpoints
{
    [ApiController]
    [Route("[controller]")]
    public class ServerController : ControllerBase
    {
        private readonly IServerService _serverService;

        public ServerController(IServerService serverService)
        {
            _serverService = serverService;
        }
        [HttpPost]
        [Route("/new")]
        public async Task<IActionResult> Index([FromBody] CreateRequestServer createRequestServer)
        {
            await _serverService.ServerCreate(createRequestServer);
            return Ok("Server create");
        }
    }
}