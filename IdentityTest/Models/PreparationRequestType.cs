using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class PreparationRequestType
    {
        public PreparationRequestType()
        {
            PreparationRequest = new HashSet<PreparationRequest>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PreparationRequest> PreparationRequest { get; set; }
    }
}
