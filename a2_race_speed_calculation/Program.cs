// You are given an integer array S where each element represents the initial speed (in meters per minute) of N contestants in a race. Each contestant's speed decreases by 1 meter per minute after every minute. The speed cannot go below zero, meaning that once a contestant's speed becomes zero, they cannot move further. Your task is to determine how many contestants will be able to cross a given distance K meters within M minutes (inclusive). If no contestants can cross the distance, return -1.

// Input Specification:

// input1: An integer value N representing the number of contestants

// input2: An integer array S where each element represents the initial speed of a contestant.

// input3: An integer value K representing the total distance that needs to be crossed.

// input4: An integer value M representing the total time (in minutes) within which uks the contestants must cross the distance.
// using System;

public class UserMainCode
{
    public static int countContestant(int input1, int[] input2, int input3, int input4)
    {
        int count = 0;

        // Iterate through each contestant
        for (int i = 0; i < input1; i++)
        {
            int speed = input2[i];
            int totalDistance = 0;

            // Calculate the total distance covered in 'input4' minutes
            for (int j = 0; j < input4; j++)
            {
                if (speed > 0)
                {
                    totalDistance += speed;
                    speed--; // Decrease speed per minute
                }
                else
                {
                    break; // Stop adding distance if speed becomes zero
                }
            }

            // Check if the contestant crosses at least input3 distance
            if (totalDistance >= input3)
            {
                count++;
            }
        }

        return count > 0 ? count : -1;
    }

    // Test the function
    public static void Main(string[] args)
    {
        int N = 4;
        int[] S = { 5, 3, 7, 2 };
        int K = 10;
        int M = 3;

        Console.WriteLine(countContestant(N, S, K, M)); // Expected Output: 2
    }
}
