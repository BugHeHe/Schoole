using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class Role
    {
        public Role()
        {
            RoleMenu = new HashSet<RoleMenu>();
            RoleUser = new HashSet<RoleUser>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }

        public ICollection<RoleMenu> RoleMenu { get; set; }
        public ICollection<RoleUser> RoleUser { get; set; }
    }
}
