//Calculating distance between alphabets of a string
using System; 

class a1_calculate_distance {
    public static void Main(string[] args)
        {
            Console.WriteLine(calculateDistance("venky")); 
            Console.WriteLine(calculateDistance("rgukt")); 
        }
    
    public static int calculateDistance(string input)
    {
        if(string.IsNullOrEmpty(input) || input.Length == 1){
            return 0;
        }

        int totalDistance = 0;

        for(int i =1; i< input.Length; i++)
        {
            totalDistance += Math.Abs(input[i] - input[i-1]);
        }
        return totalDistance;
    }
}