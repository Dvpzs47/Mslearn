using Microsoft.AspNetCore.Mvc;

namespace Mslearn.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
