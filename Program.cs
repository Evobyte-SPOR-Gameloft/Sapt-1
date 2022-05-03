namespace Sapt1
{
    class Program
    {
        static bool isEven(int n)
        {
            return n % 2 == 0;
        }
        static void Main(string[] args)
        {
            // List<int> numsList = new List<>() ...
            var numsList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            // var evensList = numsList.Where(isEven).ToList();
            var evensList = numsList.Where(n => n % 2 == 0).ToList();
            for (int i = 0; i < evensList.Count; i++)
            {
                Console.WriteLine($"{i+1}. {evensList[i]}");
            }
            foreach (var n in evensList)
            {
                Console.WriteLine($"{n}");
            }

            // Console.WriteLine("Hello World!");
        }
    }
}