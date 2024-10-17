using System.Net.Security;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.JavaScript;

namespace Count_Occurences;

class Program
{
    static void Main(string[] args)
    {
        int count = CountOccurrences("Hello", 'l');
        Console.WriteLine($"Occurrences of 'l': {count}");
    }

    public static int CountOccurrences(string str, char c)
    {
        string lowerStr = str.ToLower();
        char lowerChar = char.ToLower(c);
        int count = 0;

        for (int i = 0; i < lowerStr.Length; i++)
        {
            if (str[i] == c)
            {
                count++;
            }
        }

        return count;
    }

}

