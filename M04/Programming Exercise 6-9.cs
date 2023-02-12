using System;
using static System.Console;
using System.Globalization;
class HomeSales
{
   static void Main()
  {
  char letter;
  string inputString;
  double sale, grandTotal = 0;
  string[] salespersons = {"Danielle", "Edward", "Francis"};
  char[] initials = {'D', 'E', 'F'};
  double[] sales = new double[3];
  int index = 0;
    Write("Enter a salesperson initial >> ");
  inputString = ReadLine();
  letter = Convert.ToChar(inputString);
  while(letter != 'Z' && letter != 'z')
  {
     index = Array.IndexOf(initials, char.ToUpper(letter));
     if(index == -1)
     {
         WriteLine("Sorry - invalid salesperson.");
     }
     else
     {
         Write("Enter amount of sale >> ");
         inputString = ReadLine();
         sale = Convert.ToDouble(inputString);
         sales[index] += sale;
         grandTotal += sale;
     }
     Write("Enter next salesperson intital or Z to quit >> ");
     inputString = ReadLine();
     letter = Convert.ToChar(inputString);
  }
  for (int i = 0; i < salespersons.Length; i++)
  {
     WriteLine("{0} sold {1,10}", salespersons[i], sales[i].ToString("C", CultureInfo.GetCultureInfo("en-US")));
  }
  WriteLine("Total sales were {0,10}", grandTotal.ToString("C", CultureInfo.GetCultureInfo("en-US")));
  int maxIndex = Array.IndexOf(sales, Math.Max(sales[0], Math.Max(sales[1], sales[2])));
  WriteLine("{0} sold the most", salespersons[maxIndex]);

  }}
