using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class Da
    {
        public int Id { get; set; }
        public int? ClassId { get; set; }
        public DateTime Time { get; set; }
        public int? PlaceId { get; set; }
        public int? UserId { get; set; }

        public Class Class { get; set; }
        public Place Place { get; set; }
        public User User { get; set; }
    }
}
