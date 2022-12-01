using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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

        [NotMapped]
        public BitmapImage Image
        {
            get 
            {
                /*if (ProductPhoto == null)
                    return null;*/

                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                if (ProductPhoto != null)
                {
                    var ms = new MemoryStream(ProductPhoto);
                    bitmapImage.StreamSource = ms;
                }
                else
                {
                    bitmapImage.StreamSource = File.OpenRead("Image/picture.png");
                }
                bitmapImage.EndInit();
                bitmapImage.StreamSource.Close();
                return bitmapImage;
            }
        }

        public virtual Category ProductCategoryNavigation { get; set; } = null!;
        public virtual Manufacturer ProductManufacturerNavigation { get; set; } = null!;
        public virtual Provider ProductProviderNavigation { get; set; } = null!;
        public virtual Unit ProductUnitsNavigation { get; set; } = null!;
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
