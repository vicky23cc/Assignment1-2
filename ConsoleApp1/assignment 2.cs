using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ConsoleApp1;

class Program
{

    //1.
    //static void Main(string[] args)
    //{
    //    // Create the initial array
    //    int[] originalArray = new int[10];

    //    // Populate the original array with some values
    //    for (int i = 0; i < originalArray.Length; i++)
    //    {
    //        originalArray[i] = i * 2; // Example: Set even numbers in the array
    //    }

    //    // Print the contents of the original array
    //    Console.WriteLine("Original Array:");
    //    PrintArray(originalArray);

    //    // Create a second array with the same length as the original array
    //    int[] copiedArray = new int[originalArray.Length];

    //    // Copy values from the original array to the new array
    //    for (int i = 0; i < originalArray.Length; i++)
    //    {
    //        copiedArray[i] = originalArray[i];
    //    }

    //    // Print the contents of the copied array
    //    Console.WriteLine("\nCopied Array:");
    //    PrintArray(copiedArray);
    //}

    //// Method to print the contents of an array
    //static void PrintArray(int[] array)
    //{
    //    foreach (var item in array)
    //    {
    //        Console.Write(item + " ");
    //    }
    //    Console.WriteLine();
    //}





    ////2.
    //static void Main(string[] args)
    //{
    //    List<string> list = new List<string>();

    //    while (true) {
    //        Console.WriteLine("Enter an operation (+ to add, - to remove, -- to clear):");
    //        string input = Console.ReadLine();
    //        if (string.IsNullOrWhiteSpace(input))
    //        {
    //            Console.WriteLine("Invalid input. Please try again.");
    //            continue;
    //        }
    //        char operation = input[0];
    //        string item = input.Substring(1).Trim();
    //        if (operation == '+' && item is not null)
    //        {
    //            list.Add(item);
    //            break;
    //        }
    //        else if (operation == '-' && item is not null) {
    //            list.Remove(item);
    //            break;
    //        }
    //        else if (operation == '-' && item is null) {
    //            list.Clear();
    //            break;
    //        }
    //        else {
    //            Console.WriteLine("Invalid operation. Please try again.");
    //        }
    //        }
    //    Console.WriteLine("current list contents:");
    //    foreach (string item in list) {
    //        Console.WriteLine(item);
    //    }
    //}

    //3.
    //    static void Main(string[] args)
    //    {
    //        int start = 1; // Start of the range
    //        int end = 100; // End of the range

    //        int[] primes = FindPrimesInRange(start, end);

    //        Console.WriteLine("Prime numbers between " + start + " and " + end + ":");
    //        foreach (int prime in primes)
    //        {
    //            Console.Write(prime + " ");
    //        }
    //    }
    //    static int[] FindPrimesInRange(int startNum, int endNum)
    //    {
    //        List<int> primelist = new List<int>();
    //        for (int i = startNum; i <= endNum; i++)
    //        {
    //            if (isprime(i))
    //            {
    //                primelist.Add(i);
    //            }
    //        }
    //        return primelist.ToArray();
    //    }

    //    static bool isprime(int i)
    //    {
    //        if (i <= 1)
    //        {
    //            return true;
    //        }
    //        for (int j = 2; j <= Math.Sqrt(i); j++)
    //        {
    //            if (i % j == 0)
    //            {
    //                return false;
    //            }
    //        }
    //        return true;
    //    }

    //}

    //4.
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Enter the array of integers (space-separated):");
    //    int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    //    Console.WriteLine("Enter the value of k (number of rotations):");
    //    int k = int.Parse(Console.ReadLine());

    //    int n = array.Length;
    //    int[] sum = new int[n];

    //    for (int r = 1; r <= k; r++)
    //    {
    //        RotateArrayRight(array);
    //        Console.WriteLine($"After rotation {r}:");
    //        PrintArray(array);

    //        for (int i = 0; i < n; i++)
    //        {
    //            sum[i] += array[i];
    //        }
    //    }

    //    Console.WriteLine("Final sum array:");
    //    PrintArray(sum);
    //}

    //static void RotateArrayRight(int[] array)
    //{
    //    int temp = array[array.Length - 1];
    //    for (int i = array.Length - 1; i > 0; i--)
    //    {
    //        array[i] = array[i - 1];
    //    }
    //    array[0] = temp;
    //}

    //static void PrintArray(int[] array)
    //{
    //    foreach (int num in array)
    //    {
    //        Console.Write(num + " ");
    //    }
    //    Console.WriteLine();
    //}

    // 5.
    //static void Main(string[] args) {
    //    Console.WriteLine("Enter the array of integers (space-separated):");
    //    int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    //    int counts = 1;
    //    int longnum = array[0];
    //    int longestcount = 1;

