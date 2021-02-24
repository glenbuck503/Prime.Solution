using System;


namespace PrimeNumber.Models
{
  public class Calculator
  {
    public bool NumberSifter(int number)
    {
      for (int index = 2; index < number; index++)
      {
        if (number % index == 0)
        {
          return false;
        }
      }
      return true;
    }
  }
}
