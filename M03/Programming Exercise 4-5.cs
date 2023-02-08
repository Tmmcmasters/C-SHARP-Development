using System;
using static System.Console;
class CheckDigit
{
   static void Main()
   {
      // Write your main here
      string userInput;
      int convertedInput;
      int convertedFourthDigit = 0;
      WriteLine("Please enter a four digit account number >>");
      userInput = ReadLine();
      convertedInput = Convert.ToInt32(userInput);
      // convertedFourthDigit = Convert.ToInt32(userInput[3] - '0');
      WriteLine(convertedFourthDigit);
      if (userInput.Length > 4 || userInput.Length < 4) {
        WriteLine("Account number invalid - it must have 4 digits");
      } else if ((convertedInput/10) % 7 == Convert.ToInt32(userInput[3] - '0')) {
        WriteLine("The account number is valid");
      } else {
        WriteLine("Invalid");
      }
   }
}
