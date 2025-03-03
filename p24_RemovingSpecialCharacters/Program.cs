using System;
using System.Text.RegularExpressions;

public class p24_RemovingSpecialCharacters{
    static void Main(string[] arg){
        string str = "#$%##^^ Venky From IIIT";

        Console.WriteLine("Given String before removing special characters: {0}", str);

        string str_reg = Regex.Replace(str, "[^a-zA-Z0-9]", "");
        string str_reg_white_space = Regex.Replace(str, "[^a-zA-Z0-9\\s]", ""); 

        Console.WriteLine("Given String before removing special characters: {0}", str_reg);
        Console.WriteLine("Given String before removing special characters: {0}", str_reg_white_space);

    }
}