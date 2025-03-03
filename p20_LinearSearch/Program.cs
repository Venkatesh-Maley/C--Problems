using System;

public class p20_LinearSearch{
    static void Main(string[] arg){
        int[] a = {10,20,40,30,50,60};

        int search = 3;
        bool flag = false;

        for(int i = 0; i< a.Length; i++){
                if( search == a[i]){
                    Console.WriteLine("Search Number Found: {0}", a[i]);
                    flag = true;
                }
        }

        if(flag == false){
            Console.WriteLine("Search Number Not Found");
        }
    }
}