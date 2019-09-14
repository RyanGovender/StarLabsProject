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
        Shirt shirt= new Shirt();
        private Pants jeans = new Pants();
        

   
        private  double CalculateShirtPrice()
        {
            var totalcost = 0.00;
            foreach (var item in shirts)
            {
                if (item.Type.Equals("tshirt"))totalcost += shirt.getFinalPrice(item.Size);
                else if(item.Type.Equals("Golfer")) totalcost += shirt.GetGolferPrice(item.Size);
            }
           
            return totalcost;
        }

        private double CalculatePantsPrice()
        {
            var totalcost = 0.00;
            foreach (var item in pants)
            {
                if (item.Type.Equals("jeans")) totalcost += jeans.getFinalPrice(item.Size);
                else if(item.Type.Equals("formalpants"))totalcost += jeans.FormalPants(item.Size);  
            }

            return totalcost;
        }

        public double GetTotalPrice()
        {
            return CalculateShirtPrice() + CalculatePantsPrice();
        }

    }
}
