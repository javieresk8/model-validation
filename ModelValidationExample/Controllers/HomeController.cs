using Microsoft.AspNetCore.Mvc;
using ModelValidationExample.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ModelValidationExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("Register")]
        public IActionResult Index(Person person)
        {
            if (!ModelState.IsValid)
            {
                var errorList = string.Join("\n", ModelState.Values
                    .SelectMany(value => value.Errors)
                    .Select(err => err.ErrorMessage));

                return BadRequest(errorList);
            }
            return Content($"{person}");
        }
    }
}

