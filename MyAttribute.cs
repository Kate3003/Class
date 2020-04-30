using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class MyAttribute : Attribute
    {
        public string color { get; set; }
        public string breed { get; set; }
    }
}
