using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class StuQueRecordDetail
    {
        public int RecordDetailId { get; set; }
        public int? RecordId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }

        public Answer Answer { get; set; }
        public Question Question { get; set; }
        public StuQueRecord Record { get; set; }
    }
}
