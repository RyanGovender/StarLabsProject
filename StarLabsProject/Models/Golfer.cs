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
            Type = "Golfer";
        }
        public override double getFinalPrice(string Size)
        {
            return GetDefaultPrice(Size)*2;
        }
    }
}
