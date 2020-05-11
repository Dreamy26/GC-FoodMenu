using System;

namespace Assessment1b
{
    class Program
    {
        public static void Main(string[] args)
        {
            string menuChoice;
            double totalBurgers = 0;
            double totalBurgerCost = 0;
            double totalSodas = 0;
            double totalSodaCost = 0;
            double subtotal = 0;
            double total = 0;
            string burgerAsterisks = "";
            string sodaAsterisks = "";

            // create a string variable called burgerAsterisks
            // create a string variable called sodaAsterisks



            do
            {
                //Print a Menu
                Console.WriteLine("1. Burger\n 2. Soda\n 3. Exit\n");
                Console.WriteLine("Select an option:  ");
               // Console.WriteLine("Menu Choice: 1, 2, 3 ");
                //Retrieve the user's choice
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                       

                        //Console.WriteLine("Menu Choice: 1, 2, 3  ");

                        totalBurgerCost = totalBurgerCost + 2.50;
                        totalBurgers += 1;
                        Console.WriteLine("total burger cost " + totalBurgerCost);
                        break;
                    case "2":
                        totalSodas += 1;
                        totalSodaCost += 1.25;
                        

                      //  Console.WriteLine("Menu Choice: 1, 2, 3  ");

                        //menuChoice = Console.ReadLine();
                        break;

                    case "3":
                        break;

                    default:
                        Console.WriteLine(" Sorry I didn't understand, let's try again");
                        break;


                }

            } while (menuChoice != "3");   // Loop ends if 3. is selected

            for (int i = 0; i < totalSodas; i++)
            {
                sodaAsterisks += "*";
            }

            for (int i = 0; i < totalBurgers; i++)
            {
                burgerAsterisks += "*";
            }
            //foreach (double burger in menuChoice)
            // {

            //}

            subtotal = totalBurgerCost + totalSodaCost;
            total = (subtotal * .07) + subtotal ;
            
            Console.WriteLine("Subtotal: " + subtotal);
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Sodas: " + sodaAsterisks);
            Console.WriteLine("Burgers: " + burgerAsterisks);



        }


    }
}

            
    

