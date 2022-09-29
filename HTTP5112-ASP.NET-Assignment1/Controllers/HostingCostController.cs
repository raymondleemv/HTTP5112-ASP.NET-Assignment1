using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HTTP5112Asignment1.Controllers
{
    [Route("api/[controller]")]
    public class HostingCostController : Controller
    {
        /// <summary>
        /// Outputs the hosting cost messages depending on the input number of fort nights stayed
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>Returns the hosting cost messages depending on the input number of fort nights stayed</returns>
        /// <example>
        /// GET api/hostingcost/014152128 -> 
        /// </example>
        [HttpGet("{id}")]
        public IEnumerable<string> Get(int id)
        {
            int numFortNights = id / 14 + 1;
            float fhostingCost = numFortNights * 5.5f;
            float fTax = fhostingCost * 0.13f;
            float fTotal = fhostingCost + fTax;            
            string strHostingCost = numFortNights + " fortnights at $5.50/FN = $" + fhostingCost.ToString("0.00") + " CAD";
            string strTax = "HST 13% = $" + fTax.ToString("0.00") + " CAD";
            string strTotal = "Total = $" + fTotal.ToString("0.00") + " CAD";
            return new string[] { strHostingCost, strTax, strTotal };
        }
    }
}

