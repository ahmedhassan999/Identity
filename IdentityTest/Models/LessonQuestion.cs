using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class LessonQuestion
    {
        public long Id { get; set; }
        public string QuestionType { get; set; }
        public string Question { get; set; }
        public long LessonId { get; set; }
        public int QuestionTargetId { get; set; }

        public virtual Lesson Lesson { get; set; }
        public virtual QuestionTarget QuestionTarget { get; set; }
    }
}
