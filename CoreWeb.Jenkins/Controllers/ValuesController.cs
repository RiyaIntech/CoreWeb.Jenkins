using Microsoft.AspNetCore.Mvc;

namespace CoreWeb.Jenkins.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ValuesController : ControllerBase
  {
    private static readonly string[] Users = new[]
    {
        "Riya", "Rashmin", "Dhaval", "Harsh","Jainam"
    };


    [HttpGet(Name = "GetUsers")]
    public IEnumerable<object> Get()
    {
      return Users.ToArray();
    }
  }
}
