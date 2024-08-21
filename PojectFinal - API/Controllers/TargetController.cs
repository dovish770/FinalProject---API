using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PojectFinal___API.Modles;
using PojectFinal___API.Services;
using PojectFinal___API.Enums;

namespace PojectFinal___API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TargetController : ControllerBase
    {
         

        //--רשימת מטרות--
        [HttpGet]
        public IActionResult GetTargets()
        {
            return StatusCode(
                StatusCodes.Status200OK,
                new
                {
                    success = true,
                    targets = TargetList.targets.ToArray()
                });
        }

        //יצירת מטרה
        [HttpPost]
        public IActionResult CreateTarget(Target target)
        {
            target.Status = StatusTarget.statusTarget.Alive;
            TargetList.targets.Add(target);           

            return StatusCode(
                StatusCodes.Status201Created,
                new { success = true, target = target }
                );
        }







    }
}
