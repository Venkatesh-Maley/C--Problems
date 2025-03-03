using System;

public class p15_Arr_EvenAndOdd{

    static void Main(string[] arg){
        int[] arr = {1,2,3,4,5,6};

        
        Console.WriteLine("Even number:");
        for(int i = 0; i<arr.Length; i++ ){
            if(arr[i]%2 ==0){
                Console.WriteLine(arr[i]);
            }
        }

        Console.WriteLine("Odd number:");
        for(int i = 0; i<arr.Length; i++ ){
            if(arr[i]%2 !=0){
                Console.WriteLine(arr[i]);
            }
        }
    }

}