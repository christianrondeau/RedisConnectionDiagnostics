using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RedisConnectionDiagnostics.WebApiApp.Controllers
{
    [Route("")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public async Task<string> GetAsync()
        {
            return await RedisLib.RedisDiagnosticHelper.Run();
        }
    }
}
