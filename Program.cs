namespace Algorithm_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs");

            int[] array = { 10, 20, 30, 40, 50, 60, 70 };
            BubbleSortMethod objSort = new BubbleSortMethod();

            Console.WriteLine("\nArray elements Unsorted order : ");
            objSort.Display(array);

            objSort.Sort(array);
            Console.WriteLine("\n\nArray elements Sorted order : ");
            objSort.Display(array);

            Console.ReadLine();
        }
    }
}