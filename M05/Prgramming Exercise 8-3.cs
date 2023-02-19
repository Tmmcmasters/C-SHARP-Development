using static System.Console;

public class Auction
{
    static void Main()
    {
        // Write your main here
        WriteLine("Enter bid amount");
        string bidInput = ReadLine();

        if (int.TryParse(bidInput, out int intValue)) {
            AcceptBid(intValue, 10);
        }
        else if (double.TryParse(bidInput, out double doubleValue)) {
            AcceptBid(doubleValue, 10);
        }
        else if (IsValidBid(bidInput)) {
            double bidAmount = GetBidAmount(bidInput);
            AcceptBid(bidAmount, 10);
        }
        else {
            WriteLine("Bid was not in correct format.");
        }
    }

    public static void AcceptBid(int bid, int min)
    {
        WriteLine($"Bid amount: {bid}");

        if (bid >= min) {
            WriteLine("Bid accepted.");
        }
        else {
            WriteLine("Bid not high enough.");
        }
    }

    public static void AcceptBid(double bid, int min)
    {
        WriteLine($"Bid amount: {bid}");

        if (bid >= min) {
            WriteLine("Bid accepted.");
        }
        else {
            WriteLine("Bid not high enough.");
        }
    }

    public static void AcceptBid(string bid, int min)
    {
        double bidAmount = GetBidAmount(bid);

        if (bidAmount == 0) {
            WriteLine("Bid was not in correct format.");
        }
        else if (bidAmount >= min) {
            WriteLine($"Bid amount: {bidAmount}");
            WriteLine("Bid accepted.");
        }
        else {
            WriteLine($"Bid amount: {bidAmount}");
            WriteLine("Bid not high enough.");
        }
    }

    private static bool IsValidBid(string bid)
    {
        return bid.StartsWith("$") || bid.EndsWith("dollars") || double.TryParse(bid, out _);
    }

    private static double GetBidAmount(string bid)
    {
        if (double.TryParse(bid.Replace("$", ""), out double bidAmount)) {
            return bidAmount;
        }
        else if (bid.EndsWith("dollars") && double.TryParse(bid.Replace("dollars", ""), out bidAmount)) {
            return bidAmount;
        }
        else {
            return 0;
        }
    }
}
