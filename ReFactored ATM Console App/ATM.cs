using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFactored_ATM_Console_App
{
    internal class ATM
    {
        public virtual void Start()
        {
            startOver:
            Console.WriteLine("Good day! Welcome to GT Bank");
            Console.WriteLine("Please enter a language of your choice\n 'E' for English,\n 'P' for Pidgin \n 'I' for igbo");
            string chosenLanguage = Console.ReadLine().ToUpper();

            Igbo igbo = new Igbo();

            English english = new English();

            Pidgin pidgin = new Pidgin();

            switch (chosenLanguage)
            {
                case "E":
                    english.OperationInEnglish();
                    break;
                case "P":
                    pidgin.OperationInPidgin();
                    break;
                case "I":
                    igbo.OperationInIgbo();
                    break;
                default:
                    Console.WriteLine("Invalid selection, try again\n");
                    break;

            }
                goto startOver;
        }
    }
}
