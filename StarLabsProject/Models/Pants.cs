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

        public double FormalPants(string size)
        {
            return getFinalPrice(size) + 30;
        }
    }
   public  class Jeans:Pants
    {
        public Jeans()
        {
            Type = "jeans";
        }

    }
   public class FormalPants : Pants
   {
       public FormalPants()
       {
           Type = "formalpants";
       }
   }
}
