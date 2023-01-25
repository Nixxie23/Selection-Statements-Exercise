using System.Runtime.CompilerServices;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE ONE
            var r = new Random();
            var favNum = r.Next(0,100);
            Console.WriteLine("Can you guess my favorite number? Guess a number between 0 and 100!");
            var userGuess = int.Parse(Console.ReadLine());
            if (userGuess == favNum) 

            { 
                Console.WriteLine($"{favNum}, you guessed correctly! You're great at this!");
               
            }

            else if (userGuess > favNum && userGuess <= 100) 
            { 
                Console.WriteLine($"{userGuess} isn't the right number! Way to high! Uh-oh!");
            }
             else if (userGuess < favNum && userGuess >= 0)
            {
                Console.WriteLine($"That's too low! {userGuess} isn't right!");
                    }
             else 
            {
                Console.WriteLine($"{userGuess}? That's not in the right number range! 0 to 100 only!");
                    }
            //EXERCISE TWO
            Console.WriteLine("What is your favorite school subject? Please pick from Math, English, Science, PE, or Band.");
            string userFavSub = Console.ReadLine();

            switch (userFavSub)
            {
                case "Math":
                    Console.WriteLine("Math is your favorite? You must be really smart!");
                        break;
                case "English":
                    Console.WriteLine("English is so much fun! I bet you like reading, right?");
                        break;
                case "Science":
                    Console.WriteLine("Science is so interesting! I really like learning about the POWERHOUSE OF THE CELL!");
                    break;
                case "PE":
                    Console.WriteLine("PE? That is such a fun class!");
                        break;
                case "Band":
                    Console.WriteLine("Band was always my favorite too! Especially marching band!");
                        break;
                default:
                    Console.WriteLine("That wasn't one of the choices silly!");
                    break;
                   
            }
        }
    }
}
