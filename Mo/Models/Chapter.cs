using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class Chapter
    {
        public Chapter()
        {
            Question = new HashSet<Question>();
            RuleDetail = new HashSet<RuleDetail>();
        }

        public int ChapterId { get; set; }
        public string ChapterName { get; set; }
        public int BookId { get; set; }

        public TextBook Book { get; set; }
        public ICollection<Question> Question { get; set; }
        public ICollection<RuleDetail> RuleDetail { get; set; }
    }
}
