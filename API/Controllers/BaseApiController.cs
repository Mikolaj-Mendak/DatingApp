using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{


    [ApiController]
    [Route("api/[controller]")] //user will be using -     /api/users - because of the slash forward
    public class BaseApiController : ControllerBase
    {
    }
}
