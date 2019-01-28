public class Program
{
    public static Main(string[] args)
    {
        int number = 11;
        
        PrintAllPrimes(number);
    }
    
    public static void PrintAllPrimes(int number)
    {
        for(int i =1; i<number, i++)
        {
            bool isPrime = CheckForPrime(i);
            
            if(isPrime)
                Console.WriteLine(i);
        }
    }
    
    public static void CheckForPrime(int n) 
    {
        if(n < 1)
            return false;
            
        for(int i=2; i <n; i++)
        {
            if(n % i == 0) //is not prime
                return false;
        }
        return true;
    }
}
