using System;

namespace Products
{
  public class Bread : BakedGood
  {
    public int Price { get; set; } = 5;
    public int DealMultiplier { get; set; } = 3;
    public int MultiplierDiscount { get; set; } = 5;
    public static string CategorySingular { get; set; } = "loaf of bread";
    public static string CategoryPlural { get; set; } = "loaves of bread";
    public bool Sliced { get; set; } = false;
    //public int Inventory; 

    public Bread(int amount) : base (amount)
    {
      //Inventory = amount;
    }

    public void Slice()
    {
      Sliced = true;
    }

    // public int Order(int loaves)
    // {
    //   if (Inventory >= loaves)
    //   {
    //     Inventory -= loaves;
    //     Console.WriteLine($"You have successfully ordered ({loaves}) loaves of bread.");
    //     return loaves;
    //   }
    //   else
    //   {
    //     int purchased = Inventory;
    //     Inventory = 0;
    //     Console.WriteLine($"You have attempted to buy more bread than is currently in stock. We let you add ({purchased}) loaves of bread to your order.");
    //     return purchased;
    //   }
    // }

    // public int Remove(int loaves)
    // {
    //   Inventory += loaves;
    //   Console.WriteLine($"You have successfully removed ({loaves}) loaves of bread from your order.");
    //   return loaves;
    // }

    // public static int GetCost(int amount)
    // {
    //   int remainder = amount % 3;
    //   int subtotal = ((amount - remainder)*2/3 + remainder) * Price;
    //   return subtotal;
    // }
  }
}