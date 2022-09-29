using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
//using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HTTP5112Asignment1.Controllers
{
    [Route("api/[controller]")]
    public class NumberMachineController : Controller
    {
        /// <summary>
        /// Add 1 times 5 divided 5 minus 1 to the input number
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>Returns the input number added 1 multiplied by 5 divided by 5 minus 1</returns>
        /// <example>
        /// GET api/numbermachine/1 -> 1
        /// GET api/numbermachine/2 -> 2
        /// GET api/numbermachine/3 -> 3
        /// </example>
        [HttpGet("{id}")]
        public int NumberMachine(int id)
        {
            return id + 1 * 5 / 5 - 1;
        }
    }
}

