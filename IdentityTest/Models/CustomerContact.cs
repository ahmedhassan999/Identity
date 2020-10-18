using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class CustomerContact
    {
        public long Id { get; set; }
        public string Contact { get; set; }
        public int ContactTypeId { get; set; }
        public long CustomerId { get; set; }

        public virtual ContactType ContactType { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
