namespace Task1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;

            Console.WriteLine("{0} + {1} = {2}", a, b, sum);
            Console.Write("Нажми любую клавишу");
            Console.ReadKey();
        }
    }
}
