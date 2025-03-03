using System;
using System.Linq; // Import LINQ

public class p3_ReverseString{
    static void Main(string[] arg){
        Console.WriteLine("Enter a string");
        string? str = Console.ReadLine();

        if (string.IsNullOrEmpty(str)) {
            Console.WriteLine("Invalid input! Please enter a valid string.");
            return;
        }
        // Example: ABCD

        // Method 1: Using Loop
        string rev_str = "";

        for(int i= str.Length -1; i>=0 ;i-- ){
            rev_str = rev_str + str[i];
        }

        Console.WriteLine("Reversed String: {0}", rev_str);


        // Method 2: Using char array and Array.Reverse()
        char[] charArray = str.ToCharArray(); 
        Array.Reverse(charArray); 
        string reversedString = new string(charArray); 

        Console.WriteLine("Reversed String using charArray: {0}", reversedString);


        // Method 3: Using LINQ
        string rev_String = new string(str.Reverse().ToArray());

        Console.WriteLine("Reversed String using Reverse().ToArray() LINQ: {0}", rev_String);

    }
}