using System;

namespace Products
{
  public abstract class BakedGood
  {
    public virtual int UnitPrice { get; set; } = 1;
    public int DealMultiplier { get; set; } = 3;
    public virtual int MultiplierDiscount { get; set; } = 0;
    public virtual string CategorySingular { get; set; }
    public virtual string CategoryPlural { get; set; }
    public int Inventory;

    public BakedGood(int amount)
    {
      Inventory = amount;
    }

    public virtual int Order(int amount)
    {
      if (Inventory >= amount)
      {
        Inventory -= amount;
        Console.WriteLine($"You have successfully ordered ({amount}) {CategoryPlural}.");
        return amount;
      }
      else
      {
        int purchased = Inventory;
        Inventory = 0;
        Console.WriteLine($"You have attempted to buy more {CategoryPlural} than are currently in stock. We let you add ({purchased}) {CategoryPlural} to your order.");
        return purchased;
      }
    }

    public int Remove(int amount)
    {
      Inventory += amount;
      Console.WriteLine($"You have successfully removed ({amount}) {CategoryPlural} from your order.");
      return amount;
    }

    public int GetCost(int amount)
    {
      int nonDiscounted = amount % DealMultiplier;
      int discounted = (amount - nonDiscounted);
      int instancesOfDeal = (discounted/DealMultiplier);
      int subtotal = (amount * UnitPrice) - (instancesOfDeal * MultiplierDiscount);
      return subtotal;
    }
  }
}