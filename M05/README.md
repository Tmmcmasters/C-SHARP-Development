------>EXERCISE 7-3<------

Create an application named ConvertMilesToKilometers whose Main() method prompts a user for a number of miles, passes the value to a method that converts the value to kilometers, and then returns the value to the Main() method where it is displayed.

A mile is 1.60934 kilometers.

------>EXERCISE 7-9<------

Create a program named FlexibleArrayMethod that declares at least three integer arrays of different sizes. In turn, pass each array to a method named DisplayAndSum that displays all the integers in each array and their sum.

------>EXERCISE 8-3<------

Create a program named Auction that allows a user to enter an amount bid on an online auction item. Include three overloaded methods that accept an int, double, or string bid. Each method should display the bid and indicate whether it is over the minimum acceptable bid of $10.

If the bid is greater than or equal to $10, display Bid accepted.

If the bid is less than $10, display Bid not high enough.

If the bid is a string, accept it only if one of the following is true:

It is numeric and preceded with a dollar sign.
It is numeric and followed by the word dollars.
Otherwise, display a message that says Bid was not in correct format.

------>EXERCISE 8-4<------

Create a program named TipCalculation that includes two overloaded methods named DisplayTipInfo.

One should accept a meal price and a tip as doubles (for example, 30.00 and 0.20, where 0.20 represents a 20 percent tip).

The other should accept a meal price as a double and a tip amount as an integer (for example, 30.00 and 5, where 5 represents a $5 tip).

Each method displays the meal price, the tip as a percentage of the meal price, the tip in dollars, and the total of the meal plus the tip. Include a Main() method that demonstrates each method.

For example if the input meal price is 30.00 and the tip is 0.20, the output should be:

Meal price: $30.00. Tip percent: 0.20
Tip in dollars: $6.00.  Total bill $36.00
In order to prepend the $ to currency values, the program will need to use the CultureInfo.GetCultureInfo method. In order to do this, include the statement using System.Globalization; at the top of your program and format the output statements as follows: WriteLine("This is an example: {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));