using System;
using System.ComponentModel;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Question 1: Write a method that takes an integer array  as an input and sorts it. It's a one dimesional array. 
        For example A = [4, 7, 3, 5, 1, 10, 90, 8] output of the array should be[1, 3, 4, 5, 7, 8, 10, 90]
        */


        int[] arr = new int[] { 2,6,3,8,2,1,10,7,4,12};
        int[] total = intArray(arr);

        for (int i = 0; i < total.Length; i++)
        {
            WriteLine(total[i]);
        }


    }


    static int[] intArray(int[] arr)
    {
        //int[] newvalue = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[j] < arr[i])
                {

                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            
        }
        return arr;
    }
}