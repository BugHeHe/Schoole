using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class TextBook
    {
        public TextBook()
        {
            Chapter = new HashSet<Chapter>();
            Question = new HashSet<Question>();
            RuleDetail = new HashSet<RuleDetail>();
        }

        public int BookId { get; set; }
        public string BookName { get; set; }
        public int GradeId { get; set; }

        public Grade Grade { get; set; }
        public ICollection<Chapter> Chapter { get; set; }
        public ICollection<Question> Question { get; set; }
        public ICollection<RuleDetail> RuleDetail { get; set; }
    }
}