    //    for (int i = 1; i < array.Length; i++) {
    //        if (array[i] != array[i - 1])
    //        {
    //            counts = 0;
    //        }
    //        counts++;

    //        if (counts > longestcount) { 
    //        longestcount = counts;
    //        longnum = array[i];
    //        }
    //    }
    //    Console.WriteLine(string.Join(" ", Enumerable.Repeat(longnum,longestcount))) ;

    //}

    //6.
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Enter the array of integers (space-separated):");
    //    int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    //    int counts = 1;
    //    int longnum = array[0];
    //    int longestcount = 1;

    //    for (int i = 1; i < array.Length; i++)
    //    {
    //        if (array[i] != array[i - 1])
    //        {
    //            counts = 0;
    //        }
    //        counts++;

    //        if (counts > longestcount)
    //        {
    //            longestcount = counts;
    //            longnum = array[i];
    //        }
    //    }
    //    Console.WriteLine($"the number {longnum} is the most frequent (occurs) {longestcount} times ");

    //}

    //practice strings
    //1.
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Enter the string:");
    //    string str = Console.ReadLine();
    //    char[] chars = str.ToCharArray();
    //    reverseArray(chars);
    //    PrintArray(chars);



    //    static void reverseArray(char[] array)
    //    {
    //        int range = (array.Length - 1) / 2;
    //        char temp = 'a';
    //        for (int i = 0; i <= range; i++)
    //        {   
    //            temp = array[i];
    //            array[i] = array[array.Length - 1 - i];
    //            array[array.Length - 1 - i] = temp;
    //        }
    //    }

    //    static void PrintArray(char[] array)
    //    {
    //        foreach (char i in array)
    //        {
    //            Console.Write(i);
    //        }
    //        Console.WriteLine();

    //    }

    //}

    //2.

    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Enter a sentence:");
    //    string sentence = Console.ReadLine();

    //    char[] separators = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

    //    // Split the sentence into words and separators
    //    string[] wordsAndSeparators = Regex.Split(sentence, @"([.,:;=()&\[\]""'\\/!? ]+)");

    //    string[] words = wordsAndSeparators.Where(word => !string.IsNullOrEmpty(word) && !separators.Contains(word[0])).ToArray();
    //    string[] originalSeparators = wordsAndSeparators.Where(sep => string.IsNullOrEmpty(sep) || separators.Contains(sep[0])).ToArray();

    //    // Reverse the words
    //    Array.Reverse(words);

    //    // Merge reversed words with original separators
    //    string reversedSentence = string.Concat(words.Select((word, index) => word + (index < originalSeparators.Length ? originalSeparators[index] : "")));


    //    Console.WriteLine("Reversed sentence:");
    //    Console.WriteLine(reversedSentence);
    //}

    //3.
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Enter some text:");
    //    string text = Console.ReadLine();

    //    // Extract palindromes
    //    var palindromes = ExtractPalindromes(text);

    //    // Print unique palindromes, sorted
    //    Console.WriteLine(string.Join(", ", palindromes.Distinct().OrderBy(p => p)));
    //}

    //static IEnumerable<string> ExtractPalindromes(string text)
    //{
    //    // Split the text into words
    //    string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

    //    // Filter palindromic words
    //    foreach (string word in words)
    //    {
    //        if (IsPalindrome(word))
    //        {
    //            yield return word;
    //        }
    //    }
    //}

    //static bool IsPalindrome(string word)
    //{
    //    // Check if the word is a palindrome
    //    int left = 0;
    //    int right = word.Length - 1;
    //    while (left < right)
    //    {
    //        if (word[left] != word[right])
    //        {
    //            return false;
    //        }
    //        left++;
    //        right--;
    //    }
    //    return true;
    //}

    //4.
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an URL:");
        string url = Console.ReadLine();

        string[] arr = new string[3];
        arr[0] = url.Contains("://") ? url.Substring(0, url.IndexOf("://")) : ""; // Extract protocol

        int protocolIndex = url.IndexOf("://");
        if (protocolIndex != -1)
        {
            arr[0] = url.Substring(0, protocolIndex); // Extract protocol
            url = url.Substring(protocolIndex + 3); // Remove protocol part from the URL
        }

        // Extract server and resource
        int slashIndex = url.IndexOf('/');
        if (slashIndex != -1)
        {
            arr[1] = url.Substring(0, slashIndex); // Extract server
            arr[2] = url.Substring(slashIndex + 1); // Extract resource
        }
        else
        {
            arr[1] = url; // Server is the whole URL
            arr[2] = ""; // No resource
        }

        Console.WriteLine($"Protocol: {arr[0]}");
        Console.WriteLine($"Server: {arr[1]}");
        Console.WriteLine($"Resource: {arr[2]}");
    }

}