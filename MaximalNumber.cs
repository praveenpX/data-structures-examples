using System; 
public class Test 
{ 
   public static void Main() 
   { 
       int length = Convert.ToInt32(Console.ReadLine());
       string input = Console.ReadLine();
       
       MaximalNumber(length, input);
   } 
   
   public static void MaximalNumber(int n, string s)
   {
       Char[] sChars = s.ToCharArray();
       
       Char temp;
       
       for(int i =0; i < n; i++)
       {
           for(int j = i+1; j < n; j++)
           {
               if(sChars[i] < sChars[j])
               {
                   temp = sChars[i];
                   sChars[i] = sChars[j];
                   sChars[j] = temp;
               }
           }
       }
       
       for(int k = 0; k < n; k++)
       {
           Console.Write(sChars[k]);
       }
       
   }
}
