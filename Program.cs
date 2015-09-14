using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enums
{
    public enum userChoices {Write =1, Repeat =2, End =3 }//enums must be declared outside of other classes.

    class Program
    {
        static void Main(string[] args)
        {
            //learn enums and switch statements
            runEnums();
        }

        static void runEnums()
        {
            Console.WriteLine("Choose option. 1 to begin. 2 to repeat this method, 3 to quit");

            int userChoice;
            string userInput;
            userInput = Console.ReadLine();
            userChoice = int.Parse(userInput);
            

            switch (userChoice)
            {
                case (int)userChoices.Write:
                    writeChoice();//run method
                    break;
                case (int)userChoices.Repeat:
                    runEnums();//re-do this choice
                    break;
                case (int)userChoices.End:
                    exitApp();//quits the app
                    break;
                default:
                    exitApp();//quits the app
                    break;
            }

                 
        }

        static void writeChoice()
        {
            Console.WriteLine("You've chosen option 1");
        }

        static void exitApp()
        {
            Environment.Exit(0);
        }
    }
}
