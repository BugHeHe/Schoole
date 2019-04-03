using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class Question
    {
        public Question()
        {
            Answer = new HashSet<Answer>();
            StuQueRecordDetail = new HashSet<StuQueRecordDetail>();
        }

        public int QuestionId { get; set; }
        public string QuestionTitle { get; set; }
        public bool QuestionType { get; set; }
        public int QuestionLevel { get; set; }
        public int BookId { get; set; }
        public int ChapterId { get; set; }
        public bool IsCheck { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? CheckId { get; set; }
        public DateTime? CheckTime { get; set; }
        public string Description { get; set; }

        public TextBook Book { get; set; }
        public Chapter Chapter { get; set; }
        public User Check { get; set; }
        public User Creator { get; set; }
        public ICollection<Answer> Answer { get; set; }
        public ICollection<StuQueRecordDetail> StuQueRecordDetail { get; set; }
    }
}
