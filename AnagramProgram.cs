
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
public class AnagramProgram
{
    public void AnagramDetectionProgram()
    {
        Console.WriteLine("\nEnter 1st string: ");
        string firstString = Console.ReadLine();
        Console.WriteLine("\nEnter 2nd string: ");
        string secondString = Console.ReadLine();
        char[] character1 = firstString.ToLower().ToCharArray();
        char[] character2 = secondString.ToLower().ToCharArray();
        Array.Sort(character1);
        Array.Sort(character2);
        string val1 = new string(character1);
        string val2 = new string(character2);

        if (val1 == val2)
        {
            Console.WriteLine("\nBoth strings are anagram");
        }
        else
        {
            Console.WriteLine("\nNot an anagram");
        }
    }
}