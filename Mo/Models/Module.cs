using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class Module
    {
        public Module()
        {
            Menu = new HashSet<Menu>();
        }

        public int Id { get; set; }
        public int? PlatformSystemId { get; set; }
        public string ModuleName { get; set; }
        public string Icon { get; set; }
        public string Path { get; set; }
        public string View { get; set; }

        public PlatformSystem PlatformSystem { get; set; }
        public ICollection<Menu> Menu { get; set; }
    }
}
