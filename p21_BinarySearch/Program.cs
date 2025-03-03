using System;

public class p21_BinarySearch{
    static void Main(string[] arg){


        int[] arr = {10,60,30,20,50,40};

        int key = 60;

        // Sort in ascending order (Bubble Sort)
        for(int i = 0; i< arr.Length; i++){
            for(int j = 0; j< arr.Length-1; j++){
                if(arr[j] > arr[j+1]){
                    int swap = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = swap;
                }
            }
        }
        Console.WriteLine("Asending order of Numbers: ");
        for(int i = 0; i< arr.Length; i++){
                Console.WriteLine(arr[i]);
        }

        // Binary Search 

        int low = 0;
        int high = arr.Length;
        bool flag = false;

        while(low <= high){
            int mid = (low+high)/2;

            if(key == arr[mid]){
                Console.WriteLine("Key Found");
                flag = true;
                break;

            }
            if(key < arr[mid]){
                high = mid-1;
            }
            if(key > arr[mid]){
                low = mid + 1;
            }
        }

        if(flag == false){
            Console.WriteLine("Key not Found");
        }

        
    }
}