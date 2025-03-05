using System;

class p32_subString
{
    static void Main()
    {
        string[] words = { "flower", "flow", "flight" };

        if (words.Length == 0)
        {
            Console.WriteLine("No common substring");
            return;
        }

        string commonSubstr = words[0]; // Start with the first word

        for (int i = 1; i < words.Length; i++)
        {
            string str1 = commonSubstr;
            string str2 = words[i];
            int maxLength = 0;
            string longestSubstr = "";

            for (int j = 0; j < str1.Length; j++)
            {
                for (int k = j + 1; k <= str1.Length; k++)
                {
                    string sub = str1.Substring(j, k - j);
                    if (str2.Contains(sub) && sub.Length > maxLength)
                    {
                        maxLength = sub.Length;
                        longestSubstr = sub;
                    }
                }
            }

            commonSubstr = longestSubstr;

            if (commonSubstr == "") 
                break; // No common substring, exit early
        }

        Console.WriteLine("Longest Common Substring: " + commonSubstr);
    }
}
