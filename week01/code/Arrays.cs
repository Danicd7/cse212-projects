public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //this array stores the result of length
        double[] result = new double[length];
        //the for loop goes from 0 to length - 1
        //For each index i, set array[i] = number * (i + 1)
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result; // return the erray
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        int splitIndex = data.Count - amount;//calculats the starting index of the right-rotated portion.
        List<int> rotatedPart = data.GetRange(splitIndex, amount);//getRange for the amount 
        List<int> remainingPart = data.GetRange(0, splitIndex);//getRange for the remainingPart

        data.Clear();// clears the original list
        data.AddRange(rotatedPart);// add the rightmost part first
        data.AddRange(remainingPart);// then add the rest
    }
}
