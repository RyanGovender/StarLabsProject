using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabsProject.Models
{
   public  class Jeans:Products
    {
        public Jeans()
        {
            Type = "jeans";
        }
        public override double getFinalPrice(string Size)
        {
            return GetDefaultPrice(Size);
        }
    }
}
