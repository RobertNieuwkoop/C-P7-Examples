namespace TestUpload_1
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a string:");
            string input = Console.ReadLine();
            string stringInput = input;

            Console.WriteLine("Give an integer:");
            input = Console.ReadLine();
            int intInput = Convert.ToInt32(input);

            Console.WriteLine("Give an double:");
            input = Console.ReadLine();
            double doubleInput = Convert.ToDouble(input);

            Console.WriteLine("Give a boolean:");
            input = Console.ReadLine();
            bool boolInput = Convert.ToBoolean(input);

            Console.WriteLine($"Your string: {stringInput} ");
            Console.WriteLine($"your int: {@intInput} ");
            Console.WriteLine($"Your double: {doubleInput} ");
            Console.WriteLine($"Your boolean: {boolInput} ");
        }
    }
}