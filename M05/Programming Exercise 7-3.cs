using System;
using static System.Console;
class ConvertMilesToKilometers
{
   static void Main()
   {
    WriteLine("Enter number of miles >>");
    string miles = ReadLine();
    double kilometers = ConvertToKilometers(Convert.ToDouble(miles));
    WriteLine($"{miles} miles is equal to {kilometers} kilometers.");
       }
   public static double ConvertToKilometers(double miles)
   {
     double kilometers = 1.60934*miles;
     return kilometers;
    // Write your ConvertToKilometers() method here.
   }
}
