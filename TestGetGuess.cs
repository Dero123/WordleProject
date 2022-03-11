using System;
using System.IO;


namespace WordleProject
{

    class TestGetGuess
    {
        public static bool RunTest()
        {
        // What inputs should your methods accept?
        // 5 letter words 

        // What inputs should your methods not accept?
        // Words that aren't 5 letters long.

        // What outputs should your methods produce?
        // The users guess or an error message if the word isn't 5 letters long.

        // What are weird inputs that are technically possible?
        //  Non letter inputs

            Console.WriteLine("You should receive a message asking you to enter a 5 letter word. Try an invalid option by typing 'frui t'. This will result in error message saying the word is invalid.");
            Console.WriteLine("After receiving the error message you should type in 'Fruit'. This should not produce an error.");
            string result = Program.GetGuess("Apple");
            string expected = "Fruit";

            if (result != expected)
            {
                Console.Error.WriteLine($"Expected the result to be {expected} but was {result}.");
                return false;
            }

            Console.WriteLine("You should receive a message asking you to enter a 5 letter word. Try an invalid option by typing 'Dogs'. This will result in error message saying the word is invalid.");
            Console.WriteLine("After receiving the error message you should type in 'Apple'. This should not produce an error.");
            result = Program.GetGuess("Anime");
            expected = "Apple";

            if (result != expected)
            {
                Console.Error.WriteLine($"Expected the result to be {expected} but was {result}.");
                return false;
            }

            Console.WriteLine("You should receive a message asking you to enter a 5 letter word. Try an invalid option by typing 'Awesome'. This will result in error message saying the word is invalid.");
            Console.WriteLine("After receiving the error message you should type in 'Manga'. This should not produce an error.");
            result = Program.GetGuess("Anime");
            expected = "Manga";

            if (result != expected)
            {
                Console.Error.WriteLine($"Expected the result to be {expected} but was {result}.");
                return false;
            }




            return true;
        }
    }
}