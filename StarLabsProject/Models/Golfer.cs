using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabsProject.Models
{
  public  class Golfer:Products
    {
        public Golfer()
        {
            Name = null;
            Size = null;
            Price = 0.00;
            Type = "Golfer";
        }
        public override double getFinalPrice(string Size)
        {
            return GetDefaultPrice(Size)*2;
        }
    }
}
