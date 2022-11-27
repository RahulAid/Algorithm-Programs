namespace Algorithm_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs");

            int[] array = { 10, 20, 30, 40, 50, 60, 70 };
            
            MergeSortMethod objSort = new MergeSortMethod();

            Console.WriteLine("\nArray elements Unsorted Order : ");
            objSort.Display(array);

            objSort.Sort(array, 0, array.Length - 1);
            Console.WriteLine("\n\nArray elements Sorted Order : ");
            objSort.Display(array);

            Console.ReadLine();
        }
    }
}