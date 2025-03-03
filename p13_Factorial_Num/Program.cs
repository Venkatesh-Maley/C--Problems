using System;

public class p13_Factorial_Num{
    static void Main(string[] arg){
        Console.WriteLine("Enter a Number:");
        int num = int.Parse(Console.ReadLine());

        int fac_num = 1;

        for(int i = 1; i <= num; i ++){
            fac_num = fac_num*i;
        }

        Console.WriteLine("Factorial value: {0}", fac_num);
    }
}