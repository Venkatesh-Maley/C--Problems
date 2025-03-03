using System;

public class p10_Fibonacci_Series{
    static void Main(string[] arg){
        int num1 = 0;
        int num2 = 1;

        int sum = 0;

        for(int i = 2; i<10; i++){
            sum = num1 + num2;
            Console.WriteLine(sum);
            num1 = num2;
            num2 = sum;
        }
    }
}