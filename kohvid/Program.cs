using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kohvid
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klient
            int TotalCoffeCost = 0;

            Console.WriteLine("Hello! Welcome to the coffee shop. what kind of coffee do you want to buy? \n1 - Ekspresso \n2 - Latte \n3 - Cappuccino");
            int UserChoise = Int32.Parse(Console.ReadLine());
            switch (UserChoise)
            {
                case 1:
                    var ekspresso = new Ekspresso();
                    ekspresso.CoffeSize();
                    ekspresso.DrinkCoffe();
                    break;

                case 2:
                    var latte = new Latte();
                    latte.CoffeSize();
                    latte.DrinkCoffe();
                    break;
                case 3:
                    var Cappuccino = new Cappuccino();
                    Cappuccino.CoffeSize();
                    Cappuccino.DrinkCoffe();
                    break;
            }
            Console.WriteLine(" do you want to buy food? \n1 - Pie \n2 - Apple \n3 - I do not want to buy food ");
            int UserChoise2 = Int32.Parse(Console.ReadLine());
            switch (UserChoise2)
            {
                case 1:
                    var pie = new Pie();
                    pie.EatFood();
                    break;
                case 2:
                    var apple = new Apple();
                    apple.EatFood();
                    break;
                case 3:
                    break;
            }
            {


                Console.WriteLine(" Thanks you for shopping us.");
                Console.ReadLine();
            }
        }
    }
}
            
        
    
