using System;
using System.Collections.Generic;

namespace ООО__Столовые_приборы_.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public string ProductArticleNumber { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public int ProductUnits { get; set; }
        public decimal ProductCost { get; set; }
        public byte ProductMaxDiscount { get; set; }
        public int ProductManufacturer { get; set; }
        public int ProductProvider { get; set; }
        public int ProductCategory { get; set; }
        public byte? ProductDiscountAmount { get; set; }
        public int ProductQuantityInStock { get; set; }
        public string ProductDescription { get; set; } = null!;
        public byte[]? ProductPhoto { get; set; }

        public virtual Category ProductCategoryNavigation { get; set; } = null!;
        public virtual Manufacturer ProductManufacturerNavigation { get; set; } = null!;
        public virtual Provider ProductProviderNavigation { get; set; } = null!;
        public virtual Unit ProductUnitsNavigation { get; set; } = null!;
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
