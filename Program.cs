namespace Deliverable_1_Mohacsi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution (1): Hello, World!");
            Console.WriteLine(" ");

            string mystring = "Hello, World!";
            Console.WriteLine("Solution (2): " + mystring);
            Console.WriteLine(" ");

            Console.WriteLine("Enter a user's name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("The user's name is: " + userName);
            Console.WriteLine(" ");

            Console.WriteLine("Enter the user's age: ");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("The user's age is: " + userAge);
        }
    }
}