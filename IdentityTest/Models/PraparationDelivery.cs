using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class PraparationDelivery
    {
        public long Id { get; set; }
        public long PreparationRequestId { get; set; }
        public int StoreId { get; set; }
        public int ShippingId { get; set; }

        public virtual PreparationRequest PreparationRequest { get; set; }
        public virtual Shipping Shipping { get; set; }
        public virtual Store Store { get; set; }
    }
}
