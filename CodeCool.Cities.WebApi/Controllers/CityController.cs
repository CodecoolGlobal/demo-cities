using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeCool.Cities.WebApi.Controllers
{
    [Route("/")]
    [ApiController]
    public class CityController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetAll()
        {
            return Ok("Hello");
        } 
    }
}
