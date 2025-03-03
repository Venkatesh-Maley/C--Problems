using System;

public class p2_ReverseNumber{
    static void Main(string[] arg){

        Console.WriteLine("Enter a value: ");
        int num = int.Parse(Console.ReadLine());

        int rev_num = 0; 

        // using while loop
        while(num != 0){
            int last_digit = num%10;
            rev_num = rev_num*10  + last_digit;
            num = num/10;
        }

        Console.WriteLine("Final Reversed value:{0}", rev_num);    

        for (; num != 0; num /= 10) {
            int last_digit = num % 10; 
            rev_num = rev_num * 10 + last_digit; 
        }

        Console.WriteLine("Final Reversed value: {0}", rev_num);    
    }
}