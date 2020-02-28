using System;

namespace Products
{
  public class Bread
  {
    public static int Price { get; set; }
    public static string Category { get; set; } = "bread";
    public bool Sliced = false; 

    public Bread()
    {

    }

    public void Slice()
    {
      // increase the cost of sliced ?
    }
  }
}