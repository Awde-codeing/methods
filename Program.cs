namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            World();
            Console.WriteLine("retunerd tekts" + Opg2());
            Console.WriteLine("sum: " + Opg3());
            Console.WriteLine("subtraktion af tal:" + Opg3A());
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

    }
}
