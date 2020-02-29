using System;

namespace Products
{
  public class Bread
  {
    public static int Price { get; set; } = 5;
    public static string Category { get; set; } = "bread";
    public bool Sliced { get; set; } = false;
    public int BreadInventory; 

    public Bread(int amount)
    {
      BreadInventory = amount;
    }

    public void Slice()
    {
      Sliced = true;
    }

    public int OrderBread(int loaves)
    {
      if (BreadInventory >= loaves)
      {
        BreadInventory -= loaves;
        Console.WriteLine($"You have successfully ordered ({loaves}) loaves of bread.");
        return loaves;
      }
      else
      {
        int purchased = BreadInventory;
        BreadInventory = 0;
        Console.WriteLine($"You have attempted to buy more bread than is currently in stock. We let you add ({purchased}) loaves of bread to your order.");
        return purchased;
      }
    }

    public int RemoveBread(int loaves)
    {
      BreadInventory += loaves;
      Console.WriteLine($"You have successfully removed ({loaves}) loaves of bread from your order.");
      return loaves;
    }

    public static int GetCost(int amount)
    {
      int remainder = amount % 3;
      int subtotal = ((amount - remainder)*2/3 + remainder) * Price;
      return subtotal;
    }
  }
}