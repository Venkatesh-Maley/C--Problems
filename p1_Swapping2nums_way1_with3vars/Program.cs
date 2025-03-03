using System;

public class p1_Swapping2nums_way1_with3vars {
    public static void Main(string[] arg){
        int a = 10;
        int b = 20;

        Console.WriteLine("a value before swapping:{0}", a);
        Console.WriteLine("b value before swapping:{0}", b);

        int temp;
        temp = a;
        a = b;
        b = temp;

        Console.WriteLine("a value after swapping:{0}", a);
        Console.WriteLine("b value after swapping:{0}", b);
        

    }
}