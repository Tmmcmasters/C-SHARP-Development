using System;
using static System.Console;
using System.Globalization;
class HomeSales
{
   static void Main()
   {
      char letter;
      string inputString;
      double sale, dTotal = 0, eTotal = 0, fTotal = 0, grandTotal;
      Write("Enter a salesperson initial >> ");
      inputString = ReadLine();
      letter = Convert.ToChar(inputString);
      while(letter != 'Z' && letter != 'z')
      {
         if(letter != 'd' && letter != 'D' && letter != 'e' && letter != 'E' && letter != 'f' && letter != 'F') {
              WriteLine("Sorry - invalid salesperson.");
          } else {
             Write("Enter amount of sale >> ");
             inputString = ReadLine();
             sale = Convert.ToDouble(inputString);
             if(letter == 'd' || letter == 'D')
                dTotal += sale;
             else if(letter == 'e' || letter == 'E')
                eTotal += sale;
             else 
               fTotal += sale;
          }
         Write("Enter next salesperson intital or Z to quit >> ");
         inputString = ReadLine();
         letter = Convert.ToChar(inputString);
      }
      WriteLine("Danielle sold    {0,10}", dTotal.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Edward sold      {0,10}", eTotal.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Francis sold     {0,10}", fTotal.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      grandTotal = dTotal + eTotal + fTotal;
      WriteLine("Total sales were {0,10}", grandTotal.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      if(dTotal > eTotal && dTotal > fTotal)
         WriteLine("Danielle sold the most");
      else if(eTotal > dTotal && eTotal > fTotal)
         WriteLine("Edward sold the most");
       else if(fTotal > dTotal && fTotal > eTotal)
         WriteLine("Francis sold the most");
       else
           WriteLine("There was a tie");
   }
}