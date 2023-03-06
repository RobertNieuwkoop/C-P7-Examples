namespace TestUpload_1
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number!");
            string input = Console.ReadLine();
            double nrInput = Convert.ToDouble(input);
            Console.WriteLine("You gave: " + nrInput);
        }
    }
}