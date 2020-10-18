using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class Strategy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TeacherRole { get; set; }
        public string StudentRole { get; set; }
        public long LessonId { get; set; }

        public virtual Lesson Lesson { get; set; }
    }
}
