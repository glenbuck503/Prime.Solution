using System;


namespace PrimeNumber.Models
{
  public class Calculator
  {
    public bool NumberSifter(int number)
    {
      if(number%2==0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }

}
