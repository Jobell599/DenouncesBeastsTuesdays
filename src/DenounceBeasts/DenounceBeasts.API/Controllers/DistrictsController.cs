using Microsoft.AspNetCore.Mvc;

namespace DenounceBeasts.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DistrictsController: ControllerBase
    {
        [HttpGet]
        public IActionResult GetDistricts()
        {
            var districts = new[]
            {
                new { Id = 1, Name = "Downtown" },
                new { Id = 2, Name = "Uptown" },
                new { Id = 3, Name = "Suburbia" }
            };
            return Ok(districts);
        }

        [HttpGet]
        [Route("{id:int}")]

        public IActionResult GetDistrictById(int id)
        {
            var districts = new[]
{
                new { Id = 1, Name = "Downtown" },
                new { Id = 2, Name = "Uptown" },
                new { Id = 3, Name = "Suburbia" }
            };


            var district = districts.Where(p=> p.Id == id).FirstOrDefault();
            return Ok(district);
        }
    }
}
