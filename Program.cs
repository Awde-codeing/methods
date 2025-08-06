namespace ConsoleApp1
{
    internal class Program
    {
        #region opgave 1
        public static string HelloWorld()
        {

            return "Hello World!";
        } 
        static void Main(string[] args)
        {
            string world = HelloWorld();
            Console.WriteLine(world);
            Console.ReadKey();

        }
        #endregion
    }
}
