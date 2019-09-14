using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabsProject.Models
{
    public abstract class Products
    {
        public string Name;
        public string Size;

        public double GetDefaultPrice(string size)
        {
            if (size.Equals("s")) return 10;
            return size.Equals("m") ? 20 : 30;
        }

        public abstract double getFinalPrice(string Size);
    }
}
