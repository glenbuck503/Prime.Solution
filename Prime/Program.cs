using System;
using PrimeNumber.Models;


namespace PrimeNumber 
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number to see if it's a Prime number or not:");
      string userNumber = Console.ReadLine();
      int userInput = int.Parse(userNumber);

      Calculator number = new Calculator();
      if (number.NumberSifter(userInput) == true)
      {
        Console.WriteLine("This is a Prime number!"); 
      } else 
      {
        Console.WriteLine("This is not a Prime number.");
      }
    }
  }
}