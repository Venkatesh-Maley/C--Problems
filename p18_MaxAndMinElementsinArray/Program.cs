using System;

public class p18_MaxAndMinElementsinArray{
    static void Main(string[] arg){
        int[] a = {1,2,3,4,5,6};

        int max = a[0];

        for(int i =0; i<= a.Length-1; i++){
            if(max < a[i]){
                max = a[i];
            }
        }

        Console.WriteLine("Max Number: {0}", max);

        int min = a[0];

        for(int i =0; i<= a.Length-1; i++){
            if(min > a[i]){
                min = a[i];
            }
        }

        Console.WriteLine("Min Number: {0}", min);


    }
}