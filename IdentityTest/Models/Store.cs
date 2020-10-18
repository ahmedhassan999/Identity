using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class Store
    {
        public Store()
        {
            PraparationDelivery = new HashSet<PraparationDelivery>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }

        public virtual ICollection<PraparationDelivery> PraparationDelivery { get; set; }
    }
}
