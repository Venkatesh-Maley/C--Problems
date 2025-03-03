using System;

class RandomStringGenerator {
    static void Main() {
        string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random rand = new Random();
        int stringLength = 6;

        // Generate a single random string
        char[] singleString = new char[stringLength];

        for (int j = 0; j < stringLength; j++) {
            int index = rand.Next(characters.Length);
            singleString[j] = characters[index];
        }

        Console.WriteLine("Single Random String: " + new string(singleString));

        Console.WriteLine("****************************************");

        // Generate and print 10 random strings
        for (int i = 0; i < 10; i++) {
            char[] randomString = new char[stringLength];

            for (int j = 0; j < stringLength; j++) {
                int index = rand.Next(characters.Length);
                randomString[j] = characters[index];
            }

            Console.WriteLine("Random String " + (i + 1) + " is: " + new string(randomString));
        }
    }
}
