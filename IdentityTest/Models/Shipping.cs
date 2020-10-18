using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class Shipping
    {
        public Shipping()
        {
            PraparationDelivery = new HashSet<PraparationDelivery>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PraparationDelivery> PraparationDelivery { get; set; }
    }
}
