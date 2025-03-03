using System;
using System.Text.RegularExpressions;

public class p26_CountingOccuranceOfCharInSring{

    static void Main(string[] arg){
        string str = "RGUKT IIIT RKVALLEY";
        Console.WriteLine("Given String: {0}", str);

        string str_reg = Regex.Replace(str, "R", "");
        Console.WriteLine("Regex String: {0}", str_reg);

        int len_str = str.Length;
        int len_str_reg = str_reg.Length;

        Console.WriteLine("len_str and len_str_reg : {0} and {1}", len_str, len_str_reg );

        int No_of_Occurance = len_str - len_str_reg;

        Console.WriteLine("No of Occurance of R: {0}", No_of_Occurance);

    }
}