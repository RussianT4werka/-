using System;
using System.Collections.Generic;

namespace ООО__Столовые_приборы_.Models
{
    public partial class Provider
    {
        public Provider()
        {
            Products = new HashSet<Product>();
        }

        public int ProviderId { get; set; }
        public string ProviderName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
