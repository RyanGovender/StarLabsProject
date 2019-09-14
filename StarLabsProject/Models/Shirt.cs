using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabsProject.Models
{
    public class Shirt : Products
    {
        public override double getFinalPrice(string Size)
        {
            return GetDefaultPrice(Size);
        }
    }
    
    public class TShirt:Shirt
    {
     
    }
    public class Golfer : Shirt
    {
     
        public override double getFinalPrice(string Size)
        {
            return GetDefaultPrice(size: Size)*2;
        }
    }
}
