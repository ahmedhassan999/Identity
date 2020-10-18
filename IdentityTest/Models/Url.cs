using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class Url
    {
        public int Id { get; set; }
        public string Url1 { get; set; }
        public long LessonId { get; set; }

        public virtual Lesson Lesson { get; set; }
    }
}
