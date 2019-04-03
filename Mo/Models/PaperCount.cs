using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class PaperCount
    {
        public int Id { get; set; }
        public int? ClassId { get; set; }
        public DateTime? Time { get; set; }
        public double? Percent { get; set; }

        public Class Class { get; set; }
    }
}
