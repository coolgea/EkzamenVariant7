class Program
{
    static void Main()
    {
        Console.WriteLine("Enter X");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Math.Cos(x);
        Console.WriteLine("Result = " + y);
    }
}
