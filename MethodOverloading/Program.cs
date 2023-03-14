namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        /*public static string Add(int num1, int num2, bool istrue)
        {
            var sum = 0;
            var response = "";
            if (istrue)
            {
                sum = num1 + num2;
                if (sum == 1)
                {
                    response = $"{sum} dollar.";
                }
                else
                {
                    response = $"{sum} dollars.";
                }
            }
            return response;
        
         Now create an overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.

You must also account for the appropriate grammar of the string - so it can’t be “1 dollars
*/
        public static string add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;
            
            if (isTrue)
            {
                if (sum == 1)
                {
                    return $"{sum} dollar.";
                }
                else
                {
                   return $"{sum} dollars.";
                }
               
            }
        }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
