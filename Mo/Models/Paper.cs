using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class Paper
    {
        public Paper()
        {
            StuQueRecord = new HashSet<StuQueRecord>();
        }

        public int PaperId { get; set; }
        public string PaperName { get; set; }
        public int GradeId { get; set; }
        public int TypeId { get; set; }
        public int Duration { get; set; }
        public bool IsOpen { get; set; }
        public string ClassList { get; set; }
        public int RuleId { get; set; }
        public int QuestionCount { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreatorId { get; set; }

        public User Creator { get; set; }
        public Grade Grade { get; set; }
        public PaperRule Rule { get; set; }
        public PaperType Type { get; set; }
        public ICollection<StuQueRecord> StuQueRecord { get; set; }
    }
}
