using System;
using System.Collections.Generic;

namespace johanVGCsharks
{
    
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
            this.lastname= lastname;
        }
        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                
                firstname= value;
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

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till inlämningsuppgift2! \n" +
                 "Skriv vilken grupp du tillhör: ");
            inloggning();
            programm();
           

            Person JohanRohdin = new Person("Johan", "Rohdin");
            //List<Person> listOfPersoner = new List<Person>() { JohanRohdin };

            Console.WriteLine($"{JohanRohdin.LastName } is of the type {JohanRohdin.FirstName}");

        }

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
        private static void programm()
        {
            Person Tove= new Person("Tove", "Seger");
            Person Oskar = new Person("Oskar", "Kling");
            Person Elias = new Person("Elias", "Hjelm");
            Person Viktor = new Person("Viktor", "Salmberg");
            Person Johan = new Person("Johan", "Rohdin");
            Person Christopher = new Person("Christopher", "Brizet");
            Person Robert = new Person("Robert", "Bunjaku");
            Person Fisnik= new Person("Fisknik", "Balija");
            List<Person> listOfPersoner = new List<Person>() { Tove, Oskar, Elias, Viktor, Johan, Christopher, Robert, Fisnik };

            foreach (Person skurk in listOfPersoner)
            {
                Console.WriteLine($"{skurk.FirstName} {skurk.LastName}");
            }
        }
        
        static bool Avsluta()
        {
            Console.WriteLine("Du valde att avsluta, tja!");
            return false;
        }
    }
    }
