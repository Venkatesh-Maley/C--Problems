using System;
using System.Text.RegularExpressions;

public class p25_RemovingWhiteSpacesInString{
    static void Main(string[] arg){
        string str = "Iam Venky, From IIIT";
        Console.WriteLine("Original String:{0}", str);

        string str_reg = Regex.Replace(str, " ", "");
        Console.WriteLine("Modified String:{0}", str_reg);

    }
}