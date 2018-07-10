using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Classes;
using Mutantes;

namespace Mutant.Controllers
{
    [Route("[controller]")]
    public class MutantController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Classes.Mutant m)
        {
            if (m == null)
                this.HttpContext.Response.StatusCode = 500;
            else
            {
                if (m.DNA.Length > 0)
                {
                    functions _f = new functions();
                    if (_f.isMutant(m))
                        this.HttpContext.Response.StatusCode = 200;
                    else
                        this.HttpContext.Response.StatusCode = 403;
                }
                else
                {
                    this.HttpContext.Response.StatusCode = 500;
                }
            }
        }
    }
}