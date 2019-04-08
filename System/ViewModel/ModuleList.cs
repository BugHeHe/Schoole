using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System.ViewModel
{
    public class ModuleList
    {
        public int ID { get; set; }
        public int? PlatformSystemId { get; set; }
        public string ModuleName { get; set; }
        public string icon  { get; set; }
        public string path { get; set; }
        public string view { get; set; }
        public List<MenuList> menu { get; set; }
    }
}
