namespace Algorithm_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithm Programs");

            Console.WriteLine("Enter a string value : ");
            string word = Console.ReadLine();
            int n = word.Length;
            string answer = " ";

            Console.WriteLine("\nAll possible strings are : ");

            Console.WriteLine("\nIterative Method: ");
            PermutationOfString.Iterative(word, answer);

            Console.WriteLine("\nRecursive Method: ");
            PermutationOfString.Recursion(word, 0, n - 1);
        }
    }
}