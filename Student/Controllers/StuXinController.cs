using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Mo.Models;
using Mo.ViewModel;

namespace Student.Controllers
{
    [Produces("application/json")]
    [Route("api/StuXin/[action]")]
    [EnableCors("Kua")]
    public class StuXinController : Controller
    {
        private SchoolContext db = new SchoolContext();

        [HttpGet]
        public List<StudentList> GetStus()
        {
            List<StudentList> li = new List<StudentList>();
            try
            {
                foreach(var item in db.Student.ToList())
                {
                    li.Add(new StudentList()
                    {
                        StudentName = item.StudentName,
                        ClassName=db.Class.FirstOrDefault(x=>x.Id==item.ClassId).ClassName,
                        Password=item.Password,
                        Gender=db.Student.FirstOrDefault(x=>x.Id==item.Id).Gender==true?"女":"男",
                        Phone=item.Phone,
                        CardID=item.CardId,
                        XueLi=item.XueLi,
                        
                    });
                }
                return li;
            }
            catch
            {
                return new List<StudentList>();
            }
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