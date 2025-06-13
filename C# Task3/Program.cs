namespace ConsoleApp71
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int T = Convert.ToInt32(input.Split(' ')[0]);
            int S = Convert.ToInt32(input.Split(' ')[1]);

            int[,] roads = new int[T, S];

            for (int i = 0; i < T; i++)
            {
                string[] road = Console.ReadLine().Split(' ');
                for (int j = 0; j < S; j++)
                {
                    roads[i, j] = int.Parse(road[j]);
                }
            }

            int[] result = new int[S];

            for (int k = 0; k < S; k++)
            {
                int count = 0; 
                int row = 0; 

                for (row = 0; row < T; row++)
                {
                    count += roads[row,k];
                }

                if (count == T)
                {
                    result[k] = 1;
                }
                else
                {
                    result[k] = 0;
                }
            }

            for (int i = 0; i < S; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
