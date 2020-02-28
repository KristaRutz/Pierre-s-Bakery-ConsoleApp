using System;
using System.Collections.Generic;
using Products;
using System.Threading;

namespace BakeryService.Models
{
  public class Bakery
  {
    public string BakeryName { get; set; }
    public int BreadLoaves { get; set; } = 0;
    public int Pastries { get; set; } = 0;

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
      if (ContinueOrExit())
      {
        Console.Write("How can we assist you today? ");
      }
    }

    public void PrintDeals()
    {
      Console.WriteLine("");
      Console.WriteLine("---------- M E N U ----------");
      if (BreadLoaves > 0 || Pastries > 0)
      {
        if (BreadLoaves > 0)
        {
          Console.WriteLine("Loaf of bread..............$5");
        }
        else
        {
          Console.WriteLine("Loaf of bread....OUT OF STOCK");
        }
        if (Pastries > 0)
        {
          Console.WriteLine("Pastry.....................$2");
        }
        else
        {
          Console.WriteLine("Pastry...........OUT OF STOCK");
        }
        Console.WriteLine("");
        Console.WriteLine("           specials");
        Console.WriteLine("  Buy 2 loaves, get 1 free!");
        Console.WriteLine("   Buy 3 pastries for $5!");
      }
      else {
        Console.WriteLine("");
        Console.WriteLine("We are currently SOLD OUT of all items!");
        Console.WriteLine("");
      }
      Console.WriteLine("-----------------------------");
      Console.WriteLine("");
    }

    public void CustomersChoice()
    {
      Console.WriteLine("[Type '1' to view the daily menu again, '2' to make a menu order, '3' to view your current order, '4' to checkout, or 'x' to quit]");
      string choice = Console.ReadLine();
      if (choice == "1")
      {
        PrintDeals();
        CustomersChoice();
      }
      else if (choice == "2")
      {
        CustomersChoice();
      }
      else if (choice == "3")
      {
        CustomersChoice();
      }
      else if (choice == "4")
      {
        // perhaps continue or exit?
      }
      else if (choice == "x" || choice == "X")
      {
        Console.WriteLine("Goodbye.");
        System.Environment.Exit(0);
      }
      else
      {
        CustomersChoice();
      }
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
        Console.WriteLine("Goodbye.");
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