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
    public class GreetingController : Controller
    {
        /// <summary>
        /// Greet to input number amount of people
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>Returns the greeting messqge to the input number amount of people</returns>
        /// <example>
        /// GET api/greeting/3 -> Greetings to 3 people!
        /// GET api/greeting/6 -> Greetings to 6 people!
        /// GET api/greeting/0 -> Greetings to 0 people!
        /// </example>
        [HttpGet("{id}")]
        public string Greeting(int id)
        {
            return "Greetings to " + id + " people!";
        }

        /// <summary>
        /// Output message
        /// </summary>
        /// <returns>Returns output message</returns>
        /// <example>
        /// POST api/greeting -> "Hello World!"
        /// </example>
        [HttpPost]
        public string HelloWorld()
        {
            return "Hello World!";
        }
    }
}

