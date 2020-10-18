using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class Objective
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long LessonId { get; set; }

        public virtual Lesson Lesson { get; set; }
    }
}
