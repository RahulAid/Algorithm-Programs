using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class BinarySearchWord<T>
{
    public string FilePath = @"D:\BridgeLabzz\Algorithm-Programs\WordFile.json";

    public void WordExistsOrNot<T>()
    {
        string words = "OOPS,Array,Dictionary,Generics,Delegates,Linked List,Stack,Queue,Hash Table,Events,Regular Expressions";
        File.WriteAllText(FilePath, JsonConvert.SerializeObject(words));

        string wordData = File.ReadAllText(FilePath);
        string word = JsonConvert.DeserializeObject<string>(wordData);
        List<string> wordList = word.Split(',').ToList<string>();
        wordList.Sort();

        Console.WriteLine("Enter a Word to Search: ");
        string wordToSearch = Console.ReadLine();

        int index = wordList.BinarySearch(wordToSearch);

        if (index < 0)
        {
            Console.WriteLine($"{wordToSearch} does not exist");
        }
        else
        {
            Console.WriteLine($"{wordToSearch} exists");
        }
    }
}

public class InsertionSortMethod<T>
{
    public void Sort<T>(T[] array) where T : IComparable
    {
        int index;

        for (int i = 1; i < array.Length; i++)
        {
            T word = array[i];
            index = i - 1;
            while ((index >= 0) && (array[index].CompareTo(word) > 0))
            {
                array[index + 1] = array[index];
                index--;
            }
            array[index + 1] = word;
        }
    }

    public void Display<T>(T[] array) where T : IComparable
    {
        int n = array.Length;
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + "  ");
        }
    }
}

public class BubbleSortMethod<T>
{
    public void Sort<T>(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int index = 0; index < n - i - 1; index++)
            {
                if (array[index] > array[index + 1])
                {
                    int temp = array[index];
                    array[index] = array[index + 1];
                    array[index + 1] = temp;
                }
            }
        }
    }

    public void Display<T>(T[] array) where T : IComparable
    {
        int n = array.Length;
        for (int i = 0; i < n; i++)
            Console.Write(array[i] + "  ");
    }
}

public class MergeSortMethod<T>
{
    // Function that Merges two subarrays of []array
    // First subarray is array[left..mid]
    // Second subarray is array[mid+1..right]
    public void Merge<T>(int[] array, int left, int mid, int right)
    {
        // Find sizes of two subarrays to be merged
        int sizeOfArray1 = mid - left + 1;
        int sizeOfArray2 = right - mid;

        // Create temp arrays
        int[] tempLeft = new int[sizeOfArray1];
        int[] tempRight = new int[sizeOfArray2];
        int i, j;

        // Copy data to temp arrays
        for (i = 0; i < sizeOfArray1; ++i)
            tempLeft[i] = array[left + i];
        for (j = 0; j < sizeOfArray2; ++j)
            tempRight[j] = array[mid + 1 + j];

        // Merge the temp arrays
        // Initial indexes of first and second subarrays
        i = 0;
        j = 0;

        // Initial index of merged subarray array
        int k = left;
        while (i < sizeOfArray1 && j < sizeOfArray2)
        {
            if (tempLeft[i] <= tempRight[j])
            {
                array[k] = tempLeft[i];
                i++;
            }
            else
            {
                array[k] = tempRight[j];
                j++;
            }
            k++;
        }

        // Copy remaining elements of tempLeft[] if any
        while (i < sizeOfArray1)
        {
            array[k] = tempLeft[i];
            i++;
            k++;
        }

        // Copy remaining elements of tempRight[] if any
        while (j < sizeOfArray2)
        {
            array[k] = tempRight[j];
            j++;
            k++;
        }
    }

    // Function that Sorts arr[l..r] using Merge()
    public void Sort<T>(int[] array, int left, int right)
    {
        if (left < right)
        {
            // Find the middle point
            int mid = left + (right - left) / 2;

            // Sort first and second halves
            Sort<int>(array, left, mid);
            Sort<int>(array, mid + 1, right);

            // Merge the sorted halves
            Merge<int>(array, left, mid, right);
        }
    }

    public void Display<T>(T[] array) where T : IComparable
    {
        int n = array.Length;
        for (int i = 0; i < n; i++)
            Console.Write(array[i] + "  ");
    }
}