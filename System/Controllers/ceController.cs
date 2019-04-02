using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace System.Controllers
{
    [Produces("application/json")]
    [Route("api/ce")]
    public class ceController : Controller
    {
        public string Get()
        {
            return "服务状态良好 84端口开启 平台权限/";
        }
    }
}