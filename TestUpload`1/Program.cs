namespace TestUpload_1
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            string days = Console.ReadLine();
            int intDays = Convert.ToInt32(days);
            int hoursInDay = intDays * 24 * 3600;
            Console.WriteLine(hoursInDay);
        }
    }
}