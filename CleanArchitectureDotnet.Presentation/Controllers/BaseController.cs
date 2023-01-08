namespace CleanArchitectureDotnet.Presentation.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BaseController : ControllerBase
    {
        protected IMediator _mediator;

        public BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [NonAction]
        public IActionResult Response(BaseResponse response)
        {
            return new OkObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}

