using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarLabsProject.Models;

namespace StarLabsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var basket = new Basket();
            var shirt = new TShirt();
            shirt.Name = "Dc Shirt";
            shirt.Size = "m";
            basket.shirts.Add(shirt);

            var golfer= new Golfer();
            golfer.Name = "Old Khaki Golfer";
            golfer.Size = "l";
            basket.shirts.Add(golfer);

            var jeans= new Jeans();
            jeans.Name = "Levis Jeans";
            jeans.Size = "s";
            basket.pants.Add(jeans);

            var formalpants= new FormalPants();
            formalpants.Name = "Formal Pants";
            formalpants.Size = "m";
            basket.pants.Add(formalpants);

            Console.WriteLine($"Your total price is {basket.GetTotalPrice()}");
            Console.ReadKey();

          
        }
    }
}
