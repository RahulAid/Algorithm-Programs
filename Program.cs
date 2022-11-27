namespace Algorithm_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs");

            Console.WriteLine("Select Search and Sort Method from Below: ");
            Console.WriteLine("1. Binary Search \n2. Insertion Sort \n3. Bubble Sort \n4. Merge Sort");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:

                    BinarySearchWord<string> obj = new BinarySearchWord<string>();
                    obj.WordExistsOrNot<string>();
                    Console.ReadLine();
                    break;

                case 2:

                    string[] names = { "OOPS", "Array", "Dictionary", "Generics", "Delegates", "LinkedList", "Stack", "Queue", "HashTable", "Events", "Regular Expressions" };
                    InsertionSortMethod<string> objInsertion = new InsertionSortMethod<string>();

                    Console.WriteLine("\nArray Elements Unsorted Order : ");
                    objInsertion.Display<string>(names);

                    objInsertion.Sort<string>(names);
                    Console.WriteLine("\nArray Elements Sorted Order : ");
                    objInsertion.Display<string>(names);
                    Console.ReadLine();
                    break;

                case 3:

                    int[] array = { 10, 20, 30, 40, 50, 60, 70 };
                    BubbleSortMethod<int> objBubbleSort = new BubbleSortMethod<int>();

                    Console.WriteLine("\nArray Elements Unsorted Order : ");
                    objBubbleSort.Display<int>(array);

                    objBubbleSort.Sort<int>(array);
                    Console.WriteLine("\nArray Elements Sorted Order : ");
                    objBubbleSort.Display<int>(array);

                    Console.ReadLine();
                    break;

                case 4:

                    int[] numArray = { 10, 20, 30, 40, 50, 60, 70 };
                    MergeSortMethod<int> objSort = new MergeSortMethod<int>();

                    Console.WriteLine("\nArray Elements Unsorted Order : ");
                    objSort.Display<int>(numArray);

                    objSort.Sort<int>(numArray, 0, numArray.Length - 1);
                    Console.WriteLine("\nArray Elements Sorted Order : ");
                    objSort.Display<int>(numArray);

                    Console.ReadLine();
                    break;
            }

        }
    }
}