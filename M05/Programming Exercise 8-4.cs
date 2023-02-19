using System;
using static System.Console;
using System.Globalization;
class TipCalculation
{
   static void Main()
   {
      // Write your main here
      double mealPrice = 30.00;
      int tipAmount = 5;
      double tipPercent = 0.20;
      DisplayTipInfo(mealPrice, tipPercent);
      DisplayTipInfo(mealPrice, tipAmount);
   }

   public static void DisplayTipInfo(double price, double tipRate)
   {
   		CultureInfo culture= CultureInfo.GetCultureInfo("en-US");
        double tipInDollars = price * tipRate;
       double totalBill = price + tipInDollars;
       WriteLine("Meal price: {0}. Tip percent: {1:0.00}", price.ToString("C", culture), tipRate);
       WriteLine("Tip in dollars: {0}.  Total bill {1}", tipInDollars.ToString("C", culture),  totalBill.ToString("C", culture));
   }
   public static void DisplayTipInfo(double price, int tipInDollars)
   {
   		 CultureInfo culture= CultureInfo.GetCultureInfo("en-US");
         double totalBill = price + tipInDollars;
         double tipRate = tipInDollars/price;
         WriteLine("Meal price: {0}. Tip percent: {1:0.00}", price.ToString("C", culture), tipRate);
         WriteLine("Tip in dollars: {0}.  Total bill {1}", tipInDollars.ToString("C", culture),  totalBill.ToString("C", culture));
         
   }
}
