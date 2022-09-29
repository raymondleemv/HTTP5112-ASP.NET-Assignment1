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
        /// GET api/hostingcost/0 -> ["1 fortnights at $5.50/FN = $5.50 CAD","HST 13% = $0.72 CAD","Total = $6.22 CAD"]
        /// GET api/hostingcost/14 -> ["2 fortnights at $5.50/FN = $11.00 CAD","HST 13% = $1.43 CAD","Total = $12.43 CAD"]
        /// GET api/hostingcost/28 -> ["3 fortnights at $5.50/FN = $16.50 CAD","HST 13% = $2.14 CAD","Total = $18.64 CAD"]
        /// </example>
        [HttpGet("{id}")]
        public IEnumerable<string> HostingCost(int id)
        {
            int numFortNights = id / 14 + 1;
            double fhostingCost = numFortNights * 5.5;
            double fTax = Math.Round(fhostingCost * 0.13, 2);
            double fTotal = fhostingCost + fTax;            
            string strHostingCost = numFortNights + " fortnights at $5.50/FN = $" + fhostingCost.ToString("0.00") + " CAD";
            string strTax = "HST 13% = $" + fTax.ToString("0.00") + " CAD";
            string strTotal = "Total = $" + fTotal.ToString("0.00") + " CAD";
            return new string[] { strHostingCost, strTax, strTotal };
        }
    }
}

