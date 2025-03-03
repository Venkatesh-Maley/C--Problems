using System;

public class p7_Count_even_odd{
    static void Main(string[] arg){
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());

        int even_count = 0;
        int odd_count = 0;

        while(num > 0){
            int last = num%10;

            if(last % 2 == 0){  
                even_count++;
            }
            else{
                odd_count++;
            }

            num = num/10;
        }

        Console.WriteLine("even count: {0}", even_count);
        Console.WriteLine("odd count: {0}", odd_count);

    }
}