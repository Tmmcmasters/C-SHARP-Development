using static System.Console;
public class FlexibleArrayMethod
{
   static void Main()
   {
     // Write your main here
     int[] arraysOfDifferentSizes = {20,40,2,35};
     DisplayAndSum(arraysOfDifferentSizes);
   }
   public static void DisplayAndSum(int[] arr)
   {
     int sum = 0; 
     //  Write your DisplayAndSum method here.
     for (int i=0;i<arr.Length;i++) {
       Write(arr[i] + ", ");
       sum += arr[i];
     }
     WriteLine($"The total is {sum}");
   }
}
