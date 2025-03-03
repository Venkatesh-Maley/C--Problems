using System;

public class p1_Swapping2nums_way2_withoperators{
    static void Main(string[] arg){
        int a = 10;
        int b = 20;

        //using + and - 
        a = a + b; //a = 10 + 20 = 30
        b = a - b; //b = 30 - 20 = 10
        a = a - b; //a = 30 - 10 = 20
        //Now the values are swapped

        Console.WriteLine(" a and b swapped values using + and - are {0}, {1}", a, b );

        int x = 10;
        int y = 20;

        //using * and / 
        x = x*y;
        y = x/y;
        x = x/y;
        //Now the values are swapped

        Console.WriteLine(" a and b swapped values using * and / are {0}, {1}", x, y );

        int i = 10;
        int j = 20;

        //using XOR operator

        i = i^j;
        j = i^j;
        i = i^j;
        //Now the values are swapped

        Console.WriteLine(" a and b swapped values using XOR are {0}, {1}", i, j );
        

        int m = 10;
        int n = 20;
        //using single statement

        n = m + n - (m=n);
        //Now the values are swapped

        Console.WriteLine(" a and b swapped values using XOR are {0}, {1}", m, n );
    }
}