using System;
using System.ComponentModel;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
      


        int[] arr = new int[] {2,6,3,8,1,10,7,4,12};
        /*
        int[] total = intArray(arr);

        for (int i = 0; i < total.Length; i++)
        {
            WriteLine(total[i]);
        }
        */
        WriteLine("************************************");
        WriteLine("enter the target number");
        int target = int.Parse(ReadLine());
        int x = searchForElement(arr, target);
        //WriteLine(searchForElement(arr, target));
       

        if (x!= -1)
        {
            WriteLine("Target {0} found at position : {1}", target, x);
        }
        else
        {
            WriteLine("Target {0} not found in the array.", target);
        }


    }

    /*
        Question 1: Write a method that takes an integer array  as an input and sorts it. It's a one dimesional array. 
        For example A = [4, 7, 3, 5, 1, 10, 90, 8] output of the array should be[1, 3, 4, 5, 7, 8, 10, 90]
        */
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

    /*
    Question 2: Write a method to implement searching.The method
        takes an integer input array and an integer searchNumber.
        If the number exist in the array it should return the index 
        of the array in which it exist if it doesn't exist it should
        return -1. You can assume that the array is sorted.
        For example A = [1, 3, 4, 5, 7, 8, 10, 90]and the search number is 7 
        it should return 5 , because 7 is on 5th index of the array.
        For example A = [1, 3, 4, 5, 7, 8, 10, 90] and the search number is 
        20 it should return -1 , because it does not exist
    */

    static  int searchForElement(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {

                if (arr[i] == target)
                {
                    return (i+1);
                }

        }

        return (-1);
    }
}
