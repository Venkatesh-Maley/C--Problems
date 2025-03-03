using System;

class p12_Random_Nums {
    static void Main() {
        // Approach 1 - Single Random Number
        Random rand = new Random();
        int randInt = rand.Next(1000);
        Console.WriteLine("Random Number is: " + randInt);

        Console.WriteLine("****************************************");

        // Approach 1 - Generating 10 Random Numbers
        Random rando = new Random();
        for (int i = 0; i < 10; i++) {
            int randoInt = rando.Next(100); 
            Console.WriteLine("Random Number " + (i + 1) + " is: " + randoInt);
        }

        Console.WriteLine("****************************************");

        // Approach 1 - Using Range
        int randomNumber = rando.Next(1, 100); 
        Console.WriteLine("Random Number (1-99): " + randomNumber);

        Console.WriteLine("****************************************");

        // Approach 2 - Using Math.Random Equivalent
        double randomDouble = new Random().NextDouble(); // Generates a double between 0.0 and 1.0
        Console.WriteLine("Random Double (0.0 to 1.0): " + randomDouble);
    }
}
