namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays;
            numberOfDays = Convert.ToInt32(Console.ReadLine());
            int maxRain = -1;
            int maxInd = -1;
            for ( int i = 1; i <= numberOfDays; i++)
            {
                int rain = Convert.ToInt32(Console.ReadLine());
                if (rain > maxRain || maxInd == -1)
                {
                    maxRain = rain;
                    maxInd = i;
                }
            }
            Console.WriteLine(maxInd);
        }
    }
}
