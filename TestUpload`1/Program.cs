namespace TestUpload_1
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I will tell a story, but I need some information.");
            Console.WriteLine("Give a name for main character:");
            string? characterName = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            // Write your code here:
            string? characterProfession = Console.ReadLine();
            Console.WriteLine("Here is the story:");
            string story = string.Format(@"Once upon a time there was a {1} called {0}
On her way to work, {0} often pondered what being {1} meant to them.
When you work as a {1} you meet interesting people.
{0} enjoys their work as {1}, The end.", characterName, characterProfession);
            Console.WriteLine(story);
        }
    }
}