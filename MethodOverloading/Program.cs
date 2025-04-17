namespace MethodOverloading
{
    public class Program
    {
        public static int add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static decimal Add(decimal numOne, decimal numTwo) //I overloaded this method with the int method above it.
        {
            return numOne + numTwo;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(decimal.Add(2, 2)); //The Console.WriteLine knows which method to run based on the numbers I type inside the parameters (2.5m or 2).
            Console.WriteLine(Add(0, 1, true));
        }

        public static string Add(int numOne, int numTwo, bool isCurrency)
        {
            var sum = numOne + numTwo;

            if (isCurrency && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCurrency && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        } //This lesson was awesome, but I will have to come back and redo this one to cement it into my brain.
    }
}
