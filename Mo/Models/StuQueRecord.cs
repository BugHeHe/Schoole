using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class StuQueRecord
    {
        public StuQueRecord()
        {
            Result = new HashSet<Result>();
            StuQueRecordDetail = new HashSet<StuQueRecordDetail>();
        }

        public int RecordId { get; set; }
        public int StudetnId { get; set; }
        public int PaperId { get; set; }
        public DateTime RecordTime { get; set; }

        public Paper Paper { get; set; }
        public Student Studetn { get; set; }
        public ICollection<Result> Result { get; set; }
        public ICollection<StuQueRecordDetail> StuQueRecordDetail { get; set; }
    }
}
