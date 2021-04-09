using System;

namespace P_SimpleMethod_Speak
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            Console.WriteLine("Please enter a type of animal.(dog, cat or lion)");
            answer = Console.ReadLine().ToLower();
            string animalSound = Speak(answer);

            if (answer == "dog" || answer == "cat" ||  answer == "lion")
            {
                Console.WriteLine($"A {answer} makes a {animalSound} sound! Yay!");
            }

            else
            {
                Console.WriteLine("Sorry that animal wasn't found. Goodbye!");
            }

        }
        /// <summary>
        /// Converts the animal into the sound that the animal they make
        /// </summary>
        /// <param name="animal">A string representing an animal</param>
        /// <returns>The sound the animal makes, if the animal isn't found the code will exit.</returns>
        static string Speak(string animal)
        {
            string sound = "";

            if (animal == "dog")
            {
                sound = "woof";
            }
            else if (animal == "cat")
            {
                sound = "meow";
            }
            else if (animal == "lion")
            {
                sound = "rawr";
            }
            return sound;


        }
    }
}
