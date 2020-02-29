using System;

namespace Products
{
  public class Pastry : BakedGood
  {
    public int UnitPrice { get; set; } = 2;
    public int DealMultiplier { get; set; } = 3;
    public int MultiplierDiscount { get; set; } = 1;
    public static string CategorySingular { get; set; } = "pastry";
    public static string CategoryPlural { get; set; } = "pastries";
    //public int Inventory;

    public Pastry(int amount) : base (amount)
    {
      //Inventory = amount;
    }

    // public int OrderPastry(int pastries)
    // {
    //   if (Inventory >= pastries)
    //   {
    //     Inventory -= pastries;
    //     Console.WriteLine($"You have successfully ordered ({pastries}) pastries.");
    //     return pastries;
    //   }
    //   else
    //   {
    //     int purchased = Inventory;
    //     Inventory = 0;
    //     Console.WriteLine($"You have attempted to buy more pastries than are currently in stock. We let you add ({purchased}) pastries to your order.");
    //     return purchased;
    //   }
    // }

    // public int Remove(int pastries)
    // {
    //   Inventory += pastries;
    //   Console.WriteLine($"You have successfully removed ({pastries}) pastries from your order.");
    //   return pastries;
    // }

    // public static int GetCost(int amount)
    // {
    //   int remainder = amount % 3;
    //   int subtotal = (remainder * Price) + (amount-remainder)/3*(Price*3-1);
    //   return subtotal;
    // }
  }
}