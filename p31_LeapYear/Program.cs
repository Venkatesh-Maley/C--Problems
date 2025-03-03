using System;

public class p31_LeapYear{

    static void Main(string[] arg){
        int year = 2012;

        if((year%400 ==0) || (year%4==0 && year%100!=0)){
            Console.WriteLine("This is a Leap Year");
        }
        else{
            Console.WriteLine("This is not a Leap Year");
        }
    }
}