using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Mo.Models;
using Newtonsoft.Json.Linq;
using System.ViewModel;
using AutoMapper;

namespace System.Controllers
{
    [Produces("application/json")]
    [Route("api/mokuai/[action]")]
    [EnableCors("kua")]
    public class MenuController : Controller
    {
        private SchoolContext ef = new SchoolContext();
        private IMapper _mapper;
        public MenuController(IMapper mapper)
        {
            _mapper = mapper;
        }


        //在平台权限系统中  根据当前人的对象 获取所对应的
        [HttpPost] 
        public List<ModuleList> MenuList()
        {
            List<int> shu = new List<int>();
            try
            {
                List<ModuleList> li = new List<ModuleList>();
                foreach (var item in ef.RoleUser.Where(x => x.UserId ==2))
                {
                    foreach (var item1 in ef.RoleMenu.Where(x => x.RoleId == item.RoleId))
                    {
                        int i = Convert.ToInt32(item1.MenuId);
                        if (shu.Contains(i))
                        { }
                        else
                            shu.Add(i);
                    }
                }
                foreach (var item in shu)
                {
                    if(ef.Module.FirstOrDefault(x=>x.PlatformSystemId==1 && x.Id == item) == null)
                    {
                        break;
                    }
                    ModuleList dui = new ModuleList();
                    dui.icon = ef.Module.FirstOrDefault(x => x.Id == item && x.PlatformSystemId == 1).Icon;
                    dui.ID = ef.Module.FirstOrDefault(x => x.Id == item && x.PlatformSystemId == 1).Id;
                    dui.ModuleName = ef.Module.FirstOrDefault(x => x.Id == item && x.PlatformSystemId == 1).ModuleName;
                    dui.path = ef.Module.FirstOrDefault(x => x.Id == item && x.PlatformSystemId == 1).Path;
                    dui.PlatformSystemId = ef.Module.FirstOrDefault(x => x.Id == item && x.PlatformSystemId == 1).PlatformSystemId;
                    dui.view = ef.Module.FirstOrDefault(x => x.Id == item && x.PlatformSystemId == 1).View;
                  
                    List<MenuList> me = new List<MenuList>();
                    foreach (var item1 in ef.Menu.Where(x=>x.ModuleId==item))
                    {
                        
                        me.Add(new MenuList()
                        {
                            icon = ef.Menu.FirstOrDefault(x => x.Id == item1.Id).Icon,
                            ID = ef.Menu.FirstOrDefault(x => x.Id == item1.Id).Id,
                            MenuName = ef.Menu.FirstOrDefault(x => x.Id == item1.Id).MenuName,
                            ModuleID = ef.Menu.FirstOrDefault(x => x.Id == item1.Id).ModuleId,
                            path = ef.Menu.FirstOrDefault(x => x.Id == item1.Id).Path,
                            View = ef.Menu.FirstOrDefault(x => x.Id == item1.Id).View,
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