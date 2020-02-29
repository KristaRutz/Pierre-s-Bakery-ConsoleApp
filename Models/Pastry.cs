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

    public Pastry(int amount) : base (amount)
    {
  
    }
  }
}