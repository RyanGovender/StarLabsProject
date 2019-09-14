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

        public double GetGolferPrice(string size)
        {
            return getFinalPrice(size) * 2;
        }
    }
    
    public class TShirt:Shirt
    {
        public TShirt()
        {    
            Type = "tshirt";
        
        }

    }
    public class Golfer : Shirt
    {
        public Golfer()
        {
            Type = "Golfer";
        }
       
    }
}
