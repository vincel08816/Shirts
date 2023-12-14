using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models; // Add this using statement to reference the namespace where Shirt class is defined

namespace WebApplication1.Controllers
{
    [ApiController]
    public class ShirtsController: ControllerBase
    {
        [HttpGet]
        [Route("api/shirts")]
        public string GetShirts()
        {
            return "Reading all the shirts";
        }
        
        [HttpGet]
        [Route("api/shirts/{id}")]
        public string GetShirtsById(int id)
        {
            return $"Reading shirt: {id}";
        }

        [HttpPost]
        [Route("api/shirts")]
        public string CreateShirt([FromBody]Shirt shirt)
        {
            Console.WriteLine(shirt);
            return "Creating a shirt";
        }

        [HttpPut]
        [Route("api/shirts/{id}")]
        public string UpdateShirt(int id)
        {
            return $"Updating shirt with ${id}";
        }
    }
}
