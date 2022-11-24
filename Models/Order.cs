using System;
using System.Collections.Generic;

namespace ООО__Столовые_приборы_.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderDeliveryDate { get; set; }
        public int OrderPickupPointId { get; set; }
        public int OrderCode { get; set; }
        public int OrderStatus { get; set; }
        public int? UserId { get; set; }

        public virtual PickupPoint OrderPickupPoint { get; set; } = null!;
        public virtual Status OrderStatusNavigation { get; set; } = null!;
        public virtual User? User { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
