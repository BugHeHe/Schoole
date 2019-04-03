using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class User
    {
        public User()
        {
            ClassMaster = new HashSet<Class>();
            ClassSchedule = new HashSet<ClassSchedule>();
            ClassTeachar = new HashSet<Class>();
            Da = new HashSet<Da>();
            HaveaTalk = new HashSet<HaveaTalk>();
            Paper = new HashSet<Paper>();
            PaperRule = new HashSet<PaperRule>();
            QuestionCheck = new HashSet<Question>();
            QuestionCreator = new HashSet<Question>();
            RoleUser = new HashSet<RoleUser>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserCid { get; set; }
        public string Password { get; set; }
        public DateTime JoinTime { get; set; }

        public ICollection<Class> ClassMaster { get; set; }
        public ICollection<ClassSchedule> ClassSchedule { get; set; }
        public ICollection<Class> ClassTeachar { get; set; }
        public ICollection<Da> Da { get; set; }
        public ICollection<HaveaTalk> HaveaTalk { get; set; }
        public ICollection<Paper> Paper { get; set; }
        public ICollection<PaperRule> PaperRule { get; set; }
        public ICollection<Question> QuestionCheck { get; set; }
        public ICollection<Question> QuestionCreator { get; set; }
        public ICollection<RoleUser> RoleUser { get; set; }
    }
}
