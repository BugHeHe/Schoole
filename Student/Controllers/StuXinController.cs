using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Mo.Models;

namespace Student.Controllers
{
    [Produces("application/json")]
    [Route("api/StuXin/[action]")]
    [EnableCors("Kua")]
    public class StuXinController : Controller
    {
        private SchoolContext db = new SchoolContext();

        [HttpGet]
        public List<Mo.Models.Student> GetStus()
        {
            return db.Student.ToList();
        }

        [HttpPost]
        public string Create([FromBody]Mo.Models.Student info)
        {
            try
            {
                db.Entry(info).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
            return "添加成功！";
        }

    }
}