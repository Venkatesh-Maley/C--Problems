using System;

public class p5_PalindromeString{
    static void Main(string[] arg){
        
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();

        string org_str = str;
        string rev_str ="";

        for(int i = str.Length -1 ; i >=0; i--){
            rev_str = rev_str + org_str[i];
        }

        Console.WriteLine("Reversed String: {0}", rev_str);

        if(org_str == rev_str){
            Console.WriteLine("Given string is an Palindrome");
        }
        else{
            Console.WriteLine("Given string is not an Palindrome");
        }
    }

}