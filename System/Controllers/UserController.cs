using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Mo.Models;

namespace System.Controllers
{
    [Produces("application/json")]
    [Route("api/User/[action]")]
    [EnableCors("kua")]
    public class UserController : Controller
    {
        private SchoolContext ef = new SchoolContext();

        [HttpPost]
        public User UserLogin([FromBody] User us)
        {
            try
            {
                return ef.User.FirstOrDefault(x => x.UserCid == us.UserCid && x.Password == us.Password) != null ? ef.User.FirstOrDefault(x => x.UserCid == us.UserCid && x.Password == us.Password) : null;
            }
            catch
            {
                return null;
            }
         
        }
    }
}