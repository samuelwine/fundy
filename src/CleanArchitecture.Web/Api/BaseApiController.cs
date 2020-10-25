using Microsoft.AspNetCore.Mvc;

namespace Fundy.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
