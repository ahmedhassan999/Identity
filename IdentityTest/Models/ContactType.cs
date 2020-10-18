using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class ContactType
    {
        public ContactType()
        {
            CustomerContact = new HashSet<CustomerContact>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CustomerContact> CustomerContact { get; set; }
    }
}
