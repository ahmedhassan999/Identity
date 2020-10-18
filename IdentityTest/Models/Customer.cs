using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerContact = new HashSet<CustomerContact>();
            PreparationRequest = new HashSet<PreparationRequest>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CustomerContact> CustomerContact { get; set; }
        public virtual ICollection<PreparationRequest> PreparationRequest { get; set; }
    }
}
