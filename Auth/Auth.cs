using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ООО__Столовые_приборы_.Models;

namespace ООО__Столовые_приборы_.Auth
{
    internal static class Auth
    {
        public static User CurrentUser { get; set; } = new User();
    }
}
