using System;
using System.Collections.Generic;

namespace ООО__Столовые_приборы_.Models
{
    public partial class PickupPoint
    {
        public PickupPoint()
        {
            Orders = new HashSet<Order>();
        }

        public int PickupPointId { get; set; }
        public string Article { get; set; } = null!;
        public string TownAdress { get; set; } = null!;
        public string StreetAdress { get; set; } = null!;
        public string? Numberhouse { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
