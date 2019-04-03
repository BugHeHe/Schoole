using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class JiaTingZhuang
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Guan { get; set; }
        public string Job { get; set; }
        public string Zhi { get; set; }

        public Student Student { get; set; }
    }
}
