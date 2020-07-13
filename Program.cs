using System;
using System.Collections.Generic;

namespace Game
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("enter a number between 0-100!");
      string userString = Console.ReadLine();
      int userInt = int.Parse(userString);
      
      List<string> numberList = new List<string> {};

      for (int index = 1; index <= userInt; index ++)
      {
        if (index % 15 == 0)
        {
          numberList.Add("ping-pong");
        }
        else if (index % 3 == 0)
        {
          numberList.Add("ping");
        }
        else if (index % 5 == 0)
        {
          numberList.Add("pong");
        }
        else 
        {
          numberList.Add(index.ToString());
        }
      }

      foreach (string index in numberList) 
      {
        Console.WriteLine(index);
      }
    }
  }
}



