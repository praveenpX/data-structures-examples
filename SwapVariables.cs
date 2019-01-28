public class Program
{
    public static Main(string[] args)
    {
        SwapVariables(2, 5);
        SwapVariables(10, 20);
    }
    
    public static void SwapVariables(int x, int y)
    {
        x = x + y;
        y = x - y;
        x = x - y;
        
        Console.WriteLine("x=" + x);
        Console.WriteLine("y=" + y);
    }
}
