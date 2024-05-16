namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            one();
            two();
            three();
        }
        static void one() 
        {
            double bodytemp = 36.5;
            double tempincr;
            int count = 0;
            Random rand = new Random();
            Console.WriteLine("what is your body temperature?");
            while (bodytemp < 38)
            {
                tempincr = rand.NextDouble();
                bodytemp = bodytemp + tempincr;
                Thread.Sleep(1000);
                count++;
                Console.WriteLine($"You have been in the sauna for {count} mins, your temperature is {bodytemp:F2}");
            }
            Console.WriteLine("You are too hot for the sauna");
            Console.ReadLine();

        }
        static void two()
        {

        }
        static void three() 
        {

        }
    }
}
