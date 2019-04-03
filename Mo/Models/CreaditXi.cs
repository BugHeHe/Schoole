using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class CreaditXi
    {
        public int Id { get; set; }
        public int? CreditId { get; set; }
        public DateTime? Time { get; set; }
        public string Title { get; set; }

        public Credit Credit { get; set; }
    }
}
