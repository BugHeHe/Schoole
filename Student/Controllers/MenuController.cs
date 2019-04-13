using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Mo.Models;
using Mo.ViewModel;
using Newtonsoft.Json.Linq;

namespace Student.Controllers
{
    [Produces("application/json")]
    [Route("api/mokuai/[action]")]
    [EnableCors("Kua")]
    public class MenuController : Controller
    {
        private SchoolContext ef = new SchoolContext();
        [HttpPost]
        public List<ModuleList> MenuList([FromBody]JObject ob)
        {

            List<int> shu = new List<int>();
            List<int> shu1 = new List<int>();
            try
            {
                dynamic result = ob;
                int userid = result.id;
                List<ModuleList> li = new List<ModuleList>();

                //首先获取该用户 角色中 所拥有的的具体模块
                foreach (var item in ef.RoleUser.Where(x => x.UserId == userid))
                {
                    foreach (var item1 in ef.RoleMenu.Where(x => x.RoleId == item.RoleId))
                    {
                        int i = Convert.ToInt32(item1.MenuId);
                        if (ef.Module.FirstOrDefault(x => x.Id == ef.Menu.FirstOrDefault(x1 => x1.Id == i).ModuleId).PlatformSystemId ==4)
                        {
                            if (shu.Contains((int)ef.Menu.FirstOrDefault(x1 => x1.Id == i).ModuleId)) { }
                            else shu.Add((int)ef.Menu.FirstOrDefault(x1 => x1.Id == i).ModuleId);
                            if (shu1.Contains(i)) { } else { shu1.Add(i); }
                        }
                    }
                }
                //根据具体模块信息 获取二级菜单的父集
                foreach (var item in shu)
                {
                    ModuleList dui = new ModuleList();
                    dui.icon = ef.Module.FirstOrDefault(x => x.Id == item).Icon;
                    dui.ID = ef.Module.FirstOrDefault(x => x.Id == item).Id;
                    dui.ModuleName = ef.Module.FirstOrDefault(x => x.Id == item).ModuleName;
                    dui.path = ef.Module.FirstOrDefault(x => x.Id == item).Path;
                    dui.PlatformSystemId = ef.Module.FirstOrDefault(x => x.Id == item).PlatformSystemId;
                    dui.view = ef.Module.FirstOrDefault(x => x.Id == item).View;

                    List<MenuList> me = new List<MenuList>();
                    foreach (var item1 in shu1)
                    {
                        if (ef.Menu.FirstOrDefault(x => x.Id == item1).ModuleId != item)
                        {
                            continue;
                        }
                        me.Add(new MenuList()
                        {
                            icon = ef.Menu.FirstOrDefault(x => x.Id == item1).Icon,
                            ID = ef.Menu.FirstOrDefault(x => x.Id == item1).Id,
                            MenuName = ef.Menu.FirstOrDefault(x => x.Id == item1).MenuName,
                            ModuleID = ef.Menu.FirstOrDefault(x => x.Id == item1).ModuleId,
                            path = ef.Menu.FirstOrDefault(x => x.Id == item1).Path,
                            View = ef.Menu.FirstOrDefault(x => x.Id == item1).View,
                            name = ef.Menu.FirstOrDefault(x => x.Id == item1).Name,
                        });
                    }
                    dui.menu = me != null ? me : null;
                    li.Add(dui);
                }
                return li;
            }
            catch (Exception ex)
            {
                return new List<ModuleList>();
            }
        }
    }
}