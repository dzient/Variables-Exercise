//David Zientara
// 11-15-2022
// Program to declare + initialize a bunch of variables
namespace VariablesExercise
{
    public class Program
    {

        static void Main(string[] args)
        {
            string name = "Ralph"; //Dog's name
            int age = 10; //Dog's age
            char letter = 'a'; //Favorite letter
            bool talk = false; // Can he talk? No
            double yesterday = 1.1; // How much he made yesterday
            decimal today = (decimal)1.2; // How much he made today

            Console.WriteLine($"My dog's name is {name}. He's {age} years old. His favorite letter is {letter}. There are {talk} rumors that he can talk.");
            Console.WriteLine($"He has earned {yesterday} dollars yesterday and {today} dollars today.");
        }
    }
}
