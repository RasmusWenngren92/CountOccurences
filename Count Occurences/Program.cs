using System.Net.Security;
using System.Runtime.InteropServices.JavaScript;

namespace Count_Occurences;

class Program
{
    static void Main(string[] args)
    {
        CountOccurrences("Hello", 'l');
    }

    public static int CountOccurrences(string str, char c)
    {
        string lowerStr = str.ToLower();
        string lowerChar = c.ToString().ToLower();
        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == c)
            {
                count++;
            }
        }

        return count;
    }

}

