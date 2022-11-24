using System;
using System.Collections.Generic;

namespace ООО__Столовые_приборы_.Models
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Products = new HashSet<Product>();
        }

        public int ManufacturerId { get; set; }
        public string? ManufacturerName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
