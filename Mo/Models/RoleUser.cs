using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class RoleUser
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }

        public Role Role { get; set; }
        public User User { get; set; }
    }
}
