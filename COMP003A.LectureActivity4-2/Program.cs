// Author: Jason Salinas
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Practice implementing methods in C#
namespace COMP003A.LectureActivity4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        /// <summary> 
        /// Greets the user by name.
        /// </summary

        static void GreetUser()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine(); // Store user input in 'name'
            Console.WriteLine($"Hello, {name}! Welcome to the Methoda Activiy.");
        }
    }
}
