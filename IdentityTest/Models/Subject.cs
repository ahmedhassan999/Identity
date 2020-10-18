using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Lesson = new HashSet<Lesson>();
            PreprationRequestDetailes = new HashSet<PreprationRequestDetailes>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int SemesterId { get; set; }
        public decimal Price { get; set; }

        public virtual Semester Semester { get; set; }
        public virtual ICollection<Lesson> Lesson { get; set; }
        public virtual ICollection<PreprationRequestDetailes> PreprationRequestDetailes { get; set; }
    }
}
