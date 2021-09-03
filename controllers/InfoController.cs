using Microsoft.AspNetCore.Mvc;

namespace kubetest.controllers
{
  [Route("api/info")]
  public class InfoController : ControllerBase
  {
    [HttpGet]
    public ActionResult GetInfo()
    {
      return Ok(new { hostname = System.Environment.MachineName });
    }

  }
}