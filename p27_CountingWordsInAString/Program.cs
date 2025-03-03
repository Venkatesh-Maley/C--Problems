using System;
using System.Text.RegularExpressions;

public class p27_CountingWordsInAString{
    static void Main(string[] arg){
        string str = "Hi World, this is C# Language";
        int count = 1;

        for(int i = 0; i <= str.Length-1; i++){
            if(str[i] == ' ' && str[i+1] != ' '){
                count++;
            }
        }
        Console.WriteLine("Count of words in given String: {0}", count);
    }
}