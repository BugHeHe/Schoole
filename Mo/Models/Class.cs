using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class Class
    {
        public Class()
        {
            ClassSchedule = new HashSet<ClassSchedule>();
            Da = new HashSet<Da>();
            PaperCount = new HashSet<PaperCount>();
            Student = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string ClassName { get; set; }
        public int MasterId { get; set; }
        public int TeacharId { get; set; }
        public int GradeId { get; set; }
        public DateTime? CreateTime { get; set; }

        public Grade Grade { get; set; }
        public User Master { get; set; }
        public User Teachar { get; set; }
        public ICollection<ClassSchedule> ClassSchedule { get; set; }
        public ICollection<Da> Da { get; set; }
        public ICollection<PaperCount> PaperCount { get; set; }
        public ICollection<Student> Student { get; set; }
    }
}
