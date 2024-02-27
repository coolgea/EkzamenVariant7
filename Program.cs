class Program
{
    static void Main()
    {
        Console.WriteLine("Enter X");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Math.Cos(x);
        y = y * 2;
        Console.WriteLine("Result = " + y);

    }
}
