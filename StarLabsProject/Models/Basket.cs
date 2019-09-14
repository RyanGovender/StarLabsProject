using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabsProject.Models
{
    public class Basket
    {
        public  List<Products> shirts= new List<Products>();
        public List<Products> pants = new List<Products>();
        private Shirt shirt= new Shirt();
        private Pants jeans = new Pants();
        

   
        private  double CalculateShirtPrice()
        {
            var totalcost = 0.00;
            foreach (var item in shirts)
            {
               
                totalcost += item.getFinalPrice(item.Size);
            }
           
            return totalcost;
        }

        private double CalculatePantsPrice()
        {
            var totalcost = 0.00;
            foreach (var item in pants)
            {
                totalcost += item.getFinalPrice(item.Size);
            }

            return totalcost;
        }

        public double GetTotalPrice()
        {
            return CalculateShirtPrice() + CalculatePantsPrice();
        }

    }
}
