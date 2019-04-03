using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class Student
    {
        public Student()
        {
            Credit = new HashSet<Credit>();
            HaveaTalk = new HashSet<HaveaTalk>();
            JiaTingZhuang = new HashSet<JiaTingZhuang>();
            StuQueRecord = new HashSet<StuQueRecord>();
            TurnOutForWork = new HashSet<TurnOutForWork>();
        }

        public int Id { get; set; }
        public string StudentName { get; set; }
        public string Password { get; set; }
        public bool Gender { get; set; }
        public string Phone { get; set; }
        public string CardId { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime Borndate { get; set; }
        public DateTime? CreateTime { get; set; }
        public string XueLi { get; set; }
        public string MinZu { get; set; }
        public string ZhengMian { get; set; }
        public int? ClassId { get; set; }

        public Class Class { get; set; }
        public ICollection<Credit> Credit { get; set; }
        public ICollection<HaveaTalk> HaveaTalk { get; set; }
        public ICollection<JiaTingZhuang> JiaTingZhuang { get; set; }
        public ICollection<StuQueRecord> StuQueRecord { get; set; }
        public ICollection<TurnOutForWork> TurnOutForWork { get; set; }
    }
}
