using System;
using System.IO;


namespace WordleProject
{

    class TestDisplayCharInfo
    {
        public static bool RunTest()
        {

        // What inputs should your methods accept?
        // The methods should accept getGuess.

        // What inputs should your methods not accept?
        // N/A

        // What outputs should your methods produce?
        // Displays the guess in color.

        // What are weird inputs that are technically possible?
        // N/A

            Console.Write("You should see 'A' in Green: ");
            Program.DisplayCharInfo('A', 0, "Apple");
            Console.WriteLine();

            Console.Write("You should see 'A' in Yellow: ");
            Program.DisplayCharInfo('A', 3, "Apple");
            Console.WriteLine();

            Console.Write("You should see '!' in red: ");
            Program.DisplayCharInfo('!', 3, "Apple");
            Console.WriteLine();
            
            return false;
        }
    }
}