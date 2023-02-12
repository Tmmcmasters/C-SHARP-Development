using System;
using static System.Console;
using System.Globalization;
class ResortPrices
{
   static void Main()
   {
      // Write your main here
      WriteLine("Enter the number of days you are staying >>");
      string nightsStaying = ReadLine();
      if (int.Parse(nightsStaying) >= 8) {
        WriteLine("Price per night is {0:C}", 145,CultureInfo.GetCultureInfo("en-US"));
        WriteLine("Total for {0} night(s) is ${1:C}", nightsStaying, int.Parse(nightsStaying) * 145, CultureInfo.GetCultureInfo("en-US"));
      } else if (int.Parse(nightsStaying) >= 5) {
        WriteLine("Price per night is {0:C}", 160,CultureInfo.GetCultureInfo("en-US"));
        WriteLine("Total for {0} night(s) is ${1:C}", nightsStaying, int.Parse(nightsStaying) * 160, CultureInfo.GetCultureInfo("en-US"));
      } else if (int.Parse(nightsStaying) >= 3) {
        WriteLine("Price per night is {0:C}", 180,CultureInfo.GetCultureInfo("en-US"));
        WriteLine("Total for {0} night(s) is ${1:C}", nightsStaying, int.Parse(nightsStaying) * 180, CultureInfo.GetCultureInfo("en-US"));
   } else {
     WriteLine("Price per night is {0:C}", 200,CultureInfo.GetCultureInfo("en-US"));
        WriteLine("Total for {0} night(s) is ${1:C}", nightsStaying, int.Parse(nightsStaying) * 200, CultureInfo.GetCultureInfo("en-US"));
   }
}
}
