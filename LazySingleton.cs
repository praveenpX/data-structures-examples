public sealed class LazySingleton
{
    private static readonly Lazy<LazySingleton> Instance = new Lazy<LazySingleton>(() => new LazySingleton());
    
    private LazySingleton()
    {
        
    }
    
    public static LazySingleton GetInstance()
    {
        get 
        {
            return Instance.Value;
        }
    }
}
