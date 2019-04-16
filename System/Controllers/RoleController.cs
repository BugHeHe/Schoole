using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Mo.Models;
using Newtonsoft.Json.Linq;
using Mo.ViewModel;

namespace System.Controllers
{
    [Produces("application/json")]
    [Route("api/Role/[action]")]
    [EnableCors("kua")]
    public class RoleController : Controller
    {
        private SchoolContext ef = new SchoolContext();

        [HttpPost]
        public List<Role> UserList([FromBody] JObject ob)
        {
            try
            {
                dynamic result = ob;
                int useid = result.useid;
                List<Role> li = new List<Role>();
                foreach (var item in ef.RoleUser.Where(x=>x.UserId==useid))
                {
                    li.Add(ef.Role.FirstOrDefault(x => x.Id == item.RoleId));
                }
                return li;
            }
            catch
            {
                return new List<Role>();
            }
        }
    }
}