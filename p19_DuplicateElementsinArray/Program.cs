using System;

public class p19_DuplicateElementsinArray{
    static void Main(string[] arg){
        int[] arr= {1,2,3,4,5,2,3,8,9};

        bool flag = false;
        for(int i=0; i<= arr.Length-1; i++){
            for(int j=i+1; j <= arr.Length-1; j++){
                if(arr[i] == arr[j]){
                    
                    Console.WriteLine("Duplicate Numbers: {0}", arr[i]);
                    flag = true;
                    break;
                }
            }
        }

        if(flag == false){
            Console.WriteLine("No Duplicate Numbers");
        }
    }
}