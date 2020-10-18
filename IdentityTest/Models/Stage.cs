using System;
using System.Collections.Generic;

namespace IdentityTest.Models
{
    public partial class Stage
    {
        public Stage()
        {
            Class = new HashSet<Class>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Class> Class { get; set; }
    }
}
