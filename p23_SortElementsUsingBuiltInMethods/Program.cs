using System;

class p23_SortElementsUsingBuiltInMethods {
    public static void Main() {
        int[] a = {100, 200, 300, 10, 20, 30, 40};
        Console.WriteLine("Before Sorting: " + string.Join(", ", a));

        Array.Sort(a); // Built-in sorting method in C#

        Console.WriteLine("After Sorting: " + string.Join(", ", a)); 
        //string.Join(", ", a)  converts the array into a comma-separated string for display
    }
}
