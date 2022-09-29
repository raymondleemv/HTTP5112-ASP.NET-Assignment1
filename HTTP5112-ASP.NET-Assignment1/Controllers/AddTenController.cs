using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HTTP5112Asignment1.Controllers
{
    [Route("api/[controller]")]
    public class AddTenController : Controller
    {
        /// <summary>
        /// Add 10 to the input number
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>Returns the input number plus 10</returns>
        /// <example>
        /// GET api/addten/21 -> 31
        /// GET api/addten/0 -> 10
        /// GET api/addten/-9 -> 1
        /// </example>
        [Route("api/addten/{id}")]
        [HttpGet("{id}")]
        public int AddTen(int id)
        {
            return id + 10;
        }
    }
}

