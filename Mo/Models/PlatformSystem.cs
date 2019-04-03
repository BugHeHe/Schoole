using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class PlatformSystem
    {
        public PlatformSystem()
        {
            Module = new HashSet<Module>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Creation { get; set; }

        public ICollection<Module> Module { get; set; }
    }
}
