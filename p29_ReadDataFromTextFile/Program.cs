using System;
using System.IO;

class p29_ReadDataFromTextFile {
    static void Main() {
        // Specify the file path
        string filePath = @"C:\Users\M Venkatesh\OneDrive\Documents\Skills\Java\Problems\text.txt";

        try {
            // Using StreamReader to read the file
            using (StreamReader sr = new StreamReader(filePath)) {
                string line;
                while ((line = sr.ReadLine()) != null) {
                    Console.WriteLine(line);
                }
            }
        }
        catch (FileNotFoundException) {
            Console.WriteLine("File not found at: " + filePath);
        }
        catch (Exception e) {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}
