using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class ClassSchedule
    {
        public int Id { get; set; }
        public int? ClassId { get; set; }
        public DateTime? CreateTime { get; set; }
        public bool? ShangXia { get; set; }
        public int? Place { get; set; }
        public int? UserId { get; set; }

        public Class Class { get; set; }
        public Place PlaceNavigation { get; set; }
        public User User { get; set; }
    }
}
