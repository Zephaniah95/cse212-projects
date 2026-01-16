using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Plan
        // - Create a new array of doubles with size equal to 'length'.
        // - Loop from 0 to length-1.
        // - For each index i, calculate the multiple: number * (i + 1)
        //   (i + 1 because the first multiple is number itself, not 0).
        // - Store the result in the array at index i.
        // - Return the array after the loop finishes.

        double[] multiples = new double[length]; // Step 2: Create the array

        for (int i = 0; i < length; i++) // Step 3: Loop through indices
        {
            multiples[i] = number * (i + 1); // Step 4: Compute multiple and store
        }

        return multiples; // Step 5: Return the filled array
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then 
    /// the list after the function runs should be List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  
    /// The value of amount will be in the range of 1 to data.Count, inclusive.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Plan
        // - The goal is to move the last 'amount' elements to the front.
        // - Use GetRange to get the slice of the last 'amount' elements.
        // - Use RemoveRange to remove those last 'amount' elements from the original list.
        // - Use InsertRange at index 0 to insert the removed slice at the beginning.

        // Step 2: Get the last 'amount' elements
        List<int> tail = data.GetRange(data.Count - amount, amount);

        // Step 3: Remove the last 'amount' elements from the original list
        data.RemoveRange(data.Count - amount, amount);

        // Step 4: Insert the tail at the beginning of the list
        data.InsertRange(0, tail);

        // Step 5: Now 'data' has been rotated to the right by 'amount'
    }
}
