using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace patrick.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character{Name = "jorj"}
        };

        [HttpGet]
        public ActionResult<List<Character>> get()
        {
            return Ok(characters);
        }
    }
}