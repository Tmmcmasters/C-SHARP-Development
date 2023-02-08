using System;
using static System.Console;
class FahrenheitToCelsius
{
   static void Main()
   {
     double fToC;
     string userInput;
     double convertedNumber;
     WriteLine("Please enter a temperature in Fahrenheit >>");
     userInput = ReadLine();
     convertedNumber = Convert.ToDouble(userInput);
     fToC = (convertedNumber - 32) * (5.0/9.0);
     WriteLine("{0} F is {1} C", convertedNumber.ToString("N1"), Math.Round(fToC, 1));
   }
}
