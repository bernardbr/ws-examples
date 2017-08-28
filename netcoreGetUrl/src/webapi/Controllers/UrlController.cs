using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    public class UrlController : Controller
    {
        // GET api/values
        [HttpGet("{tipo}/{area}/{subarea}")]
        public dynamic Get(string tipo, string area, string subarea)
        {
            return new
            {
                Link = $"https://www.minhaurl.com.br/?curso={tipo}&area={area}&subarea={subarea}"
            };
        }
    }
}
