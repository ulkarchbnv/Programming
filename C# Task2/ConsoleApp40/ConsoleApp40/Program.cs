namespace ConsoleApp40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            int[] temperatures = new int[N];
            int[] warmDayInd = new int[N];
            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                temperatures[i] = int.Parse(Console.ReadLine());
                if (temperatures[i] > K)
                {
                    warmDayInd[cnt] = i + 1;
                    cnt++;
                }
            }

            Console.Write(cnt + " ");
            for (int i = 0; i < cnt; i++)
            {
                Console.Write(warmDayInd[i] + " ");
            }
        }
    }
}
