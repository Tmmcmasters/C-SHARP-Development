using static System.Console;
class InchesToCentimeters
{
   static void Main()
   {
     const double centInInch = 2.54;
     double inputInches = 3;
     double solutionBruh = centInInch*inputInches;     
     WriteLine("{0} inches is {1} centimeters", inputInches, solutionBruh);
   }
}
