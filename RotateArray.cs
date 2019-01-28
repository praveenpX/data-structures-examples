public class Program
{
    public static Main(string[] args)
    {
        int[] sample = new int[] {1, 2, 3, 4, 5};

        var result = RotateArray(sample, 0, sample.Length);
    }

    public static int[] RotateArray(int[] array, int start, int end)
    {
        int temp;

        while(start < end)
        {
            temp = array[start];

            array[start] = array[end];
            array[end] = temp;

            start++;
            end--;
        }

        return array;
    }
}
