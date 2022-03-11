using System;
using System.IO;


namespace WordleProject
{

    class TestDisplayInfo
    {
        public static bool RunTest()
        {

        // What inputs should your methods accept?
        //  The method should accept the users guess and the correct answer.

        // What inputs should your methods not accept?
        // N/A

        // What outputs should your methods produce?
        // Iterate through each character of the users guess with apropiate colors applied. 

        // What are weird inputs that are technically possible?
        // N/A
        Console.Write("You should see Fruit in all red except 'i' should be yellow: ");
        Program.DisplayInfo("Fruit", "Anime");

        Console.Write("You should see Dog!s in all red: ");
        Program.DisplayInfo("Dog!s", "Anime");

        Console.Write("You should see Apple in all green: ");
        Program.DisplayInfo("Apple","Apple");

            return true;
        }
    }
}