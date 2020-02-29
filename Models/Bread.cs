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

    public Bread(int amount) : base (amount)
    {
    }

    public void Slice()
    {
      Sliced = true;
    }
  }
}