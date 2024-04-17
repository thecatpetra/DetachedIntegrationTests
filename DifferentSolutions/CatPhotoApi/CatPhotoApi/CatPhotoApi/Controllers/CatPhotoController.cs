using CatPhotoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatPhotoApi.Controllers;

[ApiController]
[Route("api")]
public class CatPhotoController : ControllerBase
{
    [HttpPost]
    [Route("post")]
    public IActionResult Post([FromBody] CatPhoto p)
    {
        return Ok();
    }

    [HttpGet]
    [Route("get")]
    public ActionResult<List<CatPhoto>> Get()
    {
        var petraPhoto = new CatPhoto("https://photos.com/cat_petra", "Petra");
        return new List<CatPhoto>{petraPhoto};
    }
}
