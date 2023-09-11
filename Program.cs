namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string whosSmelly = "Not me";
            Console.WriteLine("Hello, World, my name is Elijah");

            Console.WriteLine(@"wassup gang");

            Console.WriteLine("whaaaaaaaaa00");

            int num;
            Console.WriteLine("ready for take off");
            for(int i = 1; i <= 10; i++)
            {
               num = i;
                Console.WriteLine(num);
            }

            bool smells = false;


            while (smells == false)
            {
                Console.Write("Smelly ");
                smells = true;
            }
            Console.WriteLine($"Smelly? {whosSmelly}");


            Console.WriteLine("what is what was the what whateter wahtaterere");
        }
    }
}