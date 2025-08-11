using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Vælg en opgave:");
                Console.WriteLine("1: Hello World");
                Console.WriteLine("2: Udskriv tekst");
                Console.WriteLine("3: Beregn sum");
                Console.WriteLine("3A: Subtraher tal");
                Console.WriteLine("3b: Multiplikater tal");
                Console.WriteLine("3C: Beregn og divider");
                Console.WriteLine("4: Bestem aldersgruppe");
                Console.WriteLine("5: Tekst splitter");
                Console.WriteLine("6: Gæt et tal");
                Console.WriteLine("7A: Temp converter");
                Console.WriteLine("9: Afslut programmet");
                Console.Write("Indtast dit valg: ");
                string valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":
                        World();
                        break;
                    case "2":
                        Console.WriteLine(Opg2());
                        break;
                    case "3":
                        Opg3();
                        break;
                    case "3A":
                        Opg3A();
                        break;
                    case "3b":
                        Opg3b();
                        break;
                    case "3C":
                        Opg3C();
                        break;
                    case "4":
                        Opg4();
                        break;
                    case "5":
                        Opg5();
                        break;
                    case "6":
                        Opg6();
                        break;
                    case "7A":
                       Opg7A();
                    break;
                    case "9":
                        Console.WriteLine("Afslutter programmet.");
                        running = false;
                        break;
                    case "default":
                        Console.WriteLine("Ugyldigt valg. Vælg et gyldigt argument.");
                        break;
                }

                Console.WriteLine("Tryk på en tast for at fortsætte...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        #region opgave 1
        public static string HelloWorld()
        {

            return "Hello World!";
        }
        static void World()
        {
            string world = HelloWorld();
            Console.WriteLine(world);
            Console.ReadKey();

        }
        #endregion
        public static string Opg2()
        {
            // Beder brugeren om at indtaste en tekststreng
            Console.Write("Indtast en tekststreng: ");
            string brugerInput = Console.ReadLine();

            // Kalder metoden og sender brugerens input som parameter
            return UdskrivTekst(brugerInput);
        }

        // Metode der modtager en streng og udskriver den
        static string UdskrivTekst(string tekst)
        {
            Console.WriteLine("Du indtastede: " + tekst);
            return tekst;
        }

        public static double Opg3()
        {

            // Beder brugeren om at indtaste tre tal
            Console.Write("Indtast det første tal: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast det andet tal: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast det tredje tal: ");
            double tal3 = Convert.ToDouble(Console.ReadLine());

            // Kalder metoden og modtager summen
            double sum = BeregnSum(tal1, tal2, tal3);

            // Udskriver summen
            Console.WriteLine("Summen af de tre tal er: " + sum);

            return sum;

        }

        // Metode der tager tre tal som parametre og returnerer summen
        static double BeregnSum(double a, double b, double c)
        {
            return a + b + c;
        }
        public static double Opg3A()
        {
            // Beder brugeren om at indtaste tre tal
            Console.Write("Indtast det første tal: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast det andet tal: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast det tredje tal: ");
            double tal3 = Convert.ToDouble(Console.ReadLine());

            // Kalder metoden og modtager resultatet af subtraktionen
            double resultat = SubtraherTal(tal1, tal2, tal3);

            // Udskriver resultatet
            Console.WriteLine("Resultatet af subtraktionen er: " + resultat);
            return resultat;
        }

        // Metode der tager tre tal og returnerer resultatet af subtraktion
        static double SubtraherTal(double a, double b, double c)
        {
            return a - b - c;
        }

        static double Opg3b()
        {
            // Beder brugeren om at indtaste et tal
            Console.Write("Indtast et tal: ");
            double tal = Convert.ToDouble(Console.ReadLine());
            // Kalder metoden og modtager resultatet
            double resultat = multiplikation(tal);
            // Udskriver resultatet
            Console.WriteLine("Kvadratet af " + tal + " er: " + resultat);
            return resultat;
        }

        static double multiplikation(double a)
        {
            // Returnerer kvadratet af tallet
            return a * a;
        }

        static double Opg3C()
        {
            Console.Write("Indtast tal 1: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast tal 2: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast tal 3 (divisor): ");
            double tal3 = Convert.ToDouble(Console.ReadLine());

            if (tal3 == 0)
            {
                Console.WriteLine("Fejl: Divisor må ikke være nul.");
                return 0;
            }
            else
            {
                double resultat = Beregn(tal1, tal2, tal3);
                Console.WriteLine("Resultatet er: " + resultat);
                return resultat;
            }
        }
        static double Beregn(double a, double b, double c)
        {
            double sum = a + b;
            return sum / c;
        }

        static string Opg4()
        {
            Console.Write("Indtast dit navn: ");
            string navn = Console.ReadLine();

            Console.Write("Indtast din alder: ");
            int alder;
            // Sikrer, at brugerens input er et gyldigt heltal
            while (!int.TryParse(Console.ReadLine(), out alder) || alder < 0)
            {
                Console.Write("Ugyldigt input. Indtast venligst en gyldig alder (0 eller højere): ");
            }

            string besked = BestemAldersgruppe(navn, alder);
            Console.WriteLine(besked);
            return besked;
        }

        static string BestemAldersgruppe(string navn, int alder)
        {
            if (alder >= 0 && alder <= 1)
            {
                return $"{navn}, du er nyfødt.";
            }
            else if (alder >= 2 && alder <= 3)
            {
                return $"{navn}, du er i dagpleje eller vuggestue.";
            }
            else if (alder >= 4 && alder <= 5)
            {
                return $"{navn}, du er i børnehave.";
            }
            else if (alder >= 6 && alder <= 18)
            {
                return $"{navn}, du går i skole.";
            }
            else if (alder >= 19)
            {
                return $"{navn}, nu begynder livet at blive alvor.";
            }
            else
            {
                return $"{navn}, du har indtastet en ugyldig alder.";
            }

        }

        static void Opg5()
        {
            Console.WriteLine("indtast en enkelt streng med værdier adskilt af kommaer.");
            string input = Console.ReadLine();
            string[] værdier = TekstSplitter(input);
            Console.WriteLine("Antal værdier: " + værdier.Length);

            for (int i = 0; i < værdier.Length; i = i + 1)
            {
                Console.WriteLine(værdier[i]);
            }

        }
        static string[] TekstSplitter(string input)
        {
            return input.Split(',');
        }


        static void Opg6()
        {
            bool vundet = false;
            int tal = Random();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Skriv et tilfældigt tal mellem 1 og 25: ");
                int input = Convert.ToInt32(Console.ReadLine());
                bool Gæt1 = Gæt(input, tal);
                if (Gæt1)
                {
                    vundet = true;
                    i = 42;
                }

            }
            if (vundet)
            {
                Console.WriteLine("Du har vundet!!!!!!!!!!");

            }
            else { Console.WriteLine("Du har tabt :("); }
        }
                static int Random()
                {
                    Random random = new Random();
                    int tal = random.Next(1, 26);
                    return tal;
                }

        static bool Gæt(int input, int tal)
        {
            if (input == tal)
            {
                return true;
            }
            else
            {
                HvorTætPå(input, tal);
                return false;
            }

        }
        static void HvorTætPå(int input, int tal)
        {
            if (input > tal)
            {
                Console.WriteLine("Gæt er højre end tal");
            }
            else
            { Console.WriteLine("Gæt er mindre end tal"); }

                    
        }
        static void Opg7A()
        {
            Console.WriteLine("Vælg input skala:");
            Console.WriteLine("1: Celsius");
            Console.WriteLine("2: Fahrenheit");
            Console.Write("Indtast dit valg: ");
            string Temps = Console.ReadLine();

            double inputTemp;
            Console.Write("Indtast temperatur: ");
            while (!double.TryParse(Console.ReadLine(), out inputTemp))
            {
                Console.Write("Ugyldigt input. Indtast et tal: ");
            }

            double celsius, fahrenheit, kelvin, reaumur;

            if (Temps == "1") // Input er Celsius
            {
                celsius = inputTemp;
                fahrenheit = celsius * 9 / 5 + 32;
                kelvin = celsius + 273.15;
                reaumur = celsius * 0.8;
            }
            else if (Temps == "2") // Input er Fahrenheit
            {
                fahrenheit = inputTemp;
                celsius = (fahrenheit - 32) * 5 / 9;
                kelvin = celsius + 273.15;
                reaumur = celsius * 0.8;
            }
            else
            {
                Console.WriteLine("Ugyldigt valg af skala.");
                return;
            }

            Console.WriteLine($"Celsius:    {celsius:F2} °C");
            Console.WriteLine($"Fahrenheit: {fahrenheit:F2} °F");
            Console.WriteLine($"Kelvin:     {kelvin:F2} K");
            Console.WriteLine($"Réaumur:    {reaumur:F2} °Ré");
        }

    }
}
