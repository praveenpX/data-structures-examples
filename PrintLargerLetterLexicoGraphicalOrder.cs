using System; 
public class Test 
{ 
   public static void Main() 
   { 
       //get length
       int length = Convert.ToInt32(Console.ReadLine());
       
       //get string input
       string input = Console.ReadLine();
       
       PrintLargerLetterLexicoGraphicalOrder(length, input);
       
   } 
   
   public static void PrintLargerLetterLexicoGraphicalOrder(int length, string input)
   {
       Char[] sChars = input.ToCharArray();
       
       int count = 0;
       
       for(int i =0; i <input.Length; i++)
       {
           count = 0;
           
           for(int j = 0; j <input.Length; j++)
           {
              //in order to compare alphabets, get the decimal value of the alphabets and then compare and count  
              int left = Convert.ToInt32(sChars[i]);
               int right = Convert.ToInt32(sChars[j]);
               
               if(left < right)
               {
                   count++;
               }
           }
           Console.Write(count + " ");
       }
   }
}
