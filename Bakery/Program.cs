using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static int BreadOrder()
    {
      Console.WriteLine("Would you like to order any bread? [y/n]");
      string breadResponse = Console.ReadLine().ToLower();
      if (breadResponse == "q")
      {
        return -1;
      } else if (breadResponse == "y")
      {
        Console.WriteLine("Please enter the number of loaves of bread you wish to order:");
        string stringLoavesNumber = Console.ReadLine();
        int loavesNumber;
        if (stringLoavesNumber.ToLower() == "q")
        {
          return -1;
        } else if (int.TryParse(stringLoavesNumber, out loavesNumber))
        {
          if (loavesNumber <= 100 && loavesNumber >= 0)
          {
            Bread userBreadOrder = new Bread(loavesNumber);
            return userBreadOrder.GetBreadCost();
          } else if (loavesNumber < 0)
          {
            Console.WriteLine("To make an extra large order, please email pierre@pierrebakery.com");
            return -1;
          } else
          {
            Console.WriteLine("Please enter a positive whole number of how many loaves of bread you wish to buy (example: 0, 1, 15) or q to quit");
            return -2;
          }
        } else
        {
          return -1;
        }
      } else
      {
        return -1;
      }
    }

    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! We offer a fresh selection of bread and pastries baked in house daily. Enter q at anytime to quit.");
      Console.WriteLine("Bread costs $5.00 per loaf. Now offering our special deal: every third loaf is free!");
      Console.WriteLine("Pastries cost $2.00 each. Now offering our special deal: every third pastry is half off!");
      int BreadCost = BreadOrder();
      Console.WriteLine(BreadCost);


    }
  }
}