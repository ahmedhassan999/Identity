using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class PreprationRequestDetailes
    {
        public long Id { get; set; }
        public long PreparationRequestId { get; set; }
        public int SubjectId { get; set; }

        public virtual PreparationRequest PreparationRequest { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
