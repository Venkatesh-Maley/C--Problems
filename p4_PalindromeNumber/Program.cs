using System;

public class p4_PalindromeNumber{
    static void Main(string[] arg){
        Console.WriteLine("Enter a Number: ");
        int num = int.Parse(Console.ReadLine());

        int org_num = num;
        int rev_num = 0;

        while(num != 0){
            int last_digit = num%10;
            rev_num = rev_num*10 + last_digit;
            num = num/10;
        }

        Console.WriteLine("Reversed number: {0}", rev_num);

        if(org_num==rev_num){
            Console.WriteLine("Given Number " + org_num + " is a Palidrome Number");
        }
        else{
            Console.WriteLine("Given Number " + org_num + " is not a Palidrome Number");
        }
    }
}