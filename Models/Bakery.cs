using System;
using System.Collections.Generic;
using Products;

namespace BakeryService.Models
{
  public class Bakery
  {
    public string BakeryName { get; set; }
    public int BreadLoaves { get; set; } = 40;
    public int Pastries { get; set; } = 100;

    public Bakery(string bakeryName)
    {
      BakeryName = bakeryName;
    }

    public void WelcomeACustomer()
    {
      Console.WriteLine($"Welcome to {BakeryName} Bakery!");
       Console.WriteLine();
      Console.WriteLine("Here is today's menu:");
      PrintDeals();
      //PrintItemsInStock();
      if (ContinueOrExit())
      {
        Console.Write("How can we assist you today? ");
      }
    }

    public void PrintDeals()
    {
      Console.WriteLine("");
      Console.WriteLine("---------- M E N U ----------");
      Console.WriteLine("Loaf of bread..............$5");
      Console.WriteLine("Pastry.....................$2");
      Console.WriteLine("-----------specials----------");
      Console.WriteLine("Buy 2 loaves, get 1 free!....");
      Console.WriteLine("Buy 3 pastries for $5!.......");
    }

    public void CustomersChoice()
    {

    }

    public bool ContinueOrExit()
    {
      Console.WriteLine("['1' to continue, '2' to exit]");
      string choice = Console.ReadLine();
      if (choice == "1")
      {
        return true;
      }
      else if (choice == "2")
      {
        System.Environment.Exit(0);
        return false;
      }
      else
      {
        return ContinueOrExit();
      }
    }
  }
}