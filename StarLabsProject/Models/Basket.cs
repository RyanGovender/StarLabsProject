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
        TShirt shirt= new TShirt();
        FormalPants fpants= new FormalPants();
        Jeans jeans = new Jeans();
        Golfer golfer = new Golfer();



        private  double CalculateShirtPrice()
        {
            var totalcost = 0.00;
            foreach (var item in shirts)
            {
                if (item.Type.Equals("tshirt"))
                {
                    totalcost += shirt.getFinalPrice(item.Size);
                }
                else
                {
                    totalcost += golfer.getFinalPrice(item.Size);
                }
            }
           
            return totalcost;
        }

        private double CalculatePantsPrice()
        {
            var totalcost = 0.00;
            foreach (var item in pants)
            {
                if (item.Type.Equals("jeans"))
                {
                    totalcost += jeans.getFinalPrice(item.Size);
                }
                else
                {
                    totalcost += fpants.getFinalPrice(item.Size);
                }
            }

            return totalcost;
        }

        public double GetTotalPrice()
        {
            return CalculateShirtPrice() + CalculatePantsPrice();
        }

    }
}
