using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Mo.Models;
using Newtonsoft.Json.Linq;

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
            catch(Exception ex)
            {
                return null;
            }
        }
        //查询所有的用户数据
        [HttpPost]
        public List<User> UserList()
        {
            return ef.User.ToList();
        }
        //进行修改的
        [HttpPost]
        public List<User> UserGai([FromBody] User us)
        {
            try
            {
                User u = ef.User.FirstOrDefault(x => x.Id == us.Id);
                u.UserName = us.UserName;
                u.Password = us.Password;
                u.UserCid = us.UserCid;
                ef.Entry(u).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                ef.SaveChanges();
                return ef.User.ToList();
                
            }
            catch(Exception ex)
            {
               return new List<User>();
            }
        }
        //进行删除
        [HttpPost]
        public List<User> UserDelete([FromBody]JObject ob)
        {
           
            dynamic result = ob;
            JObject o = ob;
            int useid= result.idshu;
            try
            {
                User us = ef.User.FirstOrDefault(x => x.Id == useid);
                ef.User.Remove(us);
                ef.SaveChanges();
                return ef.User.ToList();
            }
            catch(Exception ex)
            {
                return new List<User>();
            }
        }
    }
}