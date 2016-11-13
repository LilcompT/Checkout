using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOutSystem
{
    public class Product
    {
        double apple = 0.60;
        double orange = 0.25;

        private List<double> basket = new List<double>();

        //Enables user to submit amount of items into the basket
        public void CustomerBasket()
        {
            Console.Write("Amount of Apples: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            // Adds the amount of apple to the basket
            AddApple(amount);

            Console.Write("Amount of Oranges: ");
            amount = Convert.ToInt32(Console.ReadLine());
            // Adds the amount of oranges to the basket
            AddOrange(amount);
        }

        // Method that inserts "apple" into the list, which is dependant on the amount to add
        public void AddApple(int appleAmount)
        {
            for (int i = 0; i < appleAmount; i++)
            {
                basket.Add(apple);
            }
        }

        // Method that inserts "orange" into the list, which is dependant on the amount to add
        public void AddOrange(int orangeAmount)
        {
            for (int j = 0; j < orangeAmount; j++)
            {
                basket.Add(orange);
            }
        }

        // Returns the number of apples and/or oranges present in the basket
        public int NumOfItems()
        {
            return basket.Count;
        }

        // Enables the basket in its entirety to be submitted to the till
        public List<double> GetBasket()
        {
            return basket;
        }

        // Empty the basket after till is done processing the items
        public void EmptyBasket()
        {
            basket.Clear();

        }
    }

    public class CheckOutSys
    {
        double total = 0.0;

        // Method will sum the amount of items that are present in the basket depending on their price
        public void Till(List<double> basket)
        {
            foreach (double item in basket)
            {
                total += item;
            }

            Product reset = new Product();
        }

        // Returns the basket total
        public double ReturnTotal()
        {
            return total;
        }

        static void Main(String[] args)
        {
            // Create the instances of the two classes
            CheckOutSys Checkout = new CheckOutSys();
            Product fruit = new Product();

            // Calls the core methods to perform operation
            fruit.CustomerBasket();
            Checkout.Till(fruit.GetBasket());
            fruit.EmptyBasket();

            Console.WriteLine("\n----------------------------");
            Console.WriteLine("Total Cost: £{0}", Checkout.ReturnTotal());
            Console.WriteLine("----------------------------");
        }
    }
}
