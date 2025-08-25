using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace SlideApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SlidesController : ControllerBase
    {
        private readonly IHubContext<SlideHub> _hubContext;

        public SlidesController(IHubContext<SlideHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] int slideNumber)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveSlideNumber", slideNumber);
            return Ok(slideNumber);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "Hello from SlidesController" });
        }
    }
}
