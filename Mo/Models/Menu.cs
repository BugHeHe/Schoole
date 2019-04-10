using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class Menu
    {
        public Menu()
        {
            RoleMenu = new HashSet<RoleMenu>();
        }

        public int Id { get; set; }
        public string MenuName { get; set; }
        public int? ModuleId { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string View { get; set; }

        public Module Module { get; set; }
        public ICollection<RoleMenu> RoleMenu { get; set; }
    }
}
