using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzas.PizzaSelection;
using Pizzas;

public class PizzaOrdering
{
    public static void Main(string[] args)
    {
        Pizza_Basic order;

        string selectedPizza = "";

        while (true)
        {
            Console.WriteLine($"Choose the type of pizza you want to order: \n1 - Margherita(150)\n2 - Pepperoni(200)");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                selectedPizza = "Margherita";
                order = new Pizza_Margherita();
                break;
            }
            else if (choice == "2")
            {
                selectedPizza = "Pepperoni";
                order = new Pizza_Pepperoni();
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose 1 or 2");
            }
        }


        while (true)
        {
            Console.WriteLine("Choose the number of pizzas: ");
            if (int.TryParse(Console.ReadLine(), out int pizzaCount) && pizzaCount > 0)
            {

                if (selectedPizza == "Margherita" && order is Pizza_Margherita margheritaPizza)
                {
                    if (pizzaCount > 0)
                    {
                        int totalCost = margheritaPizza.Price * pizzaCount;
                        Console.WriteLine($"Total cost for {pizzaCount} Margherita is {totalCost}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\"Invalid input. Please enter a number greater than 0.\"");
                    }
                }
                else if (selectedPizza == "Pepperoni" && order is Pizza_Pepperoni pepperoniPizza)
                {
                    if (pizzaCount > 0)
                    {
                        int totalCost = pepperoniPizza.Price * pizzaCount;
                        Console.WriteLine($"Total cost for {pizzaCount} Pepperoni is {totalCost}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\"Invalid input. Please enter a positive number.\"");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }

    }
}