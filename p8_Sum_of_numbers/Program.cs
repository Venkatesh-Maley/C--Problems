using System;

public class p8_Sum_of_numbers{
    static void Main(string [] arg){
        Console.WriteLine("Enter a Number:");
        int num = int.Parse(Console.ReadLine());

        int sum_num = 0;

        while(num > 0){
            int last = num%10;  

            sum_num = sum_num + last;
            num = num/10;
        }

        Console.WriteLine("Sum of the given number: {0}", sum_num);

    }
}