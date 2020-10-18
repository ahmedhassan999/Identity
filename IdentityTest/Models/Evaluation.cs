using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class Evaluation
    {
        public int Id { get; set; }
        public string EvaluationType { get; set; }
        public string EvaluationQuestion { get; set; }
        public long LessonId { get; set; }

        public virtual Lesson Lesson { get; set; }
    }
}
