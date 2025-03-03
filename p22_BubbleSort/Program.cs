using System;

public class p22_BubbleSort{
    static void Main(string[] arg){
        int[] arr = {40,50,60,10,20,30};

        for(int i = 0; i < arr.Length; i++){
            for(int j = 0; j< arr.Length-1; j++){
                if(arr[j] > arr[j+1]){
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }

        Console.WriteLine("Ascending order:");
        for(int i = 0; i<= arr.Length -1; i++){
            Console.WriteLine(arr[i]);
        }

    }
}