using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace Student.Controllers
{
    [Produces("application/json")]
    [Route("api/ce")]
    public class ceController : Controller
    {
        public string Get()
        {
            return "服务状态良好 8081端口 学生信息管理系统";
        }
    }
}