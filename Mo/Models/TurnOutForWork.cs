using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class TurnOutForWork
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public DateTime? Time { get; set; }
        public bool? If { get; set; }

        public Student Student { get; set; }
    }
}
