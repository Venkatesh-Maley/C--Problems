using System;
using System.Text.RegularExpressions;

public class p28_ReversingEachWordInAString{
    static void Main(string[] arg){
        string str = "This is your venky";

        string rev_str = "";

        string[] split_str = str.Split(' ');

        foreach(string s in split_str){
            string str_word = "";
            for(int i = s.Length -1; i >= 0; i--){
                str_word = str_word + s[i];
            }

            rev_str = rev_str + str_word + " ";
        }

        Console.WriteLine("Reversed each word string:" + rev_str);
    }
}