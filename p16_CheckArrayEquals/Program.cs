using System;
using System.Linq;

public class p16_CheckArrayEquals {
    public static void Main() {
        int[] a1 = {1, 2, 3, 4, 5, 6};
        int[] a2 = {1, 2, 3, 4, 5, 6};

        // Approach 1: Using SequenceEqual (Similar to Arrays.equals in Java)
        bool status = a1.SequenceEqual(a2);

        if (status) {
            Console.WriteLine("Arrays are Equal");
        } else {
            Console.WriteLine("Arrays are not Equal");
        }

        Console.WriteLine("****************************************");

        // Approach 2: Manual Comparison
        bool status_manual = true;

        if (a1.Length == a2.Length) {
            for (int i = 0; i < a1.Length; i++) {
                if (a1[i] != a2[i]) {
                    status_manual = false;
                    break;
                }
            }
        } else {
            status_manual = false;
        }

        if (status_manual) {
            Console.WriteLine("Arrays are Equal (Manual Check)");
        } else {
            Console.WriteLine("Arrays are not Equal (Manual Check)");
        }
    }
}
