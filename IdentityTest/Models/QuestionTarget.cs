using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class QuestionTarget
    {
        public QuestionTarget()
        {
            LessonQuestion = new HashSet<LessonQuestion>();
        }

        public int Id { get; set; }
        public string Target { get; set; }

        public virtual ICollection<LessonQuestion> LessonQuestion { get; set; }
    }
}
