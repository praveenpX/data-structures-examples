public sealed class Singleton
{
    private static readonly Singleton Instance = new Singleton();
    
    private Singleton()
    {
    
    }
    
    static Singleton()
    {
    }
    
    public static Singleton GetInstance()
    {
        get {
            return Instance;
        
        }
    }
}
