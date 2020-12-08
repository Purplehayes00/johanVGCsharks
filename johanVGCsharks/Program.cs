using System;
using System.Collections.Generic;

namespace johanVGCsharks
{
    //Klasser
    class Person
    {
        private string firstname;
        private string lastname;
        public Person()
        {

        }

        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {

                firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }

        }

    }
    class Medlem : Person
    {
        private string civilstånd;
        private string födelsedag;
        private string boende;
        private string ålder;
        private string hobby;
        private string favoritGodis;
        private string utbildning;
        private string favoritÅrstid;
        private string favoritMat;
        private string favoritDjur;
        public Medlem()
        {

        }
        //Fält om medlemmar
        public Medlem(string civilstånd, string födelsedag, string boende, string ålder, string hobby, string favoritGodis, string utbildning, string favoritÅrstid, string favoritMat, string favoritDjur)
        {
            this.civilstånd = civilstånd;
            this.födelsedag = födelsedag;
            this.boende = boende;
            this.ålder = ålder;
            this.hobby = hobby;
            this.favoritGodis = favoritGodis;
            this.utbildning = utbildning;
            this.favoritÅrstid = favoritÅrstid;
            this.favoritMat = favoritMat;
            this.favoritDjur = favoritDjur;

        }
        //Properties för Medlemmar med info om dem själva
     
        public string CivilStånd { get { return civilstånd; } set { civilstånd = value; } }
        public string FödelseDag { get { return födelsedag; } set { födelsedag = value; } }
        public string Boende { get { return boende; } set { boende= value; } }
        public string Ålder { get { return ålder; } set { ålder= value; } }
        public string Hobby { get { return hobby; } set { hobby = value; } }
        public string FavoritGodis { get { return favoritGodis; } set { favoritGodis = value; } }
        public string Utbildning { get { return utbildning; } set { utbildning = value; } }
        public string FavoritÅrstid { get { return favoritÅrstid; } set { favoritÅrstid = value; } }
        public string FavoritMat { get { return favoritMat; } set { favoritMat = value; } }
        public string FavoritDjur { get { return favoritDjur; } set { favoritDjur = value; } }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till inlämningsuppgift2! \n" +
                 "Skriv vilken grupp du tillhör: ");

            //Metod för inloggning
            inloggning();
            //Metod för programmet om inloggningen lyckas
            programm();




        }
        //Metoden för inloggningen
        private static void inloggning()
        {
            bool rätt = true;
            while (rätt)
            {
                string fras = Console.ReadLine();
                if (fras == "CSharks" || fras == "csharks" || fras == "cSharks" || fras == "CSHARKS")
                {
                    Console.WriteLine("Välkommen Cshark-Medlemm");
                    break;
                }
                else
                {
                    Console.WriteLine("Tyvärr fel svar!");
                }
            }
        }
        //Metoden för programmet
        private static void programm()
        {
            //Medlemmar i Klassen
            Person Tove = new Person("Tove", "Seger");
            Person Oskar = new Person("Oskar", "Kling");
            Person Elias = new Person("Elias", "Hjelm");
            Person Viktor = new Person("Viktor", "Salmberg");
            Person Johan = new Person("Johan", "Rohdin");
            Person Christopher = new Person("Christopher", "Brizet");
            Person Robert = new Person("Robert", "Bunjaku");
            Person Fisnik = new Person("Fisknik", "Balija");
            //Lista med inmatade Medlemmar
            List<Person> listOfPersoner = new List<Person>() { Tove, Oskar, Elias, Viktor, Johan, Christopher, Robert, Fisnik };


            bool forsätta = true;

            while (forsätta)

            {


                Console.WriteLine("Vad vill du göra? \n 1. Skriv ut alla namn i gruppen \n 2. Skriv ut detaljer om gruppmedlemmar \n 3. Skriv ut driv till programmering   \n 4. Ta bort medlem från gruppen  \n 5. Avsluta");
                string ChoiceOfAction = Console.ReadLine();
                int Action = Convert.ToInt32(ChoiceOfAction);
                if (Action == 1)
                {

                    foreach (var person in listOfPersoner)
                    {
                        Console.WriteLine($"{person.FirstName} {person.LastName}");
                    }
                }
               else if (Action == 2)
                {

                }
               else if (Action == 3)
                {

                }
               else if (Action == 4)
                {
                    break;
                }
                else if (Action == 5)
                {
                    forsätta = Avsluta();
                }

            }
            //Metod för att avsluta programmet
            static bool Avsluta()
            {
                Console.WriteLine("Du valde att avsluta, tja!");
                return false;
            }
        }
    }
}
