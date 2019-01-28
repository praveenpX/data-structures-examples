public class Program
{
    public static Main(string[] args)
    {
        int []arr = { 1, 6, 2, 7 }; 
        
        int n = arr.Length; 
        
        Console.WriteLine(FindElementInAnArrayWhereLeftSumIsEqualToRightSum(arr, n)); 
    }
    
    public int FindElementInAnArrayWhereLeftSumIsEqualToRightSum(int[] array, int size)
    {
        int left_sum, right_sum = 0;
        
        //calc right sum from 1
        for(int i = 1; i < size; i++)
        {
            right_sum += array[i];
        }
        
        //check point, left_sum == right_sum
        for(int i =0, j =1, j < size; i++, j++)
        {
            right_sum -= array[j];
            left_sum += array[i];
            
            if(right_sum == left_sum)
            {
                return array[i + 1];
            }
            return -1;
        }
    }
}
