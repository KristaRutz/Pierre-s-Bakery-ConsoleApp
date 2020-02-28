using System;
using System.Collections.Generic;
using Products;

namespace BakeryService.Models
{
  public class Bakery
  {
    public Bakery()
    {

    }

    public void WelcomeACustomer()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.Write("How can we assist you today? ");
      if (ContinueOrExit())
      {
        Console.WriteLine("Great! Here are today's specials:");
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
        return false;
      }
      else
      {
        return ContinueOrExit();
      }
    }
  }
}