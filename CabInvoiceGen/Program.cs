class Program
{
    static void Main()
    {
        Console.WriteLine("hii");
    }
}
public class CabInvoice
{
    static double costPerKM = 10;
    static double costPerMin = 10;
    static double MinFare = 5;
    public double TotalFare(double distance, int time)
    {
        double totval = (distance * costPerKM) + (time * costPerMin);
        return Math.Max(totval, MinFare);
    }
}
