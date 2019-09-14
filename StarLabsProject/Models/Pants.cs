using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabsProject.Models
{
    public class Pants : Products
    {
        public override double getFinalPrice(string size)
        {
            return GetDefaultPrice(size);
        }

     
    }
   public  class Jeans:Pants
    {
       

    }
   public class FormalPants : Pants
    {
        public override double getFinalPrice(string size)
        {
            return GetDefaultPrice(size)+30;
        }
    }
}
