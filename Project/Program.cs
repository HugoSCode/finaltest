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
/**********************************
 * Shape area calculator          *
 * Author: Samuel Batchelor       *
 * Date 6 March 2024              *
 **********************************/


                string name, temp;
                int width, height, area;
                Console.WriteLine("Please enter your name");
                name = Console.ReadLine();
                Console.WriteLine("Please enter the height");
                temp = Console.ReadLine();
                height = Convert.ToInt32(temp);
                Console.WriteLine("Please enter the width");
                temp = Console.ReadLine();
                width = Convert.ToInt32(temp);
                area = width * height;
                Console.WriteLine($"Hello {name}, the area of your rectangle is {area}m^2 given the measurements you provided {width} width & {height} height");

                Console.ReadLine();
            
        }
    }

}
    

