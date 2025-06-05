// Given two strings s and t, return true if t is an anagram of s, and false otherwise.

using System.Security.Cryptography.X509Certificates;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsAnagram("anagram", "nagaram")); 
           Console.WriteLine(IsAnagram("rat", "car"));
    }
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();

        Array.Sort(sArray);
        Array.Sort(tArray);

        for (int i = 0; i < sArray.Length; i++)
        {
            if (sArray[i] != tArray[i])
                return false;
        }

        return true;
    }
}
