using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Mo.Models;

namespace System.Controllers
{
    [Produces("application/json")]
    [Route("api/Menu")]
    [EnableCors("kua")]
    public class MenuController : Controller
    {
        private SchoolContext ef = new SchoolContext();
        //在平台权限系统中  根据当前人的对象
        public List<Menu> MenuList([FromBody] User us)
        {
            List<Menu> li = new List<Menu>();
            //return ef.Menu.Where(x => x.Id == ef.RoleMenu.Where(a => a.RoleId == ef.RoleUser.Where(b => b.UserId == us.Id)));
            //foreach (var item in ef.Menu)
            //{
            //    foreach (var rs in ef.Role)
            //    {
            //        foreach (var roleus in ef.RoleUser.Where(x=>x.UserId==us.Id).ToList())
            //        {
            //            foreach (var menuid in ef.RoleMenu.Where(x=>x.RoleId==rs.Id).ToList())
            //            {
            //                if (rs.Id == roleus.RoleId)
            //                {
            //                    li.Add(ef.Menu.FirstOrDefault(x=>x.Id==));
            //                }
            //            }
            //        }
            //    }
            //}
            return null;
        }
    }
}