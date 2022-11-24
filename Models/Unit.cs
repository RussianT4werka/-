using System;
using System.Collections.Generic;

namespace ООО__Столовые_приборы_.Models
{
    public partial class Unit
    {
        public Unit()
        {
            Products = new HashSet<Product>();
        }

        public int UnitsId { get; set; }
        public string UnitsName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
