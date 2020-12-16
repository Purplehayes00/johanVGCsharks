using System;
using System.Collections.Generic;
using System.ComponentModel;

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
    //Klassen om strängen om drivet till programmering
    class drivTillProgrammering
    {
        private string driv;

        public drivTillProgrammering()
        {

        }
        public drivTillProgrammering(string driv)
        {
            this.driv = driv;
        }
        public string Driv {get { return driv; }  set { driv = value; } }
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
            Programm();




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
        public static void Programm()
        {
            //Medlemmar i Klassen
            Person Tove = new Person("Tove", "Seger,");
            Person Oskar = new Person("Oskar", "Kling,");
            Person Elias = new Person("Elias", "Hjelm,");
            Person Viktor = new Person("Viktor", "Salmberg,");
            Person Johan = new Person("Johan", "Rohdin,");
            Person Christopher = new Person("Christopher", "Brizet,");
            Person Robert = new Person("Robert", "Bunjaku,");
            Person Fisnik = new Person("Fisknik", "Balija.");

           //Information om medlemmar i klassen
            Medlem ToveS = new Medlem("Gift", "December", "Villa", "28", "Löpning", "Saltlakrits", "Biomedicin(Fysiskträning)", "Sommar", "Vegetarisk", "Hund");
            Medlem OskarK = new Medlem("Sambo", "November", "Lägenhet", "30", "Datorspel", "Kechoklad", "Ekonomi och Software Engineer", "Höst", "Kött gärna biff", "Hund och katt");
            Medlem EliasH = new Medlem("Sambo", "Augusti", "Lägenhet", "22", "Datorspel", "Choklad", "Interatktionsdesigner 0,5 år", "Sommar", "Vegetarisk", "Hund");
            Medlem ViktorS = new Medlem("Singel", "Januari", "Lägenhet", "30", "Spela Gitarr", "Choklad", "Arabiska", "Höst", "Vegetarisk och bacon", "Katt");
            Medlem JohanR = new Medlem("Sambo", "Mars", "Lägenhet", "27", "Poker/Fotboll", "Blandgodis", "Nätverksdrift", "Vinter", "Pasta", "Hund");
            Medlem ChristopherB = new Medlem("Sambo", "September", "Villa", "35", "Gittar, spela och läsa", "Sötlakrits", "Installationstekniker 1 år", "Höst", "Stinky French Cheeses", "Korp");
            Medlem RobertB = new Medlem("Gift", "November", "Lägenhet", "35", "Fiska", "Mjölkchoklad", "IT-Säkerhet", "Sommar", "Pasta", "Hund");
            Medlem FisnikB = new Medlem("Flickvän", "Feburari", "Villa", "32", "Fotboll", "Choklad", "Masterexamen i Geologi", "Sommar", "Allätare, föredrar kött", "Hund");

            //Strängen om driv till programmering om medlemmar i klassen

            
            


            //Lista med inmatade Medlemmar
            List<Person> listOfPersoner = new List<Person>() { Tove, Oskar, Elias, Viktor, Johan, Christopher, Robert, Fisnik };
            List<Medlem> listOfMedlemmar = new List<Medlem>() { ToveS, OskarK, EliasH, ViktorS, JohanR, ChristopherB, RobertB, FisnikB };

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
                    Information(ToveS, OskarK, EliasH, ViktorS, JohanR, ChristopherB, RobertB, FisnikB, listOfPersoner);
                }
                else if (Action == 3)
                {
                    ProgrammeringSträng();
                }
               else if (Action == 4)
                {
                    Remove();
                }
                else if (Action == 5)
                {
                    forsätta = Avsluta();


                }
                

            }
            //Metod för att ta bort medlemmar
             void Remove()
            {
                bool forsätta = true;
                while(forsätta)
                {
                    Console.WriteLine("Vem vill du ta bort ur gruppen?");
                    Console.WriteLine("1. Tove \n 2.Oskar \n 3. Elias \n 4. Viktor \n 5. Johan \n 6. Christopher \n 7. Robert \n 8. Fiznik \n 9. Gå tillbaka");
                    string ChoiceOfAction = Console.ReadLine();
                    int Action = Convert.ToInt32(ChoiceOfAction);
                    if (Action == 1) { listOfPersoner.Remove(Tove); }
                    if (Action == 2) { listOfPersoner.Remove(Oskar); }
                    if (Action == 3) { listOfPersoner.Remove(Elias); }
                    if (Action == 4) { listOfPersoner.Remove(Viktor); }
                    if (Action == 5) { listOfPersoner.Remove(Johan); }
                    if (Action == 6) { listOfPersoner.Remove(Christopher); }
                    if (Action == 7) { listOfPersoner.Remove(Robert); }
                    if (Action == 8) { listOfPersoner.Remove(Fisnik); }
                    if (Action == 9) { break; }
                    else
                    {
                        Console.WriteLine("Fel karaktär");
                    }


                }
                
            }
            //Metod för att avsluta programmet
            static bool Avsluta()
            {
                Console.WriteLine("Du valde att avsluta, hejdå. Välkommen och spela igen när du vill!");
                return false;
            }
        }

        //Metoden med information(Boende/Mat osv.)
        private static void Information(Medlem ToveS, Medlem OskarK, Medlem EliasH, Medlem ViktorS, Medlem JohanR, Medlem ChristopherB, Medlem RobertB, Medlem FisnikB, List<Person> listOfPersoner)
        {
            

            Console.WriteLine("Vem vill du skriva ut information om? \n Skriv deras förnamn så kommer det upp!");
            int count = 1;
            foreach (var person in listOfPersoner)
            {

                Console.WriteLine($" {count} {person.FirstName} {person.LastName}");
                count++;
            }
            string frasTvå = Console.ReadLine();

            bool medlemmar = true;

            while (medlemmar)
            {

                if (frasTvå == "Tove" || frasTvå == "tove" || frasTvå == "tOVE" || frasTvå == "TOVE")
                {

                    Console.WriteLine($"{ToveS.CivilStånd} \n {ToveS.FödelseDag} \n {ToveS.Boende} \n {ToveS.Ålder} \n {ToveS.Hobby} " +
                        $"\n {ToveS.FavoritGodis} \n {ToveS.Utbildning} \n {ToveS.FavoritÅrstid} \n {ToveS.FavoritMat} \n {ToveS.FavoritDjur}");
                    break;

                }
                if (frasTvå == "Oskar" || frasTvå == "OSKAR" || frasTvå == "oskar" || frasTvå == "oSKAR")
                {
                    Console.WriteLine($"{OskarK.CivilStånd} \n {OskarK.FödelseDag} \n {OskarK.Boende} \n {OskarK.Ålder} \n {OskarK.Hobby} " +
                        $"\n {OskarK.FavoritGodis} \n {OskarK.Utbildning} \n {OskarK.FavoritÅrstid} \n {OskarK.FavoritMat} \n {OskarK.FavoritDjur}");
                    break;
                }
                if (frasTvå == "Elias" || frasTvå == "elias" || frasTvå == "ELIAS" || frasTvå == "eLIAS")
                {
                    Console.WriteLine($"{EliasH.CivilStånd} \n {EliasH.FödelseDag} \n {EliasH.Boende} \n {EliasH.Ålder} \n {EliasH.Hobby} " +
                        $"\n {EliasH.FavoritGodis} \n {EliasH.Utbildning} \n {EliasH.FavoritÅrstid} \n {EliasH.FavoritMat} \n {EliasH.FavoritDjur}");
                    break;
                }
                if (frasTvå == "Viktor" || frasTvå == "viktor" || frasTvå == "VIKTOR" || frasTvå == "vIKTOR")
                {
                    Console.WriteLine($"{ViktorS.CivilStånd} \n {ViktorS.FödelseDag} \n {ViktorS.Boende} \n " +
                        $"{ViktorS.Ålder} \n {ViktorS.Hobby} \n {ViktorS.FavoritGodis} \n {ViktorS.Utbildning} \n {ViktorS.FavoritÅrstid} \n {ViktorS.FavoritMat} \n {ViktorS.FavoritDjur}");
                    break;
                }
                if (frasTvå == "Johan" || frasTvå == "johan" || frasTvå == "JOHAN" || frasTvå == "jOHAN")
                {
                    Console.WriteLine($"{JohanR.CivilStånd} \n {JohanR.FödelseDag} \n {JohanR.Boende} \n " +
                        $"{JohanR.Ålder} \n {JohanR.Hobby} \n {JohanR.FavoritGodis} \n {JohanR.Utbildning} \n {JohanR.FavoritÅrstid} \n {JohanR.FavoritMat} \n {JohanR.FavoritDjur}");
                    break;
                }
                if (frasTvå == "Christopher" || frasTvå == "Christoffer" || frasTvå == "CHRISTOPHER" || frasTvå == "cHRISTOPHER")
                {
                    Console.WriteLine($"{ChristopherB.CivilStånd} \n {ChristopherB.FödelseDag} \n {ChristopherB.Boende} \n " +
                        $"{ChristopherB.Ålder} \n {ChristopherB.Hobby} \n {ChristopherB.FavoritGodis} \n {ChristopherB.Utbildning} \n {ChristopherB.FavoritÅrstid} \n" +
                        $" {ChristopherB.FavoritMat} \n {ChristopherB.FavoritDjur}");
                    break;
                }
                if (frasTvå == "Robert" || frasTvå == "robert" || frasTvå == "ROBERT" || frasTvå == "rOBERT")
                {
                    Console.WriteLine($"{RobertB.CivilStånd} \n {RobertB.FödelseDag} \n {RobertB.Boende} \n " +
                        $"{RobertB.Ålder} \n {RobertB.Hobby} \n {RobertB.FavoritGodis} \n {RobertB.Utbildning} \n {RobertB.FavoritÅrstid} \n {RobertB.FavoritMat} \n {RobertB.FavoritDjur}");
                    break;
                }
                if (frasTvå == "Fisnik" || frasTvå == "fISNIK" || frasTvå == "FISNIK" || frasTvå == "fISNIK")
                {
                    Console.WriteLine($"{FisnikB.CivilStånd} \n {FisnikB.FödelseDag} \n {FisnikB.Boende} \n " +
                        $"{FisnikB.Ålder} \n {FisnikB.Hobby} \n {FisnikB.FavoritGodis} \n {FisnikB.Utbildning} \n {FisnikB.FavoritÅrstid} \n {FisnikB.FavoritMat} \n {FisnikB.FavoritDjur}");
                    break;

                }
                else
                {
                    Console.WriteLine("Fel karaktär");

                }



            }
        }
        private static void ProgrammeringSträng()
        {
            drivTillProgrammering ToveSeger = new drivTillProgrammering("Viljan att skapa en kreativ och intellektuell tillvaro, oberoende av fasta klockslag.");
            drivTillProgrammering OskarKling = new drivTillProgrammering("Kreativt, roligt, kontroll och problemlösning.");
            drivTillProgrammering EliasHjelm = new drivTillProgrammering("Att få arbeta med något som är kreativt och som jag alltid kan utvecklas inom");
            drivTillProgrammering ViktorSalmberg = new drivTillProgrammering("Kicken att förstå nya koncept och möjligheten till ett utvecklande arbetsliv.");
            drivTillProgrammering JohanRohdin = new drivTillProgrammering("Egna arbetstider, roligt och intressant.");
            drivTillProgrammering ChristopherBrizet = new drivTillProgrammering("Planera, skapa och ett enormt svängrum för kreativitet(plus fantasin om att erövra världen).");
            drivTillProgrammering RobertBunjaku = new drivTillProgrammering("Kombinera tidigare utbildning med nya kunskaper för att släppa lös den kreativa kraften och styra/forma egna framtiden.");
            drivTillProgrammering FisnikBalija = new drivTillProgrammering("Fascineras av hur något så enkelt med samtidigt komplicerat kan skapa något så kraftfullt och användbart. Vidare så är" +
                " programmering oerhört utmanande, spännande och framförallt roligt!");
            

            Console.WriteLine("Vems driv till programmering vill du se? Skriv deras förnamn! Alternativt skriv Avsluta, Quit eller q/Q för avsluta. ");
           string frasTvå = Console.ReadLine();

            while (true)

            {
                if (frasTvå == "Tove")
                {
                    Console.WriteLine($"{ToveSeger.Driv }");
                    Console.ReadKey();
                }
                if (frasTvå == "Oskar")
                {
                    Console.WriteLine($"{OskarKling.Driv }");
                    Console.ReadKey();
                }
                if (frasTvå == "Elias")
                {
                    Console.WriteLine($"{EliasHjelm.Driv }");
                    Console.ReadKey();
                }
                if (frasTvå == "Viktor")
                {
                    Console.WriteLine($"{ViktorSalmberg.Driv }");
                    Console.ReadKey();
                }
                if (frasTvå == "Johan")
                {
                    Console.WriteLine($"{JohanRohdin.Driv }");
                    Console.ReadKey();
                }
                if (frasTvå == "Christopher")
                {
                    Console.WriteLine($"{ChristopherBrizet.Driv }");
                    Console.ReadKey();
                }
                if (frasTvå == "Robert")
                {
                    Console.WriteLine($"{RobertBunjaku.Driv }");
                    Console.ReadKey();
                }
                if (frasTvå == "Fisnik")
                {
                    Console.WriteLine($"{FisnikBalija.Driv }");
                    Console.ReadKey();
                    break;
                }
                if(frasTvå=="Avsluta"||frasTvå=="Quit"||frasTvå=="q"||frasTvå=="q")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Det finns ingen som heter så!");
                    
                } 
            }
        }
    }
}
