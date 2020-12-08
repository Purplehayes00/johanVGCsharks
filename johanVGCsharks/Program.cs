using System;

namespace johanVGCsharks
{
    
    class person
    {

    }
    class medlem
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till inlämningsuppgift2! \n" +
                 "Skriv vilken grupp du tillhör: ");
            inloggning();

        }

        private static void inloggning()
        {
            string fras = Console.ReadLine();
            while (fras == "CSharks" || fras == "csharks" || fras == "cSharks" || fras == "CSHARKS")
            {
                Console.WriteLine("Vad vill du göra? \n 1. Skriv ut alla namn i gruppen \n 2. Skriv ut detaljer om gruppmedlemmar \n 3. Skriv ut driv till programmering   \n 4. Ta bort medlem från gruppen ");
                int svar = Convert.ToInt32(Console.Read());
                if (svar == 1)
                {

                }
                else if (svar == 2)
                {





                }

                else if (svar == 3)
                {

                }
                else if (svar == 4)
                {

                }
            }
        }
    }
