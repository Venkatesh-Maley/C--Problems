using System;

public class p6_Count_number{
    static void Main(string[] arg){

        Console.WriteLine("Enter a Number: ");
        int num = int.Parse(Console.ReadLine());
        // Ex: 123

        int count = 0;

        
        while(num != 0){
            num = num/10;
            count++;
        }

        //To include 0
        
        // do
        // {
        //     count++;
        //     num /= 10;
        // } while (num != 0);

        Console.WriteLine("Count: {0}",count);
        
        
    }
}