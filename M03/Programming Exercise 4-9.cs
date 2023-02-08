using System;
using static System.Console;
class CheckMonth
{
   static void Main()
   {
      // Write your main here
      string userInput;
      int convertedInput;
      WriteLine("Enter a birth month >>");
      userInput = ReadLine();
      convertedInput = Convert.ToInt32(userInput);
      if (convertedInput > 12 || convertedInput < 1) {
        WriteLine("Invalid month");
      } else {
        WriteLine(convertedInput + " is a valid month");
      }
   }
}
