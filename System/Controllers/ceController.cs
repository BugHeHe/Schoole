using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json.Linq;

namespace System.Controllers
{
    [Produces("application/json")]
    [Route("api/ce/[action]")]
    [EnableCors("kua")]
    public class ceController : Controller
    {
        public string Get()
        {
            return "服务状态良好 84端口开启 平台权限/";
        }
        
        //linq 中的JObject进行接受  返回json时可以使用 JObject 
        [HttpPost]
        public JObject GetHuo([FromBody]JObject zi)
        {
            JObject returnJson = new JObject();
            dynamic result = zi;
            returnJson.Add("zi", result.zi);
            returnJson.Add("hehe", result.hehe);
            return returnJson;
        }
    }
}