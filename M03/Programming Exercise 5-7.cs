using System;
using static System.Console;
class MultiplicationTable
{
   static void Main()
   {
    int userInput = 0;
    WriteLine("Please Enter a number");
    userInput = int.Parse(ReadLine());
    for (int i = 1;i < 11; ++i) {
      WriteLine("{0, 3} x {1, 2} = {2}", i, userInput, i *userInput);
    }
   }
}
