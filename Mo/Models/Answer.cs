using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class Answer
    {
        public Answer()
        {
            StuQueRecordDetail = new HashSet<StuQueRecordDetail>();
        }

        public int AnswerId { get; set; }
        public string AnswerContent { get; set; }
        public int QuestionId { get; set; }
        public bool IsResult { get; set; }

        public Question Question { get; set; }
        public ICollection<StuQueRecordDetail> StuQueRecordDetail { get; set; }
    }
}
