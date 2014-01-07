using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;

namespace ConsoleMoreArrayListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize variables
            String sUserWord = String.Empty;
            ArrayList oWordsList = new ArrayList();

            //Instruct the user
            Pause("Enter as many words as you wish. \nI will sort them alphabetically.");

            //Ask the user for the first word
            Console.Write("\nEnter your first word: ");
            
            //Obtain the word and store it in a string variable
            sUserWord = Console.ReadLine();

            //While the user continues to enter words
            while (sUserWord != String.Empty)
            {
                oWordsList.Add(sUserWord);
                Console.Write("Enter another word (or press enter to stop): ");
                sUserWord = Console.ReadLine();
            }
            //  Add the entered word into the arraylist
            //  Ask the user for the next word
            //  Obtain that word and store it in the string variable


            //Sort the arraylist [in alphabetical order]
            oWordsList.Sort();

            //Disply the words in the arraylist, one at a time, until finished
            for (Int32 i = 0; i < oWordsList.Count; i++)
            {
                sUserWord = (String)oWordsList[i];
                Console.WriteLine("\n" + sUserWord);
            }

            //Pause code
            Pause("\nProgram will now exit.");
        }

        static void Pause(String sMessage)
        {
            Console.WriteLine(sMessage);
            Console.Write("\nPress the enter key to continue. ");
            Console.ReadLine();
        }
    }
}
