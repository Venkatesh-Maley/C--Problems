using System;

public class p17_MissingNumberinArray{
    static void Main(string[] arg){
        int[] a = [1,3,4,5];

        //Rules:
        //Array should not have Duplicates
        //Array No need to be Sorted Order
        //Values should be in range

        int sum1 = 0;
        for(int i =0; i<= a.Length-1; i ++ ){
            sum1 = sum1 + a[i];
        }
        Console.WriteLine("Sum1 of given numbers: {0}", sum1);

        int sum2 = 0;
        for(int i = 1; i<=5; i++){
            sum2 = sum2 + i;
        }
        Console.WriteLine("Sum1 of given numbers: {0}", sum2);

        int missing_value = sum2 - sum1;
        Console.WriteLine("Missing value: {0}", missing_value);
    }
}