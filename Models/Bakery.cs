using System;
using System.Collections.Generic;
using Products;
using System.Threading;

namespace BakeryService.Models
{
  public class Bakery
  {
    public string BakeryName { get; set; }
    public Bread Breads = new Bread(40);
    public Pastry Pastries = new Pastry(100);
    public int Register { get; set; } = 0;
    //public int BreadLoaves { get; set; } = 100;
    //public int Pastries { get; set; } = 40;
    public int UserBreads { get; set; } = 0;
    public int UserPastries { get; set; } = 0;
    //public int[] MyOrder { get; set; }

    public Bakery(string bakeryName)
    {
      BakeryName = bakeryName;
      //MyOrder = new int[] {UserBreads, UserPastries};
    }

    public void WelcomeACustomer()
    {
      Console.WriteLine($"Welcome to {BakeryName} Bakery!");
      Thread.Sleep(1000);
      Console.WriteLine("Here is today's menu:");
      PrintDeals();
      Thread.Sleep(1000);
      Console.WriteLine("How can we assist you today?");
      CustomersChoice();
    }

    public void PrintDeals()
    {
      Console.WriteLine("");
      Console.WriteLine("---------- M E N U ----------");
      if (Breads.BreadInventory > 0 || Pastries.PastryInventory > 0)
      {
        if (Breads.BreadInventory > 0)
        {
          Console.WriteLine("Loaf of bread..............$5");
        }
        else
        {
          Console.WriteLine("Loaf of bread....OUT OF STOCK");
        }
        if (Pastries.PastryInventory > 0)
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

    public void PlaceOrder()
    {
      Console.WriteLine("What would you like to order?");
      string choice = Console.ReadLine().ToLower();
      if (choice == "bread" || choice == "b")
      {
        Console.WriteLine("How many loaves of bread would you like to order? [Enter a number]");
        int amount = int.Parse(Console.ReadLine());
        UserBreads += Breads.OrderBread(amount);
        Console.WriteLine($"Current Bread: ({UserBreads}) loaves for ${Bread.GetCost(UserBreads)}");
        CustomersChoice();
      }
      else if (choice == "pastry" || choice == "pastries" || choice == "p")
      {
        Console.WriteLine("How many pastries would you like to order? [Enter a number]");
        int amount = int.Parse(Console.ReadLine());
        UserPastries += Pastries.OrderPastry(amount);
        Console.WriteLine($"Current Pastries: ({UserPastries}) pastries for ${Pastry.GetCost(UserPastries)}");
        CustomersChoice();
      } 
      // else if (choice == "cinnamon roll" || choice == "coffee")
      // {
      //   Console.WriteLine("You have unlocked the secret menu!");
      //   // ask how many, then add to subtotal;
      // }
      else if (choice == "nothing" || choice == "x")
      {
        Console.Write("Okay. Would you like to continue? ");
        if (ContinueOrExit())
        {
          CustomersChoice();
        }
      }
      else {
        Console.Write("Please enter a valid input. ");
        PlaceOrder();
      }
    }

    public void Checkout()
    {
      PrintOrder();
      Register += Subtotal();
      Console.WriteLine($"You have successfully purchased your items for a total of ${Subtotal()}. Enjoy your baked goods, and we'll see you next time at Pierre's!");
      UserPastries = 0;
      UserBreads = 0;
      ContinueOrExit();
    }

    public void PrintOrder()
    {
      Console.WriteLine();
      if (UserBreads == 0 && UserPastries == 0)
      {
        Console.WriteLine("Your order is empty.");
        CustomersChoice();
      }
      else{
        Console.WriteLine("Your order:");
        if (UserBreads > 0)
        {
          Console.WriteLine($"Loaves of Bread: {UserBreads}");
        }
        if(UserPastries > 0)
        {
          Console.WriteLine($"Pastries: {UserPastries}");
        }
        Console.WriteLine($"Subtotal: ${Subtotal()}");
      }
      
    }

    public int Subtotal()
    {
      return (Bread.GetCost(UserBreads) + Pastry.GetCost(UserPastries));
    }

    public void CustomersChoice()
    {
      Console.WriteLine();
      Thread.Sleep(1000);
      Console.WriteLine("'1' to view the daily menu again");
      Console.WriteLine("'2' to make a menu order");
      Console.WriteLine("'3' to view your current order");
      Console.WriteLine("'4' to checkout");
      Console.WriteLine("'x' to quit");
      //Console.WriteLine("[Type '1' to view the daily menu again, '2' to make a menu order, '3' to view your current order, '4' to checkout, or 'x' to quit]");
      string choice = Console.ReadLine();
      if (choice == "1")
      {
        PrintDeals();
        CustomersChoice();
      }
      else if (choice == "2")
      {
        PlaceOrder();
        CustomersChoice();
      }
      else if (choice == "3")
      {
        PrintOrder();
        CustomersChoice();
      }
      else if (choice == "4")
      {
        Checkout();
        if (ContinueOrExit())
        {
          CustomersChoice();
        }
      }
      else if (choice == "x" || choice == "X")
      {
        if (ContinueOrExit())
        {
          CustomersChoice();
        }
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