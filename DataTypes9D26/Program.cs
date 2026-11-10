namespace DataTypes9D26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables are created with
            // data type identifier (= value);
            // integer
            int num1;
            num1 = 42;
            Console.WriteLine(num1);
            int num2 = 8;
            Console.WriteLine(num2);

            // Real
            double decimalValue = 3.147;
            double decVal = 1;
            Console.WriteLine(decVal);

            // Boolean
            bool sunny = true;
            Console.WriteLine(sunny);

            // Character
            char letter = 'A';
            Console.WriteLine(letter);
            char otherChar = '@';

            // String
            string myString = "This is a a string";
      
            Console.WriteLine(myString);
            myString = "";

            Console.WriteLine();
            // User Input
            Console.Write("Enter your name: ");
            string myName = Console.ReadLine();
            Console.WriteLine(myName);

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your age: ");
            double decAge = Convert.ToDouble(Console.ReadLine());

            Console.Write("Is it raining (true/false): ");
            bool rain = Convert.ToBoolean(Console.ReadLine());

            Console.Write("What is the symbol for email address: ");
            char email = Convert.ToChar(Console.ReadLine());

            // Constant
            const int numSquares = 64; // constant data type identifier = value



        }
    }
}
