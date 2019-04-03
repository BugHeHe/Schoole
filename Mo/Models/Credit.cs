using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class Credit
    {
        public Credit()
        {
            CreaditXi = new HashSet<CreaditXi>();
        }

        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? Fen { get; set; }

        public Student Student { get; set; }
        public ICollection<CreaditXi> CreaditXi { get; set; }
    }
}
