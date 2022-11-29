using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ООО__Столовые_приборы_.Tools;

namespace ООО__Столовые_приборы_.ViewModel
{
    public class ProductLictPageVM
    {
        public Command AddProduct { get; set; }
        public Command EditProduct { get; set; }
        public Command RemoveProduct { get; set; }

        public ProductLictPageVM(MainWindowVM mainVM)
        {
            AddProduct = new Command(() =>
            {

            });

            EditProduct = new Command(() =>
            {

            });

            RemoveProduct = new Command(() =>
            {

            });
        }

        
    }
}
