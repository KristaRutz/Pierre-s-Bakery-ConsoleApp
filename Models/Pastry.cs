using System;

namespace Products
{
  public class Pastry
  {
    public static int Price { get; set; } = 2;
    public static string Category { get; set; } = "pastry";
    public int PastryInventory;

    public Pastry(int amount)
    {
      PastryInventory = amount;
    }

    public int OrderPastry(int pastries)
    {
      if (PastryInventory >= pastries)
      {
        PastryInventory -= pastries;
        Console.WriteLine($"You have successfully ordered ({pastries}) pastries.");
        return pastries;
      }
      else
      {
        int purchased = PastryInventory;
        PastryInventory = 0;
        Console.WriteLine($"You have attempted to buy more pastries than are currently in stock. We let you add ({purchased}) pastries to your order.");
        return purchased;
      }
    }

    public int RemovePastry(int pastries)
    {
      PastryInventory += pastries;
      Console.WriteLine($"You have successfully removed ({pastries}) pastries from your order.");
      return pastries;
    }

    public static int GetCost(int amount)
    {
      int remainder = amount % 3;
      int subtotal = (remainder * Price) + (amount-remainder)/3*(Price*3-1);
      return subtotal;
    }
  }
}