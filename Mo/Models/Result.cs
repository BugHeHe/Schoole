using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class Result
    {
        public int ResultId { get; set; }
        public int RecordId { get; set; }
        public int Score { get; set; }

        public StuQueRecord Record { get; set; }
    }
}
