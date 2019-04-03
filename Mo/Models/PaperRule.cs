using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class PaperRule
    {
        public PaperRule()
        {
            Paper = new HashSet<Paper>();
            RuleDetail = new HashSet<RuleDetail>();
        }

        public int RuleId { get; set; }
        public string RuleName { get; set; }
        public int GradeId { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreateTime { get; set; }

        public User Creator { get; set; }
        public Grade Grade { get; set; }
        public ICollection<Paper> Paper { get; set; }
        public ICollection<RuleDetail> RuleDetail { get; set; }
    }
}
