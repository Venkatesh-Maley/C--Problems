using System;

public class p14_SumofArray{

    static void Main(string [] arg){
        int[] arr = {1,2,3,4};

        int sum = 0;

        // Using foreach loop
        for(int i =0; i < arr.Length; i++){
            sum = sum + arr[i];
        }

        Console.WriteLine("Result Sum of Array using for loop: {0}", sum);

         // Using foreach loop
        foreach (int value in arr) {
            sum = sum + value;
            //sum += value;
        }

        Console.WriteLine("Result Sum of Array using foreach loop: {0}", sum);
    }
}