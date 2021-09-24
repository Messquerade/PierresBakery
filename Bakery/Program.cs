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
          }  else if (loavesNumber > 100)
          {
            Console.WriteLine("To make an extra large order, please email pierre@pierrebakery.com");
            return -1;
          } else
          {
            Console.WriteLine("Please enter a positive whole number of how many loaves of bread you wish to buy (example: 0, 1, 15) or q to quit");
            return BreadOrder();
          }
        } else
        {
            Console.WriteLine("Please enter a positive whole number of how many loaves of bread you wish to buy (example: 0, 1, 15 etc.) or q to quit");
            return BreadOrder();
        }
      } else if (breadResponse == "n")
      {
        return 0;
      } else
      {
        Console.WriteLine("Please enter y for yes, n for no, or q to quit");
        return BreadOrder();
      }
    }

    public static int PastryOrder()
    {
      Console.WriteLine("Would you like to order any pastries? [y/n]");
      string pastryResponse = Console.ReadLine().ToLower();
      if (pastryResponse == "q")
      {
        return -1;
      } else if (pastryResponse == "y")
      {
        Console.WriteLine("Please enter the number of pastries you wish to order:");
        string stringPastriesNumber = Console.ReadLine();
        int pastriesNumber;
        if (stringPastriesNumber.ToLower() == "q")
        {
          return -1;
        } else if (int.TryParse(stringPastriesNumber, out pastriesNumber))
        {
          if (pastriesNumber <= 100 && pastriesNumber >= 0)
          {
            Pastry userPastryOrder = new Pastry(pastriesNumber);
            return userPastryOrder.GetPastryCost();
          }  else if (pastriesNumber > 100)
          {
            Console.WriteLine("To make an extra large order, please email pierre@pierrebakery.com");
            return -1;
          } else
          {
            Console.WriteLine("Please enter a positive whole number of how many pastries you wish to buy (example: 0, 1, 15) or q to quit");
            return PastryOrder();
          }
        } else
        {
            Console.WriteLine("Please enter a positive whole number of how many pastries you wish to buy (example: 0, 1, 15 etc.) or q to quit");
            return PastryOrder();
        }
      } else if (pastryResponse == "n")
      {
        return 0;
      } else
      {
        Console.WriteLine("Please enter y for yes, n for no, or q to quit");
        return PastryOrder();
      }
    }

    public static void Main()
    {
      bool quit = false;
      Console.WriteLine("Welcome to Pierre's Bakery! We offer a fresh selection of bread and pastries baked in house daily. Enter q at anytime to quit.");
      Console.WriteLine("Bread costs $5.00 per loaf. Now offering our special deal: every third loaf is free!");
      Console.WriteLine("Pastries cost $2.00 each. Now offering our special deal: every third pastry is half off!");
      Console.WriteLine("For orders over 100 baked goods, please email pierre@pierrebakery.com");
      int breadCost = BreadOrder();
      Console.WriteLine("The total cost of your bread order is $" + breadCost + ".00");
      int pastryCost = PastryOrder();
      Console.WriteLine("The total cost of your pastry order is $" + pastryCost + ".00");
      int totalCost = breadCost + pastryCost;
      Console.WriteLine("The total cost of your bakery order is $" + totalCost + ".00");
      Console.WriteLine("To Confirm your order enter y, to change it enter n");
      string confrimResponse = Console.ReadLine().ToLower();
      if (confrimResponse == "y")
      {
        Console.WriteLine("Thank you. Your order has been submitted. Please come again!");
      } else if (confrimResponse == "n")
      {
        Main();
      } else
      {
        Console.WriteLine("Your order has been cancelled. Please come again!");
      }
    }
  }
}