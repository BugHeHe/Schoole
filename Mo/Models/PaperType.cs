using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class PaperType
    {
        public PaperType()
        {
            Paper = new HashSet<Paper>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public ICollection<Paper> Paper { get; set; }
    }
}
