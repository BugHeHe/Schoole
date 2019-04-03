using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class Place
    {
        public Place()
        {
            ClassSchedule = new HashSet<ClassSchedule>();
            Da = new HashSet<Da>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ClassSchedule> ClassSchedule { get; set; }
        public ICollection<Da> Da { get; set; }
    }
}
