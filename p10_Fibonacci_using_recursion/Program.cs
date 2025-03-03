using System;

public class p10_Fibonacci_using_recursion{
    static void Fibonacci(int num1, int num2, int count){
        if(count == 0) return;

        int sum = num1 + num2;

        Console.WriteLine(sum);
        Fibonacci(num2, sum, count -1);
    }

    static void Main(string[] arg){
        int num1 = 0, num2 = 1, count = 8;

        Console.WriteLine(num1);
        Console.WriteLine(num2);

        Fibonacci(num1, num2, count);
    }
}