using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabsProject.Models
{
    public class Pants : Products
    {
        public override double getFinalPrice(string Size)
        {
            return GetDefaultPrice(Size);
        }

     
    }
   public  class Jeans:Pants
    {
       

    }
   public class FormalPants : Pants
    {
        public override double getFinalPrice(string Size)
        {
            return GetDefaultPrice(Size)+30;
        }
    }
}
