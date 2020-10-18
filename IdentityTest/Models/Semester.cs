using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class Semester
    {
        public Semester()
        {
            Subject = new HashSet<Subject>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }

        public virtual Class Class { get; set; }
        public virtual ICollection<Subject> Subject { get; set; }
    }
}
