using System;
using BakeryService.Models;

namespace BakeryService
{
  public class Program
  {
    //public static int CustomerDollars = 1000;
    public static void Main()
    {
      Bakery pierres = new Bakery("Pierre's");
      pierres.WelcomeACustomer();
      pierres.CustomersChoice();
    }
  }
}