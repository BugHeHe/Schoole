using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mo.Models;
using Microsoft.AspNetCore.Cors;

namespace Student.Controllers
{
    [Produces("application/json")]
    [Route("api/JiaTing/[action]")]
    [EnableCors("Kua")]
    public class JiaTingController : Controller
    {
        private SchoolContext db = new SchoolContext();

        [HttpGet]
        public List<Mo.Models.JiaTingZhuang> GetJia()
        {
            return db.JiaTingZhuang.ToList();
        }



    }
}