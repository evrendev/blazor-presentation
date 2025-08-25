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

        [HttpPost("change-slide/{slideNumber}")]
        public async Task<IActionResult> ChangeSlide(int slideNumber, [FromQuery] string presentationId = "default")
        {
            try
            {
                await _hubContext.Clients.Group(presentationId).SendAsync("ReceiveSlideNumber", slideNumber);
                return Ok(new { message = $"Slide changed to {slideNumber}", slideNumber, presentationId });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("next-slide")]
        public async Task<IActionResult> NextSlide([FromQuery] string presentationId = "default", [FromQuery] int currentSlide = 1, [FromQuery] int totalSlides = 8)
        {
            try
            {
                var nextSlide = currentSlide < totalSlides ? currentSlide + 1 : currentSlide;
                await _hubContext.Clients.Group(presentationId).SendAsync("ReceiveSlideNumber", nextSlide);
                return Ok(new { message = $"Moved to slide {nextSlide}", slideNumber = nextSlide, presentationId });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("previous-slide")]
        public async Task<IActionResult> PreviousSlide([FromQuery] string presentationId = "default", [FromQuery] int currentSlide = 1)
        {
            try
            {
                var previousSlide = currentSlide > 1 ? currentSlide - 1 : 1;
                await _hubContext.Clients.Group(presentationId).SendAsync("ReceiveSlideNumber", previousSlide);
                return Ok(new { message = $"Moved to slide {previousSlide}", slideNumber = previousSlide, presentationId });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpGet("current-slide")]
        public IActionResult GetCurrentSlide([FromQuery] string presentationId = "default")
        {
            // Bu gerçek bir uygulamada veritabanından veya cache'den gelir
            return Ok(new { slideNumber = 1, totalSlides = 8, presentationId });
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "Hello from SlidesController", totalSlides = 8 });
        }
    }
}
