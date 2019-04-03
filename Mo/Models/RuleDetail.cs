using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class RuleDetail
    {
        public int DetailId { get; set; }
        public int RuleId { get; set; }
        public int BookId { get; set; }
        public int? ChapterId { get; set; }
        public int QuestionCount { get; set; }
        public int QuestionLevel { get; set; }

        public TextBook Book { get; set; }
        public Chapter Chapter { get; set; }
        public PaperRule Rule { get; set; }
    }
}
