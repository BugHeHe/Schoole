using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapperDemo.Configs;
using Mo.Models;
using Mo.ViewModel;

namespace AutoMapperDemo.Configs
{
    /// <summary>
    /// 映射的配置文件类
    /// </summary>
    public class ConfigProfile : Profile
    {
        public ConfigProfile()
        {
            //       < 源类型，目标类型>
            CreateMap<Menu, MenuList>();
                // 设置 属性的映射， 源属性
               // .ForMember(d => d.FullName, opt => opt.MapFrom(src => src.FirstName + src.LastName));
            //CreateMap<UserViewModel, UserData>()
                //.ForMember(d => d.FirstName, opt => opt.MapFrom(src => src.FullName.Substring(0, 1)))
                //.ForMember(d => d.LastName, opt => opt.MapFrom(src => src.FullName.Substring(1)))
                //.ForPath(d => d.UserState.ID, opt => opt.MapFrom(src => src.UserStateID))
                //.ForPath(d => d.UserState.Name, opt => opt.MapFrom(src => src.UserStateName));


        }
    }
}
