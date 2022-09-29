using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HTTP5112Asignment1
{
    [Route("api/[controller]")]
    public class SquareController : Controller
    {
        /// <summary>
        /// Square the input number
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>Returns the square of the input number</returns>
        /// <example>
        /// GET api/square/2 -> 4
        /// GET api/square/-2 -> 4
        /// GET api/square/10 -> 100
        /// </example>
        [HttpGet("{id}")]
        public int Square(int id)
        {
            return id * id;
        }
    }
}

