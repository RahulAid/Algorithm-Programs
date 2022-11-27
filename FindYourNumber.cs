
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
public class FindYourNumber
{
    public void FindNumber()
    {
        int low = 0;
        int high = 100;
        int count = 0;

        Console.WriteLine("\nPick a number between 0 and 100 ");
        Console.ReadLine();

        while (low != high)
        {
            int mid = (low + high) / 2;
            Console.WriteLine($"Press 1 if your number is in between {low} and {mid} \nPress 2 if your number is in between {mid + 1} and {high}");
            int choose = Convert.ToInt32(Console.ReadLine());
            count++;
            switch (choose)
            {
                case 1:
                    high = mid;
                    break;
                case 2:
                    low = mid + 1;
                    break;
            }
        }
        Console.WriteLine($"Your Number is {low} ");
        Console.WriteLine($"Found your number in {count} tries");
        FindNumber();
    }
}