using System;

public class p9_Largest_of_3Nums{
    static void Main(string[] arg){

        //Logic1 
        Console.WriteLine("Enter your 1st Number: ");
        int Num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your 2nd Number: ");
        int Num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your 3rd Number: ");
        int Num3 = int.Parse(Console.ReadLine());

        if( Num1> Num2 && Num1> Num3){
            Console.WriteLine("Largest Number is: {0}", Num1);
        }
        else if ( Num2> Num1 && Num2> Num3){
            Console.WriteLine("Largest Number is: {0}", Num2);
        }
        else if ( Num3> Num1 && Num3> Num2){
            Console.WriteLine("Largest Number is: {0}", Num3);
        }
        else if (Num1 == Num2 && Num1 > Num3)
        {
            Console.WriteLine("{0} and {1} are equal and the largest numbers", Num1, Num2);
        }
        else if (Num2 == Num3 && Num2 > Num1)
        {
            Console.WriteLine("{0} and {1} are equal and the largest numbers", Num2, Num3);
        }
        else if (Num3 == Num1 && Num3 > Num2)
        {
            Console.WriteLine("{0} and {1} are equal and the largest numbers", Num3, Num1);
        }
        else
        {
            Console.WriteLine("All three numbers are equal");
        }

        //Logic2 - Using Ternary operator
        int a = 10, b = 20, c = 30;

        Console.WriteLine("Given Three numbers are: " + a + " " + b + " " + c);

        int largest1 = (a > b) ? a : b; // Largest of a & b
        int largest2 = (c > largest1) ? c : largest1; // Largest of c & largest1

        Console.WriteLine(largest2 + " is the Largest Number");

        //Logic3 - single line
        int largest = (c > ((a > b) ? a : b)) ? c : ((a > b) ? a : b);
        Console.WriteLine(largest + " is the Largest Number");
    }
}
