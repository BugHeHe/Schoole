using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class RoleMenu
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? MenuId { get; set; }

        public Menu Menu { get; set; }
        public Role Role { get; set; }
    }
}
