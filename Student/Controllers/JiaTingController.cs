using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mo.Models;
using Microsoft.AspNetCore.Cors;
using Mo.ViewModel;

namespace Student.Controllers
{
    [Produces("application/json")]
    [Route("api/JiaTing/[action]")]
    [EnableCors("Kua")]
    public class JiaTingController : Controller
    {
        private SchoolContext db = new SchoolContext();

        [HttpGet]
        public List<JiaTingList> GetJia()
        {
            List<JiaTingList> li = new List<JiaTingList>();
            try
            {
                foreach (var item in db.JiaTingZhuang.ToList())
                {
                    li.Add(new JiaTingList()
                    {
                        Guan = item.Guan,
                        ID = item.Id,
                        Job=item.Job,
                        Name=item.Name,
                        Phone=item.Phone,
                        StudentName=db.Student.FirstOrDefault(x=>x.Id==item.StudentId).StudentName,
                        Zhi=item.Zhi
                    });
                }
                return li;
            }
            catch
            {
                return new List<JiaTingList>();
            }
        }



    }
}