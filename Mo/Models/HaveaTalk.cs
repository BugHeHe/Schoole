using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class HaveaTalk
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? StuId { get; set; }
        public DateTime? Time { get; set; }
        public string DaGai { get; set; }
        public string Ping { get; set; }

        public Student Stu { get; set; }
        public User User { get; set; }
    }
}
