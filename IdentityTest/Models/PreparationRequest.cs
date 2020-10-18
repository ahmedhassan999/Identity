using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class PreparationRequest
    {
        public PreparationRequest()
        {
            PraparationDelivery = new HashSet<PraparationDelivery>();
            PreprationRequestDetailes = new HashSet<PreprationRequestDetailes>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public decimal TotalPrice { get; set; }
        public long CustomerId { get; set; }
        public int PreparationRequestTypeId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual PreparationRequestType PreparationRequestType { get; set; }
        public virtual ICollection<PraparationDelivery> PraparationDelivery { get; set; }
        public virtual ICollection<PreprationRequestDetailes> PreprationRequestDetailes { get; set; }
    }
}
