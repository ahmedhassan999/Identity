using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class Class
    {
        public Class()
        {
            Semester = new HashSet<Semester>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int StageId { get; set; }

        public virtual Stage Stage { get; set; }
        public virtual ICollection<Semester> Semester { get; set; }
    }
}
