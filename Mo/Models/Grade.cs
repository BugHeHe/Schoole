using System;
using System.Collections.Generic;

namespace Mo.Models
{
    public partial class Grade
    {
        public Grade()
        {
            Class = new HashSet<Class>();
            Paper = new HashSet<Paper>();
            PaperRule = new HashSet<PaperRule>();
            TextBook = new HashSet<TextBook>();
        }

        public int Id { get; set; }
        public string GradeName { get; set; }

        public ICollection<Class> Class { get; set; }
        public ICollection<Paper> Paper { get; set; }
        public ICollection<PaperRule> PaperRule { get; set; }
        public ICollection<TextBook> TextBook { get; set; }
    }
}
