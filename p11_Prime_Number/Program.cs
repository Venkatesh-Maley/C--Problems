using System;

public class p11_Prime_Number{
    public static void Main(string[] arg){
        
        int num = 19;

        int count = 0;

        if( num > 1){
            for(int i = 1; i <= num ; i++){
                
                if(num%i == 0){
                    count ++;
                }
            }
            if(count == 2){
                Console.WriteLine("Given Number is a Prime Number");
            }
            else{
                Console.WriteLine("Given Number is not a Prime Number");
            }
        }
    }
}