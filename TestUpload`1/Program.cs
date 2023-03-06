namespace TestUpload_1
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number!");
            string input = Console.ReadLine();
            bool nrInput = Convert.ToBoolean(input);
            Console.WriteLine("You gave: " + nrInput);
        }
    }
}