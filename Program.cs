using System;

namespace WordleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return;
            }
        }

        public static void TestAll()
        {
            bool testDisplayCharInfo = TestDisplayCharInfo.RunTest();
            Console.WriteLine($"Test DisplayCharInfo(char guess, int pos, string correct): {testDisplayCharInfo}");

            bool testDisplayInfo = TestDisplayInfo.RunTest();
            Console.WriteLine($"Test DisplayInfo(string guess, string correct): {testDisplayInfo}");

            bool testGetGuess = TestGetGuess.RunTest();
            Console.WriteLine($"Test GetGuess(string correctWord): {testGetGuess}");
        }

        /// <summary>
        /// Gets a random word from a file then returns the randomly selected word.
        /// </summary>
        /// <returns></returns>
        public static string GetRandomWord()
        {

            // 1. Load a filed called `words.txt`
            // 2. Store each line as a separate word in a list named `words`
            // 3. Generate a random number between 0 and `words.Count` and store the result in
            //    a variable called `ix`
            // 4. Return the word at position `ix`. (e.g. `words[ix]`)
            return null;
        }

        /// <summary>
        /// Asks the user to make a guess, reads the guess, returns the users response
        /// or displays an error message and asks the user to make another guess if the first
        /// guess is not the correct length.
        /// </summary>
        /// <param name="correctWord"></param>
        /// <returns></returns>
        public static string GetGuess(string correctWord)
        {
            // 1.Prompt the user to make a guess
            // 2.Read input from the keyboard and store the results in a variable named guess
            // 3.If guess is the correct length(the guess and random word should be the same length), return the guess.
            // 4.Otherwise, display an error message and ask them to make another guess.

            // TODO(jcollard 2022-03-04): This method will be very similar to the GetGuess method you wrote in the
            // Console guessing game. I would look there as an example.

            return null;
        }
        /// <summary>
        /// Validates that te guess and correct word are the same length, throws an exception if not,
        /// and if they match iterate through each character.
        /// </summary>
        /// <param name="guess"></param>
        /// <param name="correct"></param>
        public static void DisplayInfo(string guess, string correct)
        {
            // 1. Validate that the guess and correct word are the same length
            // 2. If the lengths do not match, throw an exception
            // 3. If they match, iterate through each character:
            // - Use the DisplayCharInfo method to determine what color to print the character


            if (guess.Length != correct.Length)
            {
                throw new Exception($"Expected {guess} and {correct} to have the same length.");
            }
            else
            {


                int ix = 0;


                while (ix < correct.Length)
                {
                    char guessChar = guess[ix];
                    char correctChar = correct[ix];
                    Program.DisplayCharInfo(guessChar, ix, correct);
                    ix++;
                }
                Console.WriteLine();

            }

        }

        /// <summary>
        /// If the guess is in the correct position, select the color green. If the guess
        /// is not correct but in the right position, return yellow. The code will select 
        /// red otherwise. The code displays the guess then resets the color back to white before
        /// returning.
        /// </summary>
        /// <param name="guess"></param>
        /// <param name="pos"></param>
        /// <param name="correct"></param>
        public static void DisplayCharInfo(char guess, int pos, string correct)
        {
            // 1. If the guess is in the correct position, select the color green.
            // 2. If the guess is in the correct word but not correct position, select yellow.
            // 3. If the guess is not in the correct word, select red.
            // 4. Display the guess
            // 5. Reset the color back to white before returning

            if (guess == correct[pos])
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (correct.Contains(guess))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write($"{guess}");
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}
